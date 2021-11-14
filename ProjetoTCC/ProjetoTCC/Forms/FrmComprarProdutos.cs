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
using MySql.Data.MySqlClient;
using ProjetoTCC.Forms;

namespace ProjetoTCC.Forms
{
    public partial class frmComprarProdutos : Form
    {
        int IdPedidoCorrente = 0;
        int CodigoQuant = 0;
        int CodigoId = 0;
        private Form objForm;
        //String Nome = null;
        //DAOConnector DAO = new DAOConnector();

        SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;
        Conector con = new Conector();
        DAOConnector DAO = new DAOConnector();
        public frmComprarProdutos()
        {
            InitializeComponent();
        }

        private void frmComprarProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Relacao_Pedido_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.relacao_Pedido_ProdutoTableAdapter.Fill(this.dBTCCDataSet.Relacao_Pedido_Produto);

            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.dBTCCDataSet.Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dBTCCDataSet.Produto);

           


        }

        private void CbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {            
            DAOConnector CodForn = new DAOConnector();
            TxbIdFornecededor.Text = CodForn.CodFornecedor(CbFornecedor.Text);
        }

        private void TxbIdFornecededor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.produtoTableAdapter.FillByIdFornecedor(this.dBTCCDataSet.Produto, Int32.Parse(TxbIdFornecededor.Text));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }       

        public void PreencherProdutosPedido()
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Conector con = new Conector();
            //CodPedido.Text 
            try
            {
                con.Conectar(); // Abre a conexão com banco de dados
                cmd.CommandText = @"select rpp.IdRelacaoPP, p.nome, p.preco_compra, rpp.quantidade from dbo.Produto as p
                                    inner join dbo.Relacao_Pedido_Produto as rpp
                                    on rpp.fk_idPedidoProduto = @IdPedidoCorrente and rpp.fk_idProduto = p.IdProduto;";
                
                cmd.Connection = con.Conectar();
                cmd.Parameters.AddWithValue("@IdPedidoCorrente", IdPedidoCorrente);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dataGridViewRPP.DataSource = dt; //Preenche o DataGridView
                }
                dr.Close();
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

        private void CodPedido_TextChanged(object sender, EventArgs e)
        {
            PreencherProdutosPedido();            
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(CodPedido.Text)))
            {
                if (!(string.IsNullOrEmpty(txbProduto.Text) || String.IsNullOrEmpty(TxbIdFornecededor.Text)))
                {
                    int produto = DAO.IdProdutoCorrente(txbProduto.Text, Int32.Parse(TxbIdFornecededor.Text));
                    DAO.CadastrarPedidoDAO(Int32.Parse(CodPedido.Text), produto, Int32.Parse(txbQuantidadeProduto.Text), float.Parse(TxbTotalProduto.Text));
                    PreencherProdutosPedido();
                }
                else
                {
                    MessageBox.Show("POR FAVOR SELECIONE UM FORNECEDOR ANTES DE ADICIONAR O PRODUTO A LISTA DE PEDIDO");
                }
            }
            else
            {
                MessageBox.Show("POR FAVOR ANTES DE ADICIONAR UM PRODUTO A LISTA, INICIE UM NOVO PEDIDO CLICANDO EM:    NOVO PEDIDO    ");
            }
            



        }


        float totalProduto = 0;
       //private object int32;

        private float SomaTotal(int quant, float preco)
        {
            //totalProduto = Int32.Parse(txbQuantidadeProduto.Text) * Int32.Parse(txbPreco.Text);
            if (quant >= 0)
            {
                totalProduto = quant * preco;
            }
            return totalProduto;
        }
        private void TxbQuantidadeProduto_TextChanged(object sender, EventArgs e)
        {
            int aux;
            if (String.IsNullOrEmpty(txbQuantidadeProduto.Text))
            {
                aux = 0;
                float preco;
                float.TryParse(txbPreco.Text, out preco);
                float total = (SomaTotal(aux, preco));
                TxbTotalProduto.Text = total.ToString();

            }
            else if(!(String.IsNullOrEmpty(txbQuantidadeProduto.Text)))
            {
                aux = Int32.Parse(txbQuantidadeProduto.Text);
                TxbTotalProduto.Text = (SomaTotal(aux, float.Parse(txbPreco.Text))).ToString();
            }
        }

        private void BtnNovoPedido_Click(object sender, EventArgs e)
        {            
            IdPedidoCorrente = DAO.CodPedido_Corrente();
            CodPedido.Text = (DAO.CodPedido_Corrente()).ToString();
            Console.WriteLine("NUMERO DE PEDIDO ----------->  " + IdPedidoCorrente.ToString());            
            if (DAO.ProcuraRelacaoPP(IdPedidoCorrente) == true)
            {
                string estado = "aguardando";                
                int forn; 
                int.TryParse(TxbIdFornecededor.Text, out forn);
                MessageBox.Show(forn.ToString());
                DAO.CadastroPedido(estado, DateTime.Now, 1, forn);
                
                IdPedidoCorrente = DAO.CodPedido_Corrente();
                CodPedido.Text = (DAO.CodPedido_Corrente()).ToString();

                frmTelaInicial Inicio = new frmTelaInicial();
                Inicio.ControladorTela();
                
                PreencherProdutosPedido();
            }
            else if (DAO.ProcuraRelacaoPP(IdPedidoCorrente) == false)
            {
                MessageBox.Show("IMPOSSIVEL COMPLETAR O PEDIDO: \n ADICIONE PRODUTOS À LISTA DO PEDIDO ");
            }
            
                


        }

        private void dataGridViewRPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoQuant = int.Parse(dataGridViewRPP.Rows[e.RowIndex].Cells["quantidade"].Value.ToString());
            CodigoId = int.Parse(dataGridViewRPP.Rows[e.RowIndex].Cells["IdRelacaoPP"].Value.ToString());
            
        }

        private void DeletarProdutoPedido(int IdRelacaoPP, int quantidade)
        {


            //CodPedido.Text 
            try
            {
                con.Conectar(); // Abre a conexão com banco de dados
                cmd.CommandText = "delete from dbo.Relacao_Pedido_Produto where IdRelacaoPP = @IdRelacaoPP";               
                cmd.Connection = con.Conectar();
                cmd.Parameters.Add("@IdRelacaoPP", SqlDbType.Int).Value = IdRelacaoPP;
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.ExecuteNonQuery();
                /*dr = cmd.ExecuteReader();

                // Cria uma tabela genérica
                DataTable dt = new DataTable();
                dt.Load(dr); // Carrega os dados para o DataTable
                dataGridViewRPP.DataSource = dt; //Preenche o DataGridView
                */

            }
            catch (SqlException)
            {
                MessageBox.Show("ERRO COM O BANCO DE DADOS");

            }

            con.Desconectar();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CodigoQuant.ToString(), CodigoId.ToString());
            DeletarProdutoPedido(CodigoId, CodigoQuant);
        }

        private void BtnFinalizarPedido_Click(object sender, EventArgs e)
        {



            dataGridView1.Visible = false;
            label2.Visible = false;
            txbProduto.Visible = false;
            label3.Visible = false;
            txbPreco.Visible = false;
            label4.Visible = false;
            txbQuantidadeProduto.Visible = false;
            label5.Visible = false;
            TxbTotalProduto.Visible = false;
            label6.Visible = false;
            TxbTotalVenda.Visible = false;
            dataGridViewRPP.Visible = false;
            PnlProdutos.Visible = false;
            PnlProdutosPedidos.Visible = false;
            PnlNemuPP.Visible = false;
            frmTelaInicial TL = new frmTelaInicial();
            objForm?.Close();
            objForm = new FrmInicioComprarProdutos
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            PnlCompProduto.Controls.Add(objForm);
            objForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IdPedidoCorrente = DAO.CodPedido_Corrente();
            IdPedidoCorrente = int.Parse(CodPedido.Text);
            //CodPedido.Text = (DAO.CodPedido_Corrente()).ToString();
            MessageBox.Show(DAO.CodPedido_Corrente().ToString());
            PreencherProdutosPedido();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int var = int.Parse(CodPedido.Text);
            //bool verificar = DAO.ProcuraRelacaoPP(int.Parse(CodPedido.Text));
            if (!(String.IsNullOrEmpty(CodPedido.Text)))
            {
                if (DAO.ProcuraRelacaoPP(int.Parse(CodPedido.Text)) == true)
                {
                    MessageBox.Show("TEM");
                }
                else if (DAO.ProcuraRelacaoPP(int.Parse(CodPedido.Text)) == false)
                {
                    MessageBox.Show("NÃO");
                }
            }
            else
            {
                MessageBox.Show("!ERRO - REFERENCIA REQUERIDA:  CÓDIGO DO PEDIDO");
            }

        }

        private void BtnCancelarPedido_Click(object sender, EventArgs e)
        {

        }

        private void fillByIdFornecedorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.produtoTableAdapter.FillByIdFornecedor(this.dBTCCDataSet.Produto, new System.Nullable<int>(((int)(System.Convert.ChangeType(txbIdFornecededorToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
