using ProjetoTCC.Connector;
using ProjetoTCC.Controlers;
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
    public partial class frmRegVendas : Form
    {
        DAOConnector DAO = new DAOConnector();
        

        public frmRegVendas()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

        }

        private void FrmRegVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.dBTCCDataSet.Venda);
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.dBTCCDataSet.Venda);

            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dBTCCDataSet.Produto);


            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dBTCCDataSet.Produto);
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dBTCCDataSet.Produto);

            int a = (DAO.CodVenda_Corrente());           
            TxbIdVenda.Text = a.ToString();   
        }
        

        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("DESEJA INCLUIR NOVA VENDA?", "ADICIONAR OU FINALIZAR VENDA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirmar.ToString().ToUpper() == "YES")
            {                
                TxbIdVenda.Text = DAO.CodVenda_Corrente().ToString();
            }
            else if (confirmar.ToString().ToUpper() == "NO")
            {
                this.Close();
                MessageBox.Show("VENDA FINALIZADA");
            }
        }

        private void BtnFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vendaBindingSource.EndEdit();
                this.vendaTableAdapter.Update(this.dBTCCDataSet.Venda);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed" + ex);
            }
        }

        private void BtnAdicionarItem_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex num = new System.Text.RegularExpressions.Regex("[^0-9]");
            if (!(num.IsMatch(this.TxbQuantidade.Text)))
            {
                if (String.IsNullOrEmpty(TxbQuantidade.Text) || String.IsNullOrEmpty(TxbProduto.Text))
                {
                    MessageBox.Show("POR FAVOR SEKECIONE UM PRODUTO DA LINSTA A ESQUERDA, E SUA DETERMINADA QUANDIDADE PARA A VENDA !");
                }
                else
                {
                    DAO.cadastrarVendaDAO(TxbProduto.Text, float.Parse(TxbQuantidade.Text), float.Parse(TxbPrecoTotal.Text), float.Parse(TxbUnidadeKg.Text), 2 /**/, Int32.Parse(TxbIdVenda.Text));
                    string connectionString = @"Data Source=DESKTOP-WEINER\SQLEXPRESS;Initial Catalog=DBTCC;Integrated Security=True";
                    SqlDataAdapter da = new SqlDataAdapter("SELECT IdVenda, produto, quantidade, total, data_venda, valor_un_g, fk_venda_usuario, cod_venda FROM dbo.Venda", connectionString);
                    try
                    {
                        this.vendaTableAdapter.FillBy1(this.dBTCCDataSet.Venda, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxbIdVenda.Text, typeof(int))))));                        
                        TxbTotalVenda.Text = dataGridView3.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[3].Value ?? 0)).ToString("##.00");
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("     DADO INCORRETO EM CAMPO: QUANTIDADE     \n      ESTE CAMPO ACEITA SOMENTE NUMEROS!");
            }

        }


        private void BtnRemoverItem_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.RemoveCurrent();
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.vendaTableAdapter.Update(this.dBTCCDataSet.Venda);
            TxbTotalVenda.Text = dataGridView3.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[3].Value ?? 0)).ToString("##.00");

        }


        private void TxbIdVenda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.vendaTableAdapter.FillBy1(this.dBTCCDataSet.Venda, new System.Nullable<int>(((int)(System.Convert.ChangeType(TxbIdVenda.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TxbQuantidade_TextChanged(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex num = new System.Text.RegularExpressions.Regex("[^0-9]");
            if (!(num.IsMatch(this.TxbQuantidade.Text)))
            {
                if (!(String.IsNullOrEmpty(TxbQuantidade.Text)))
                {
                    if (!(String.IsNullOrEmpty(TxbPreco.Text) && String.IsNullOrEmpty(TxbQuantidade.Text)))
                    {
                        TxbPrecoTotal.Text = Convert.ToString(float.Parse(TxbPreco.Text) * float.Parse(TxbQuantidade.Text));
                    }
                }
            }
            else
            {
                MessageBox.Show("     DADO INCORRETO EM CAMPO: QUANTIDADE     \n      ESTE CAMPO ACEITA SOMENTE NUMEROS!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxbQuantidade.Text = null;
            TxbPrecoTotal.Text = null;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DAO.CancelarVenda(Int32.Parse(TxbIdVenda.Text));
            this.Close(); 
        }
    }
}
