using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoTCC.Connector;

namespace ProjetoTCC.Forms
{
    public partial class FrmReceberPedido : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        Conector con = new Conector();
        int IDPedido = 0;
        
        public FrmReceberPedido()
        {
            InitializeComponent();
        }

        private void FrmReceberPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Pedido_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pedido_ProdutoTableAdapter.Fill(this.dBTCCDataSet.Pedido_Produto);
            PreencherPP();

        }

        private void PreencherPP()
        {
           
            //CodPedido.Text 
            try
            {
                con.Conectar(); // Abre a conexão com banco de dados
                cmd.CommandText = @"select pp.IdPedidoProduto, pp.data_recebimento, pp.estado, pp.data_pedido, pp.data_entrega,  u.nome, f.nome_fornecedor 
                                    from dbo.Pedido_Produto as pp 
                                    Inner join dbo.Usuario as u on pp.FKPedidoProdutoUsuario = u.IdUsuario
                                    inner join dbo.Fornecedor as f on pp.FKPedidoProdutoFornecedor = f.IdFornecedor 
                                    where pp.estado = 'aguardando'";
                
                cmd.Parameters.Clear();
                cmd.Connection = con.Conectar();                
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                   
                    DataTable dt = new DataTable();
                    dt.Load(dr); 
                    DataGridViewPP.DataSource = dt;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                con.Desconectar(); // Fecha a conexão com o BD
            }
        }

        private void PreencherRPP()
        {
            
            //CodPedido.Text 
            try
            {
                con.Conectar(); // Abre a conexão com banco de dados
                cmd.CommandText = @"select rpp.IdRelacaoPP, p.nome, p.preco_compra, rpp.quantidade from dbo.Produto as p
                                    inner join dbo.Relacao_Pedido_Produto as rpp
                                    on rpp.fk_idPedidoProduto = @fk_idPedidoProduto and rpp.fk_idProduto = p.IdProduto;";
              
                cmd.Parameters.Clear();
                cmd.Connection = con.Conectar();
                cmd.Parameters.AddWithValue("@fk_idPedidoProduto", IDPedido);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    DataGridViewRPP.DataSource = dt; //Preenche o DataGridView
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                con.Desconectar(); // Fecha a conexão com o BD
            }
        }

        private void ReceberPedido()
        {
            try
            {
                con.Conectar(); // Abre a conexão com banco de dados
                cmd.CommandText = @"update dbo.Pedido_Produto set estado='entregue', data_recebimento = @data_recebimento where IdPedidoProduto = @IDPedido;";               
                cmd.Parameters.Clear();
                cmd.Connection = con.Conectar();
                cmd.Parameters.AddWithValue("@IDPedido", IDPedido);
                cmd.Parameters.AddWithValue("@data_recebimento", DateTime.Now);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    DataGridViewPP.DataSource = dt; //Preenche o DataGridView
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                con.Desconectar(); // Fecha a conexão com o BD
            }
        }

        private void DataGridViewPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDPedido = int.Parse(DataGridViewPP.Rows[e.RowIndex].Cells["IdPedidoProduto"].Value.ToString());
            TxbCodPP.Text = IDPedido.ToString();
            PreencherRPP();

        }

        private void BtnReceber_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("DESEJA PROSSEGUIR COM O RECEBIMENTO DO PEDIDO?", "MENSAGEM DE SEGURANÇA", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirmar.ToString().ToUpper() == "YES")
            {
                DialogResult confirmarPedido = MessageBox.Show("OS PRODUTOS RECEBIDOS CONDIZEM EM ITES E QUANTIDADES COM OS PRODUTOS CADASTRADOS NO PEDIDO? " +
                "\n\n SE DESEJA ACEITAR O PEDIDO PRESSIONE SIM, " +
                "\n\n CASO TENHA ALGO DE ERRADO PRESSIONE NÃO", "MENSAGEM DE SEGURANÇA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirmarPedido.ToString().ToUpper() == "YES")
                {
                    ReceberPedido();
                    MessageBox.Show("PEDIDO RECEBIDO");
                }else if (confirmarPedido.ToString().ToUpper() == "NO")
                {
                    MessageBox.Show("PEDIDO NÃO RECEBIDO");
                }
            }
            else if(confirmar.ToString().ToUpper() == "NO")
            {
                MessageBox.Show("POR FAVOR VERIFIQUE SE OS PRODUTOS CONDIZEM COM OS PEDIDOS");
            }            
        }
    }
}
