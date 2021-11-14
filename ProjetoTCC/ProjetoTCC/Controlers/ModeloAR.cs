using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoTCC.Connector;
using ProjetoTCC.Forms;

namespace ProjetoTCC.Controlers
{
    class ModeloAR
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        Conector con = new Conector();
               
        public static int delays = 2;
        public static int Qtdeinputs = 7;        
        public static int QtdOutput = 0;
       



        public double[] RetornaVetorInput(String produto)
        {
            cmd.CommandText = @"select count(*) as QtdeLinhas from(select data_venda, SUM(quantidade) as quantidade 
            from dbo.Venda where produto = @produto group by data_venda) as quantidade;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@produto", produto);
            cmd.Connection = con.Conectar();
            int Tamanhoinput = (int)cmd.ExecuteScalar();
            double[] input = new double[Tamanhoinput];
            con.Desconectar();
            con.Conectar();
            cmd.CommandText = @"select data_venda, SUM(quantidade) as quantidade from dbo.Venda where produto = @produto group by data_venda;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@produto", produto);
            cmd.Connection = con.Conectar();
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                string informação = dr["quantidade"].ToString();
                //aux.Add(informação);
                input[i] = (Convert.ToDouble(informação));
                Console.WriteLine(input[i]);
                i++;
            }
            i = 0;//não precisa QUEBRA -->  retirar o aux , input e output serão a mesma coisa aqui !!!!!! !!!!!! 
            //Qtdeinputs = linha; 
            con.Desconectar();
            dr.Close();
            return input;
        }

        public double[][] Zeros(int nLinhas, int nColunas)
        {
            double[][] MatrizZeros = new double[nLinhas][];
            for (int i = 0; i < nLinhas; i++)
            {
                MatrizZeros[i] = new double[nColunas];
            }
            //Console.WriteLine("Matriz Zeros:");
            for (int i = 0; i < nLinhas; i++)
            {
                for (int j = 0; j < nColunas; j++)
                {
                    //MatrizZeros[i] = new double[j] {0};
                    MatrizZeros[i][j] = 0;
                    //Console.Write("-"+MatrizZeros[i, j]);
                    //Console.Write(i);
                    //Console.Write(j);
                }
                Console.WriteLine();
            }
            return MatrizZeros;
        }


        public (double[][], double[][]) MontarMatriz(double[] input2, int m, double[] output, int n, int d)
        {
            
            double[] input = input2;
            Array.Reverse(input);
            

            // a é resultado dos zeros de tamanho 1:m            
            //double[][] a = new double[Zeros(1, m).Length][];
            //Console.WriteLine("tamanho zero a"+ Zeros(1, m).Length);
            // b declarado com tamanho de 0 ate n
            //double[][] b = new double[Zeros(1, n).Length][];
            double[][] a = Zeros(1, m);
            double[][] b = Zeros(1, n);

            Console.WriteLine(m);
            Console.WriteLine("tamanho linhas a: " + a.Length);
            Console.WriteLine("tamanho colunas a: " + a[0].Length);
            Console.WriteLine("a : ");

            for (int i = 0; i < m; i++)
            {
                //---------------------------------------------------------------------------------------------------------------------------
                a[0][i] = m - i + d;//m + 1 - i + d;-->  discutir alteraçao: com esse +1 excede o indice da matriz para X receber-->  testar para d > 1
                Console.Write("a1: " + a[0][i] + " ");
            }


            //Console.WriteLine(n);
            Console.WriteLine();
            Console.WriteLine("tamanho linhas b: " + b.Length);
            Console.WriteLine("tamanho colunas b: " + b[0].Length);
            Console.WriteLine("b : ");

            for (int i = 0; i < n; i++)
            {
                b[0][i] = n - i;
                Console.Write("b1: " + b[i] + " ");
            }

            int t = output.Length;//n recebe a mesma quantidade de inputs (n de itens) n=m
            //Console.WriteLine("tamanho output:  " + t);
            Console.WriteLine("X  " + (t - m - d)); //(input, 5, output, 0, 2); esta retornando -2 --: naopegar todo o vetor em m

            Console.WriteLine("tamanho de x:   linhas: " + (t - m - d) + "  colunas: " + m);
            Console.WriteLine("tamanho de y:  linhas: " + (t - m - d) + "  colunas : " + 1);

            double[][] X = Zeros((t - m - d), m);//x é matriz
            double[][] Y = Zeros((t - m - d), 1);// y é vetor de 1 colula (ou 1 linha) cada item relacionado a uma linha de x

            Console.WriteLine("n+m:  " + (n + m) + "m:  " + m);
            Console.WriteLine("t-m-d:  " + (t - m - d));
            for (int i = 0; i < t - m - d; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //double outp = Convert.ToInt32(value: b[j]);
                    //Console.Write(" b --> "+b[j]);
                    X[i][j] = output[(Convert.ToInt32(b[j]))];
                    Console.Write("X  " + X[i][j] + " ");
                }
                for (int k = n; k < n + m; k++)
                {
                    Console.Write(" a - x ---> " + (a[0][k - n]));
                    X[i][k] = input[(Convert.ToInt32(a[0][k - n]))];//inverter o vetor input

                    //Console.Write("" + i + k + " ");
                    Console.WriteLine("X - " + X[i][k] + " ");
                }
                Console.WriteLine("a2: ------");
                for (int l = 0; l < m; l++)//ver depois o porque COMEÇA EM 1!!!!!!!
                {
                    a[0][l] = a[0][l] + 1;

                    Console.WriteLine("2a " + a[0][l]);

                }
                Console.WriteLine("");
                Console.WriteLine("b2: ------");
                for (int l = 1; l < n; l++)
                {
                    b[0][l] = b[0][l] + 1;
                    Console.Write("2b " + b[0][l]);
                }
                Console.WriteLine("");

                Y[i][0] = Convert.ToDouble(output[i + n]);// verificar se é 0 mesmo               
                Console.WriteLine("Y: " + Y[i]);
            }
            return (X, Y);
        }

        public double[][] FormaTransposta(double[][] Xinput)
        {
            int i, j;
            Console.WriteLine("MATRIZ TRASPOSTA:");
            Console.WriteLine("Tamanho recebido: " + Xinput.Length);
            double[][] Xtransposta = new double[Xinput[0].Length][];
            //Xtransposta[0] = new double[tamanho];//CONSERTAR TAMANHO!!!!
            
            for (i = 0; i < Xinput[0].Length; i++)
            {
                for (j = 0; j < Xinput.Length; j++)
                {
                    Xtransposta[i] = new double[Xinput.Length];
                }
            }
            
            Console.WriteLine("MATRIZ TRASPOSTA: ");
            for (i = 0; i < Xinput[0].Length; i++)
            {
                for (j = 0; j < Xinput.Length; j++)
                {
                    //Console.WriteLine(" "+ 1 + " ");                    
                    Xtransposta[i][j] = Xinput[j][i];
                    Console.Write(" "+ Xtransposta[i][j] + " ");
                    //Console.Write(" " + Xtransposta[i][j] + " ");
                }
                Console.WriteLine();

            }
            return Xtransposta;
        }

        public double [][] CalculaMatrizQuadrada(double [][] X1, double[][] X2)
        {
            int i, j;

            Console.WriteLine("Tamanho recebido X1: " + X1.Length);
            Console.WriteLine("Tamanho recebido X2: " + X2.Length);
            int tamanho = X1.Length;
            double[][] XResult = new double[tamanho][];
            if (X1.Length == X2.Length)
            {
                //Xtransposta[0] = new double[tamanho];//CONSERTAR TAMANHO!!!!
                for (i = 0; i < tamanho; i++)
                {
                    XResult[i] = new double[tamanho];
                }
                for (i = 0; i < tamanho; i++)
                {
                    for (j = 0; j < tamanho; j++)
                    {
                        XResult[i][j] = X1[i][j] * X2[j][i];
                    }
                }
            }
            else
            {
                Console.WriteLine("MAS MATRIZES INFORMADAS PRECISAM SER MATRIZES QUADRADAS: ");
                Console.WriteLine("MATRIZES COM MESMA QUANTIDADE DE LINHA E COLUNAS");
            }            
            return XResult;
        }


        public double [][] CalculaMatriz(double[][] matA, double[][]matB)
        {
            double[][] matAB = new double[matA.Length][];
            try
            {
                if (matA.Length==matB[0].Length)
                {
                    
                    double acumula=0;
                    for (int i = 0; i < matA.Length; i++)
                    {
                        matAB[i] = new double[matB[0].Length];
                    }
                    //cada iteração representa uma linha da matriz A
                    for (int linha = 0; linha < matAB.Length; linha++)
                    {
                        //em cada linha de A, itera nas colunas de B
                        for (int coluna = 0; coluna < matAB[linha].Length; coluna++)
                        {
                            //itera, ao mesmo tempo, entre os elementos da linha de A e da coluna de B
                            for (int i = 0; i < matAB[linha].Length; i++)
                            {
                                //acumula representa os valores que estávamos reservando
                                acumula = acumula + matA[linha][i] * matB[i][coluna];
                            }
                            //quando a execução está aqui, já se tem mais um elemento da matriz AB
                            matAB[linha][coluna] = acumula;
                            Console.Write(matAB[linha][coluna]);

                            //a variável então é zerada para que possa referenciar um novo elemento de AB
                            acumula = 0;
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("TAMANHO DAS MATRIZES NAO CONDIZEM - AMBAS DEVEM SER QUADRADAS");
                }
            }catch(Exception e)
            {
                Console.WriteLine("Erro try - catch CALCULA MATRIZ: "+ e);
            }
            for (int linha = 0; linha < matAB.Length; linha++)
            {
                //em cada linha de A, itera nas colunas de B
                for (int coluna = 0; coluna < matAB[linha].Length; coluna++)
                {
                    Console.Write("  " + matAB + "  ");
                }
                Console.WriteLine();
            }
                    return matAB;
            
            
        }
    }
}
