using ProjetoTCC.Connector;
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

namespace ProjetoTCC.Forms
{
    public partial class FrmInicioComprarProdutos : Form
    {
        //private Form objForm;
        public FrmInicioComprarProdutos()
        {
            InitializeComponent();
        }

        private void FrmInicioComprarProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Pedido_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pedido_ProdutoTableAdapter.Fill(this.dBTCCDataSet.Pedido_Produto);

        }

        private void DataGridViewRPP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void DataGridViewPP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Conector con = new Conector();
            try
            {
                con.Conectar(); // Abre a conexão com banco de dados
                cmd.CommandText = @"select rpp.IdRelacaoPP, p.nome, p.preco_compra, rpp.quantidade from dbo.Produto as p
                                    inner join dbo.Relacao_Pedido_Produto as rpp
                                    on rpp.fk_idPedidoProduto = @fk_idPedidoProduto and rpp.fk_idProduto = p.IdProduto;";
               
                cmd.Connection = con.Conectar();
                cmd.Parameters.AddWithValue("@fk_idPedidoProduto", int.Parse(CodPedido.Text));
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

        private void BtnNovoPedido_Click(object sender, EventArgs e)
        {
            frmTelaInicial TLInicial = new frmTelaInicial();
            //TLInicial.ControladorTela();
            //objForm?.Close();
            /*objForm = new frmComprarProdutos
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            TLInicial.pnlMain.Controls.Add(objForm);
            objForm.Show();*/

        }
    }
}
