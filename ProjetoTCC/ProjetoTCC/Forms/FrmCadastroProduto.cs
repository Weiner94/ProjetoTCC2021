using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTCC.Forms
{
 
    public partial class frmCadastroProduto : Form
    {
        
        
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.dBTCCDataSet.Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dBTCCDataSet.Produto);

        }


        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.RemoveCurrent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {            
            try
            {
                this.Validate();
                this.produtoBindingSource.EndEdit();
                this.produtoTableAdapter.Update(this.dBTCCDataSet.Produto);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed" + ex);
            }
        }
    }
}
