using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ProjetoTCC.Forms;

namespace ProjetoTCC
{
    public partial class frmTelaInicial : Form
    {
        //Thread nt;
        public Form objForm;
        public frmTelaInicial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        } 

        private void BtnMsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void BtnMsCaixa_Click(object sender, EventArgs e)
        {
            
            objForm?.Close();
            objForm = new frmRegVendas
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Add(objForm);
            objForm.Show();
            
        }


        private void frmTelaInicial_SizaChanged(object sender, EventArgs e)
        {

        }



        private void BtnMsCadastrarUsuario_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmCadastroUsuario
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Add(objForm);
            objForm.Show();
        }


        private void BtnMsGerenciarProduto_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmCadastroProduto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Add(objForm);
            objForm.Show();


        }

        public void ControladorTela()
        {
            objForm?.Close();
            objForm = new frmComprarProdutos
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Add(objForm);
            objForm.Show();
        }

        private void BtnMsComprarProdutos_Click(object sender, EventArgs e)
        {
            ControladorTela();  
        }

        

        private void BtnMsPrevisaoDemanda_Click(object sender, EventArgs e)
        {

            objForm?.Close();
            objForm = new FrmTelaDemanda
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Add(objForm);
            objForm.Show();
        }

        private void BtnMsVerificarProdutos_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmVerificarProduto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Add(objForm);
            objForm.Show();
        }

        private void BtnMsCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new frmCadastroFornecedor
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Add(objForm);
            objForm.Show();

        }

        private void BtnMsReceberlote_Click(object sender, EventArgs e)
        {
            objForm?.Close();
            objForm = new FrmReceberPedido
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Add(objForm);
            objForm.Show();
        }
    

       

        public void IrTelaUltimosPedidos()
        {
            objForm?.Close();
            objForm = new FrmInicioComprarProdutos
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlMain.Controls.Add(objForm);
            objForm.Show();
        }
    }
}
