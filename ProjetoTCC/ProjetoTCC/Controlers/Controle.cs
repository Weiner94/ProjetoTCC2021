using ProjetoTCC.Connector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTCC.Controlers
{
    class Controle
    {
        public bool verificador;
        public String mensagem = "";
        ModeloAR modelo = new ModeloAR();
        CalculoMatriz calculoMatriz = new CalculoMatriz();
        DAOConnector DAO = new DAOConnector();
        SqlCommand cmd = new SqlCommand();
        Conector con = new Conector();
        SqlDataReader dr;


        public bool verificarLogin(String nome, String Senha)
        {
            DAOConnector loginDAO = new DAOConnector();
            verificador = loginDAO.verificarLogin(nome, Senha);
            if (!loginDAO.mensagemDAO.Equals(""))
            {
                this.mensagem = loginDAO.mensagemDAO;

            }
            return verificador;
        }

        public String CadastrarUsuario(String nome, String senha, String txbConfSenha)
        {
            DAOConnector loginDAO = new DAOConnector();
            this.mensagem = loginDAO.cadastrarUsuarioDAO(nome, senha, txbConfSenha);
            if (loginDAO.verificadorDAO)
            {
                this.verificador = true;
            }
            return mensagem;
        }


        public String CadastrarProduto(String nomeProduto, String lucroProduto)
        {
            DAOConnector cadastrarProduto = new DAOConnector();
            this.mensagem = cadastrarProduto.cadastrarProdutoDAO(nomeProduto, lucroProduto);
            return mensagem;
        }

        


        public double[] PrimeiroTheta(int IdFornecedor, string produto, int Tamanhoinput, int TamanhoOutput, int delay)
        {

            //GUARDAR K EM TABELA SQL !!!!!!!!!!!!!!!!!!!
            ModeloAR modelo = new ModeloAR();
            CalculoMatriz calculoMatriz = new CalculoMatriz();
            //double[] input = new double[] { 5,8,10,4,3,13,7,1,6,14,11,9,7,4,15,13,6,4,8,1,11,12,15,8,14 };
            double[] input = new double[] { };
            input = modelo.RetornaVetorInput(produto);
            Console.WriteLine("-------");
           


            double[] output = new double[input.Length];

            double[][] Y = new double[Tamanhoinput][];
            double[][] X = new double[Tamanhoinput][];
            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < X.Length; j++)
                {
                    X[i] = new double[X.Length];
                }
            }
            for (int i = 0; i < Y.Length; i++)
            {
                for (int j = 0; j < Y.Length; j++)
                {
                    Y[i] = new double[1];
                }
            }
            double[][] theta = new double[Tamanhoinput][];
            for (int i = 0; i < theta.Length; i++)
            {
                for (int j = 0; j < theta.Length; j++)
                {
                    theta[i] = new double[theta.Length];
                }
            }
            double[][] K = new double[Tamanhoinput][];
            for (int i = 0; i < X.Length; i++)
            {
                K[i] = new double[X.Length];
            }

            //modelo.RetornaVetorinput("Coca Cola 2L");

            (X, Y) = modelo.MontarMatriz(input, Tamanhoinput, input, 0, delay);// output e input aqui é o mesmo
            Console.WriteLine("X.length:  " + X.Length);

            Console.WriteLine("******** MATRIZ x: ");
            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < X[i].Length; j++)
                {
                    Console.Write(" " + X[i][j]);
                }
                Console.WriteLine();
            }
            modelo.FormaTransposta(X);
            theta = calculoMatriz.MatrixProduct(calculoMatriz.MatrixProduct(calculoMatriz.MatrixInverse(calculoMatriz.MatrixProduct(modelo.FormaTransposta(X), X)), modelo.FormaTransposta(X)), Y);
            
            for (int i = 0; i < Y.Length; i++)
            {
                for (int j = 0; j < Y[i].Length; j++)
                {
                    Console.Write(" " + Y[i][j]);
                }
            }
            
            K = calculoMatriz.MatrixInverse(calculoMatriz.MatrixProduct(modelo.FormaTransposta(X), X));
           
            for (int i = 0; i < K.Length; i++)
            {
                for (int j = 0; j < K[i].Length; j++)
                {
                    Console.Write(" | " + K[i][j]);
                }
                Console.WriteLine();
            }

           
            double[] inputTheta = new double[theta.Length];
            double[] ResultadoPrevisao = new double[1]; // Xtheta virou ResultadoPrevisao
           
           

            //-------------------------------------CALCULA VETOR THETA COM INPUT(ULTIMOS DADOS DE VENDA)-----------------------00000000
          
            int ind = 0;
            int revInput = input.Length - 1;
            int revTheta = theta.Length - 1;
            double soma = 0;
           
            while (ind < theta.Length)
            {
                
                inputTheta[ind] = (input[revInput]) * (theta[revTheta][0]);                
                ind++;
                revInput--;
                revTheta--;
            }
           
            for (int i = 0; i < inputTheta.Length; i++)
            {
                
                soma = soma + inputTheta[i];
                
            }
            ResultadoPrevisao[0] = soma;
           
            try
            {
                int IdProduto = DAO.IdProdutoCorrente(produto, IdFornecedor);
                //-----------------------------------INSERT PRIMEITO THETA--------------------------------
                cmd.CommandText = "insert into dbo.DadosTheta(dadoTheta, fk_produto) values(@dadoTheta, @fk_produto);";
                cmd.Parameters.Clear();
                try
                {
                    for (int i = 0; i < theta.Length; i++)
                    {

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@dadoTheta", theta[i][0]);
                        cmd.Parameters.AddWithValue("@fk_produto", IdProduto);
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.Desconectar();

                    }
                    Console.WriteLine("THETA CADASTRADO COM SUESSO");


                }
                catch (SqlException e)
                {
                    
                    MessageBox.Show("ERRO CADASTRO DADOS THETA:   " + e);
                    Console.WriteLine(e);
                    con.Desconectar();
                    dr.Close();
                }
                //-----------------------------------INSERT PRIMEITO K--------------------------------
                cmd.CommandText = "insert into dbo.DadosK (dadoK, fk_produto) values(@dadoK, @fk_produto);";
                cmd.Parameters.Clear();
                try
                {
                    for (int i = 0; i < K.Length; i++)
                    {
                        for (int j = 0; j < K[i].Length; j++)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@dadoK", K[i][j]);// CONFERIR SE K ESTA RECEBENDO OS CAVORES CORRETAMENTE-->  
                            //-->  SE ESTA RECEBENDO OS VALORES DE COLUNA EM LINHA E VICE VERSA!!!
                            cmd.Parameters.AddWithValue("@fk_produto", IdProduto);
                            cmd.Connection = con.Conectar();
                            cmd.ExecuteNonQuery();
                            con.Desconectar();

                        }
                    }
                    Console.WriteLine("K CADASTRADO COM SUESSO");
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERRO INSERT K PRIMEIRO THETA:      " + e);
                    MessageBox.Show("ERRO INSERT K PRIMEIRO THETA:       " + e);
                    con.Desconectar();
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO GERAL 1 THETA / k:       " + e);
                MessageBox.Show("ERRO GERAL 1 THETA / k:     " + e);
            }
            return ResultadoPrevisao;
        }





        int tamanhoTheta;// RESOLVER ISSO!!!! PARA OUTRAS VARAVEIS COM A MESMA FUNÇAO
        public double[] AtualizaTheta(int IdFornecedor, string produto, int Tamanhoinput, int TamanhoOutput, int delay)
        {

            double[] input = new double[] { };
            input = modelo.RetornaVetorInput(produto);

            double[][] X = new double[Tamanhoinput][];
            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < X.Length; j++)
                {
                    X[i] = new double[X.Length];
                }
            }
            double[][] Y = new double[Tamanhoinput][];
            for (int i = 0; i < Y.Length; i++)
            {
                for (int j = 0; j < Y.Length; j++)
                {
                    Y[i] = new double[1];
                }
            }

            double[][] K = new double[Tamanhoinput][];
            for (int i = 0; i < X.Length; i++)
            {
                K[i] = new double[X[0].Length];
            }

            (X, Y) = modelo.MontarMatriz(input, Tamanhoinput, input, 0, delay);

            int IdProduto = DAO.IdProdutoCorrente(produto, IdFornecedor);
            try
            {
                cmd.CommandText = @"select count(*) as QtdeLinhas from dbo.DadosK WHERE	fk_produto = @fk_produto;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fk_produto", IdProduto);
                cmd.Connection = con.Conectar();
                int TamanhoDadosK = (int)cmd.ExecuteScalar();
                double[] DadosK = new double[TamanhoDadosK];
                con.Desconectar();


                cmd.CommandText = "select dadoK as DADOS from dbo.DadosK WHERE	fk_produto = @fk_produto;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fk_produto", IdProduto);
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                int indice = 0;
                while (dr.Read())
                {
                    string informação = dr["DADOS"].ToString();
                    DadosK[indice] = (Convert.ToDouble(informação));
                    indice++;
                }
                indice = 0;
                Console.WriteLine();
                Console.WriteLine("MATRIZ DADOSK SQL");
                for (int i = 0; i < K.Length; i++)
                {
                    for (int j = 0; j < K[i].Length; j++)
                    {
                        if (indice < DadosK.Length)
                            K[j][i] = DadosK[indice];
                        indice++;
                        Console.Write(" " + K[j][i] + " |");
                    }
                    Console.WriteLine();
                }
                con.Desconectar();
                dr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO SELECT DADOSk ATUALIZA THETA - SEGUNDA ROTINA:       " + e);
                MessageBox.Show("ERRO SELECT DADOSk ATUALIZA THETA - SEGUNDA ROTINA :       " + e);
            }

            Console.WriteLine();
            Console.WriteLine();        

            cmd.CommandText = @"select count(*) as QtdeLinhas from dbo.DadosTheta WHERE	fk_produto = @fk_produto;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@fk_produto", IdProduto);
            try
            {
                cmd.Connection = con.Conectar();
                tamanhoTheta = (int)cmd.ExecuteScalar();
                con.Desconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO RECEBER TAMANHO DE THETA SQL:           " + e);
            }
            double[][] novoTheta = new double[tamanhoTheta][];
            double[] theta = new double[tamanhoTheta];
            //---------------------------RECALCULA ADEMANDA PARA OBTER ERRO!!!-------------------

            try
            {
                cmd.CommandText = "select dadoTheta as DADOSTHETA from dbo.DadosTheta WHERE	fk_produto = @fk_produto;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fk_produto", IdProduto);
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                int indice = 0;
                while (dr.Read())
                {
                    if (indice < theta.Length)
                    {
                        string informação = dr["DADOSTHETA"].ToString();
                        theta[indice] = (Convert.ToDouble(informação));
                        indice++;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO OBTER VALORES THETA SQL - SEGUNDA ROTINA             " + e);
            }
            double[] inputxThetaAnterior = new double[theta.Length];
            double[] ResultadoPrevisaoAnterior = new double[1];
            int ind = 0;
            int revInput = input.Length - 1;
            int revTheta = theta.Length - 1;
            double soma = 0;
            // 1 valor de theta = valor mais antigo do input???
            while (ind < theta.Length)
            {
                Console.WriteLine("ind   " + ind + "      INPUT :  " + input[revInput]);
                Console.WriteLine("indtheta    " + revInput + "     THETA :  " + theta[revTheta]);
                inputxThetaAnterior[ind] = (input[revInput]) * (theta[revTheta]);// rever issso
                Console.WriteLine(input[revInput] + " * " + theta[revTheta] + " = " + input[ind]);
                Console.WriteLine();
                ind++;
                revInput--;
                revTheta--;
            }
            Console.WriteLine("soma theta_________________________________");
            for (int i = 0; i < inputxThetaAnterior.Length; i++)
            {
                Console.WriteLine(inputxThetaAnterior[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SOMA inputxThetaAnterior -->  UNICO VALOR PREVISÃO ");
            for (int i = 0; i < inputxThetaAnterior.Length; i++)
            {
                Console.WriteLine();
                Console.Write(soma + " ");
                soma = soma + inputxThetaAnterior[i];
                Console.Write("+  " + inputxThetaAnterior[i] + " = " + soma);
                Console.WriteLine();

                //thetaTeste[i][j] = Convert.ToDouble(theta[j]); 
            }
            Console.WriteLine("resultado previsão_________________________________");
            ResultadoPrevisaoAnterior[0] = soma;
            Console.WriteLine(ResultadoPrevisaoAnterior[0]);
            //ERRO: 
            double[][] erro = new double[1][];
            erro[0] = new double[1];
            // erro = valor real - valor previsão
            erro[0][0] = (input[input.Length - 1] - ResultadoPrevisaoAnterior[0]);
           



            Console.WriteLine();
            Console.WriteLine("PREVISÃO ----------------------------------------------");
            
            double[] resultadoPrevisao = new double[input.Length - theta.Length + 1];
            
            double[] inputInverso = input;
            Array.Reverse(inputInverso);
                      
            int k = 0;
            for (int i = input.Length-1; i >= 0; i--)
            {
                if (k>=(input.Length - theta.Length + 1))
                {
                    break;
                } 
                for (int j = theta.Length-1; j >= 0; j--)
                {                   
                   
                    resultadoPrevisao[k] = resultadoPrevisao[k] + (inputInverso[i + j - theta.Length + 1] * theta[j]);
                }
                k++;
                Console.WriteLine();
                Console.WriteLine("k:  " + k);
                Console.WriteLine(resultadoPrevisao[k-1]);
            }
            
         
            double[][] xVetor = new double[1][];
            xVetor[0] = new double[Tamanhoinput];
            for (int i = 0; i < xVetor.Length; i++)
            {
                xVetor[0][i] = input[i];// corrigir isso!!!!!!!!!!
            }  


            /*
            double[][] aNumerador = new double[Tamanhoinput][];
            for (int i = 0; i < K.Length; i++)
            {
                aNumerador[i] = new double[K[0].Length];
            }
            aNumerador = calculoMatriz.MatrixProduct(calculoMatriz.MatrixProduct(calculoMatriz.MatrixProduct(K, modelo.FormaTransposta(xVetor)), xVetor), K);// matriz do tamanho de K
            Console.WriteLine();
            Console.WriteLine("NUMERADOR: ");
            for (int i = 0; i < aNumerador.Length; i++)
            {
                for (int j = 0; i < aNumerador[0].Length; i++)
                {
                    Console.Write(Math.Round(aNumerador[i][j], 4).ToString().PadLeft(5, ' ') + "| ");
                }
            }
            Console.WriteLine();
            double[][] aDenomiador = new double[1][];
            aDenomiador[0] = new double[1];
            aDenomiador = calculoMatriz.MatrixProduct(calculoMatriz.MatrixProduct(xVetor, K), modelo.FormaTransposta(xVetor));// matriz 1x1 -->  trasformar para numero para somar o 1 
            Console.WriteLine();
            Console.WriteLine("DENOMINADOR");
            for (int i = 0; i < aDenomiador.Length; i++)
            {
                for (int j = 0; i < aDenomiador[0].Length; i++)
                {
                    Console.Write(Math.Round(aNumerador[i][j], 4).ToString().PadLeft(5, ' ') + "| ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("K ANTES DE IR PARA SQL");

            for (int i = 0; i < K.Length; i++)
            {
                for (int j = 0; j < K[i].Length; j++)
                {
                    //K[i][j] = K[i][j] - (calculoMatriz.MatrixProduct(calculoMatriz.MatrixProduct((calculoMatriz.MatrixProduct(K, modelo.FormaTransposta(xVetor))), (calculoMatriz.MatrixProduct(xVetor, K))), //calculoMatriz.MatrixProduct(xVetorAumentado, calculoMatriz.MatrixProduct(K, calculoMatriz.MatrixInverse(xVetor)))))[i][j];
                    // atulização do K -> 
                    K[i][j] = K[i][j] - (aNumerador[i][j] / aDenomiador[0][0] + 1);// divisão numerador/denominador!!! -->  vai sair matriz de tamanho K 
                                                                                   // errado tem q sert K - calculo
                    Console.Write(" " + K[i][j] + " |");
                }
                Console.WriteLine();
            }

            //----------------------------RETIRA DADOS ANTIGOS DE K E ADICIONA NOVOS EM SEGUIDA----------------------------------
            cmd.CommandText = @"delete from dbo.DadosK WHERE fk_produto = @fk_produto;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@fk_produto", IdProduto);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO DELETE DADOS K ATUALIZA THETA:            " + e);
                MessageBox.Show("ERRO DELETE DADOSK ATUALIZA THETA:               " + e);
            }
            cmd.CommandText = "insert into dbo.DadosK (dadoK, fk_produto) values(@dadoK, @fk_produto);";
            cmd.Parameters.Clear();
            try
            {
                for (int i = 0; i < K.Length; i++)
                {
                    for (int j = 0; j < K[i].Length; j++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@dadoK", K[i][j]);
                        cmd.Parameters.AddWithValue("@fk_produto", IdProduto);
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.Desconectar();
                    }
                }
                Console.WriteLine("K CADASTRADO COM SUESSO");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO INSERT K ATUALIZA THETA:      " + e);
                MessageBox.Show("ERRO INSERT K ATUALIZA THETA:       " + e);
                con.Desconectar();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("TESTE SAIDA K!!!!!!!!!!!!!!! :   ");

            for (int i = 0; i < K.Length; i++)
            {
                for (int j = 0; j < K[i].Length; j++)
                {
                    Console.Write("  | " + K[i][j]);
                }
                Console.WriteLine();
            }
            */
            

            //-----------------------------------------------ATUALIZA DADOS ANTIGOS DE THETA----------------------------------------------
            try
            {
                Console.WriteLine();
                Console.WriteLine("NOVO THETA SQL: ");

                //FAZER O ERRO TEM QUE SER ALGUM DIA DO IMPUT, MAS UM IMPUT DIFERENTE DO PRIMEIRTO THETA--> TEM DE ENTRAR DADOS NOVOS
                for (int i = 0; i < novoTheta.Length; i++)
                {
                    for (int j = 0; j < novoTheta.Length; j++)
                    {
                        //                                                               erro --> matriz coluna !!!!!! 1 coluna e 4 linhas-->  para esse caso!!!! 
                        //do lado direito do +  vetor do mesmo tamanho de theta 
                        //somar theta a esse vetor!!!
                        // indice por indice => ai tem o theta novo
                        novoTheta[i][0] = theta[i] + (calculoMatriz.MatrixProduct(calculoMatriz.MatrixProduct(K, modelo.FormaTransposta(xVetor)), erro)[i][j]);
                        Console.Write(" " + novoTheta[i][0] + " |");
                        Console.WriteLine();
                    }
                }

                //INSERIR NOVOTHETA NO BANCO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                cmd.CommandText = @"delete from dbo.DadosTheta WHERE fk_produto = @fk_produto;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fk_produto", IdProduto);
                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERRO DELETE DADOS ATUALIZA THETA - SEGUNDA ROTINA :            " + e);
                    MessageBox.Show("ERRO DELETE ATUALIZA THETA - SEGUNDA ROTINA :               " + e);
                }

                cmd.CommandText = "insert into dbo.DadosTheta(dadoTheta, fk_produto) values(@dadoTheta, @fk_produto);";
                cmd.Parameters.Clear();
                try
                {
                    for (int i = 0; i < theta.Length; i++)
                    {

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@dadoTheta", novoTheta[i][0]);
                        cmd.Parameters.AddWithValue("@fk_produto", IdProduto);
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.Desconectar();

                    }
                    Console.WriteLine("THETA CADASTRADO COM SUESSO");


                }
                catch (SqlException e)
                {
                    Console.WriteLine("ERRO COM BANCO DE DADOS");
                    Console.WriteLine("ERRO CADASTRO DADOS THETA:  " + e);
                    MessageBox.Show("ERRO CADASTRO DADOS THETA:   " + e);
                    Console.WriteLine(e);
                    con.Desconectar();
                    dr.Close();
                }
                con.Desconectar();

            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO GERAL ATUALIZAR DADOS NOVOTHETA - SEGUNDA ROTINA             " + e);
            }





            /*
            //--------------------------------RESULTADO NOVO VALOR PREVISÃO - RECURSIVO---------------------------------------            
            
            double[] inputxTheta = new double[theta.Length];
            ind = 0;
            revInput = xVetor.Length - 1;
            revTheta = novoTheta.Length - 1;
            soma = 0;
            // 1 valor de theta = valor mais antigo do input???
            while (ind < theta.Length)
            {
                //Console.WriteLine("ind   " + ind + "      INPUT :  " + input[revInput]);
                //Console.WriteLine("indtheta    " + revInput + "     THETA :  " + theta[revTheta]);
                //novoTheta[ind] =   (xVetor[revInput]) * (novoTheta[revTheta]);// rever issso
                //novoTheta[ind] = calculoMatriz.MatrixProduct(xVetor, novoTheta);// rever issso
                Console.WriteLine(input[revInput] + " * " + theta[revTheta] + " = " + input[ind]);
                Console.WriteLine();
                ind++;
                revInput--;
                revTheta--;
            }
            for (int i = 0; i < novoTheta.Length; i++)
            {
                //resultado[i] = 
            }
            //calculoMatriz.MatrixProduct(calculoMatriz.MatrixProduct(K, modelo.FormaTransposta(xVetor), erro);
            //aNumerador = calculoMatriz.MatrixProduct(calculoMatriz.MatrixProduct(calculoMatriz.MatrixProduct(K, modelo.FormaTransposta(xVetor)), xVetor), K);// matriz do tamanho de K
            //aDenomiador = calculoMatriz.MatrixProduct(calculoMatriz.MatrixProduct(xVetor, K), modelo.FormaTransposta(xVetor));// matriz 1x1 -->  trasformar para numero para somar o 1 


            //theta[i][j] = theta[i][j] - (aNumerador[i][j] / aDenomiador[0][0] + 1);
            */

            return resultadoPrevisao;
        }





    }
}
