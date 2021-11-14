using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTCC.Forms
{
    public partial class frmCadastroFornecedor : Form
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.dBTCCDataSet.Fornecedor);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.fornecedorBindingSource.EndEdit();
                this.fornecedorTableAdapter.Update(this.dBTCCDataSet.Fornecedor);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed" + ex);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.fornecedorBindingSource.AddNew();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.RemoveCurrent();
        }
    }
}
