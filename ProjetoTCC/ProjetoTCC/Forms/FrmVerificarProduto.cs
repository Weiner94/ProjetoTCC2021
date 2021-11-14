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
    public partial class frmVerificarProduto : Form
    {
        Conector con = new Conector();
        SqlCommand cmd = new SqlCommand();
        DataTable dt;
        public frmVerificarProduto()
        {
            InitializeComponent();

        }

        private void frmVerificarProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dBTCCDataSet.Produto);
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dBTCCDataSet.Produto);
            cmd.Connection = con.Conectar();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("select *  from dbo.Produto", cmd.Connection))
                {
                    dt = new System.Data.DataTable("dbo.Produto");
                    da.Fill(dt);
                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("nome like '%{0}%'", txtNomeProduto.Text);
                dataGridView.DataSource = dv.ToTable();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("nome like '%{0}%'", txtNomeProduto.Text);
            dataGridView.DataSource = dv.ToTable();

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("nome like '%{0}%'", txtNomeProduto.Text);
            dataGridView.DataSource = dv.ToTable();
        }
    }
}
