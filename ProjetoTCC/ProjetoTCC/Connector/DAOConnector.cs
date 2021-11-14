using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoTCC.Connector
{
    class DAOConnector
    {
        public bool verificadorDAO = false;
        public String mensagemDAO;
        SqlCommand cmd = new SqlCommand();
        Conector con = new Conector();
        SqlDataReader dr;
        

        public bool verificarLogin(String nome, String senha)
        {
            cmd.CommandText = "select * from dbo.Usuario where nome=@nome and senha=@senha";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    verificadorDAO = true;
                    con.Desconectar();

                }
                this.mensagemDAO = "";
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagemDAO = "ERRO COM O BANCO DE DADOS";
            }
            //sql para verificar se tem no banco de dados
            return verificadorDAO;
        }

        public String cadastrarUsuarioDAO(String nome, String senha, String txbConfSenha)
        {
            verificadorDAO = false;
            if (senha == txbConfSenha)
            {
                cmd.CommandText = "insert into dbo.Usuario (nome,senha) values (@nome, @Senha)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nome", nome);                
                cmd.Parameters.AddWithValue("@senha", senha);
                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    //con.Desconectar();
                    this.mensagemDAO = "CADASTRADO COM SUESSO";
                    verificadorDAO = true;
                    con.Desconectar();
                }
                catch (SqlException)
                {
                    this.mensagemDAO = "ERRO COM BANCO DE DADOS";
                }
            }
            else
            {
                this.mensagemDAO = "SENHA NÃO CORRESPONDEM";
            }
            return mensagemDAO;
        }

        public String cadastrarProdutoDAO(String nomeProduto, String lucroProduto)
        {

            verificadorDAO = false;

            cmd.CommandText = "insert into dbo.Produto (nome,porcentagem_lucro) values (@nome, @porcentagem_lucro)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", nomeProduto);
            cmd.Parameters.AddWithValue("@porcentagem_lucro", lucroProduto);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                //con.Desconectar();
                this.mensagemDAO = "CADASTRADO COM SUESSO";
                verificadorDAO = true;

                con.Desconectar();

            }

            /*catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }*/
            catch (SqlException)
            {
                this.mensagemDAO = "ERRO COM BANCO DE DADOS";
            }
            dr.Close();
            return mensagemDAO;
        }

        public String cadastrarVendaDAO(String produto, float quantidade, float total, /*,*/ float valor_un_g, int fk_venda_usuario, int cod_venda)
        {
            /*DateTime.Now.ToString("dd/MM/yyyy");
            DateTime data = DateTime.Now;
            string formato = "yyyy-MM-ddTHH:mm:ss";*/
            



            cmd.CommandText = "insert into dbo.Venda (produto, quantidade, total, data_venda, valor_un_g, fk_venda_usuario, cod_venda) values (@produto, @quantidade,@total, @data_venda, @valor_un_g, @fk_venda_usuario, @cod_venda)";
            //cmd.CommandText = "insert into dbo.Venda (produto, quantidade, total,  valor_un_g, fk_venda_usuario, cod_venda) values (@produto, @quantidade,@total, @valor_un_g, @fk_venda_usuario, @cod_venda)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@produto", produto);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@data_venda", DateTime.Now.ToString("dd/MM/yyyy"));//data.ToString(formato)); //DateTime.Now.ToString("dd-MM-yyyy"));//TESTAR ISSO AQUI!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            cmd.Parameters.AddWithValue("@valor_un_g", valor_un_g);
            cmd.Parameters.AddWithValue("@fk_venda_usuario", fk_venda_usuario);
            cmd.Parameters.AddWithValue("@cod_venda", cod_venda);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                this.mensagemDAO = "ADICIONADO";
                verificadorDAO = true;
            }

            catch (SqlException e)
            {
                Console.WriteLine("ERRO INCLUSÃO PRODUTO -->  VENDA:        " + e);
            }
            con.Desconectar();
            return mensagemDAO;
        }


        public int CodVenda_Corrente()
        {
            int maxId = 0;
            cmd.CommandText = "select * from dbo.Venda";
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Close();
                    cmd.CommandText = "select MAX(cod_venda) from dbo.Venda";
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    maxId = (int)cmd.ExecuteScalar();
                    maxId = maxId + 1;
                    con.Desconectar();
                }
                else
                {
                    maxId = 1;
                }
            }
            catch
            {

            }
            cmd.Parameters.Clear();
            return maxId;
        }

        public void CancelarVenda(int cod_venda)
        {                   
            cmd.CommandText = "delete from dbo.Venda where cod_venda = @cod_venda";
            cmd.Parameters.Clear();            
            cmd.Parameters.AddWithValue("@cod_venda", cod_venda);           
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("  ERRO AO CANCELAR VENDA         " + e);
                con.Desconectar();
            }            
        }


        public int CodPedido_Corrente()
        {
            cmd.CommandText = "select MAX(IdPedidoProduto) from dbo.Pedido_Produto"; //where cod_venda = @cod_venda";
            //cmd.Parameters.AddWithValue("@cod_venda", cod_venda);
            cmd.Parameters.Clear();
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            int maxId = (int)cmd.ExecuteScalar();
            //maxId = maxId + 1;
            con.Desconectar();
            return maxId;
        }

        public String CodFornecedor(String nome_fornecedor)
        {
            Int32 newProdID = 0;
            string sql = "select IdFornecedor from dbo.Fornecedor Where nome_fornecedor = @nome_fornecedor";

            Conector con = new Conector();
            using (con.Conectar())
            {
                SqlCommand cmd = new SqlCommand(sql);
                //cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters.AddWithValue("@nome_fornecedor", nome_fornecedor);
                try
                {
                    cmd.Connection = con.Conectar();
                    //con.Open();
                    newProdID = (Int32)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                con.Desconectar();
            }
            return newProdID.ToString();

        }

        public int IdProdutoCorrente(string produto, int idFornecedor)
        {
            int id = 0;
            cmd.CommandText = "select idProduto from dbo.Produto where nome = @produto and fk_produto_idFornecedor = @idFornecedor;"; //where cod_venda = @cod_venda";
            cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@produto", SqlDbType.Int).Value = produto;
            cmd.Parameters.AddWithValue("@produto", produto);
            //cmd.Parameters.AddWithValue("@idFornecedor", SqlDbType.Int).Value = idFornecedor;
            cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            id = (Int32)cmd.ExecuteScalar();
            con.Desconectar();
            return id;
        }

        //arrumar o id usuário-->pegar o usuário em sessão --> NOVO PROBLEMA ERRO ATUALIZAÇÃO FK PEDIDO, NAO ENXERGA ID PEDIDO APOS INSERÇÃO - ARRUMAR!!!!!
        public String CadastrarPedidoDAO(int idPedido, int produto, float quantidade, float totalProduto)
        {
            cmd.CommandText = "insert into dbo.Relacao_Pedido_Produto (fk_idPedidoProduto, fk_idProduto, quantidade, totalProduto )" +
                " values (@fk_idPedidoProduto, @fk_idProduto, @quantidade, @totalProduto)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@fk_idPedidoProduto", idPedido);
            cmd.Parameters.AddWithValue("@fk_idProduto", produto);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@totalProduto", totalProduto);
            //try
            //{
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            //con.Desconectar();
            this.mensagemDAO = "ADICIONADO";
            verificadorDAO = true;
            /* }
             catch (SqlException)
             {
                 this.mensagemDAO = "ERRO COM BANCO DE DADOS";
             }*/
            con.Desconectar();
            return mensagemDAO;
        }

        public void CadastroPedido(String estado, DateTime data_pedido, int FKPedidoProdutoUsuario, int FKPedidoProdutoFornecedor)
        {
            cmd.CommandText = "insert into dbo.Pedido_Produto (estado, data_pedido, FKPedidoProdutoUsuario, FKPedidoProdutoFornecedor )" +
                " values (@estado, @data_pedido, @FKPedidoProdutoUsuario, @FKPedidoProdutoFornecedor)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@data_pedido", data_pedido);
            cmd.Parameters.AddWithValue("@FKPedidoProdutoUsuario", FKPedidoProdutoUsuario);
            cmd.Parameters.AddWithValue("@FKPedidoProdutoFornecedor", FKPedidoProdutoFornecedor);

            //{
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            //con.Desconectar();
            this.mensagemDAO = "ADICIONADO";
            verificadorDAO = true;
            /* }
             catch (SqlException)
             {
                 this.mensagemDAO = "ERRO COM BANCO DE DADOS";
             }*/
            con.Desconectar();

        }

        public bool ProcuraRelacaoPP(int idPedido)
        {
            cmd.CommandText = "select fk_idPedidoProduto from dbo.Relacao_Pedido_Produto where fk_idPedidoProduto = @fk_idPedidoProduto";
            cmd.Parameters.AddWithValue("@fk_idPedidoProduto", idPedido);
            //cmd.Parameters.AddWithValue("@CPF", CPF);

            verificadorDAO = false;
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    verificadorDAO = true;
                    con.Desconectar();

                }
                this.mensagemDAO = "";
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagemDAO = "ERRO COM O BANCO DE DADOS";
            }
            //sql para verificar se tem no banco de dados
            return verificadorDAO;
        }


        public bool VerificaThetaProduto(int IdProduto)
        {
            cmd.CommandText = "select * from dbo.DadosModeloAR where fk_produto = @IdProduto;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdProduto", IdProduto);
            //cmd.Parameters.AddWithValue("@CPF", CPF);
            //cmd.Parameters.AddWithValue("@senha", IdFornecedor);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    verificadorDAO = true;
                    con.Desconectar();

                }
                con.Desconectar();
                dr.Close();

            }
            catch (SqlException e)
            {

                Console.WriteLine("ERRO COM O BANCO DE DADOS - VerificarThetaProduto");
                Console.WriteLine(e);


            }
            //sql para verificar se tem no banco de dados
            return verificadorDAO;
        }
        public bool VerificaDadoK(int IdProduto)
        {
            cmd.CommandText = "select * from dbo.DadosK where fk_produto = @IdProduto;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@IdProduto", IdProduto);
            //cmd.Parameters.AddWithValue("@CPF", CPF);
            //cmd.Parameters.AddWithValue("@senha", IdFornecedor);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    verificadorDAO = true;
                    con.Desconectar();

                }
                con.Desconectar();
                dr.Close();

            }
            catch (SqlException e)
            {

                Console.WriteLine("ERRO COM O BANCO DE DADOS - VerificarThetaProduto");
                Console.WriteLine(e);


            }
            //sql para verificar se tem no banco de dados
            return verificadorDAO;
        }

        





    }
}
