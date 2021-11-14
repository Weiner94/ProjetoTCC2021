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
using ProjetoTCC.Controlers;

namespace ProjetoTCC
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Thread nt;

        public Login()
        {
            InitializeComponent();
        }      

        private void IrTelaInicial()
        {
            Application.Run(new frmTelaInicial());
        }       

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.verificarLogin(textBoxUser.Text, textBoxPassword.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.verificador)
                {
                    this.Close();
                    nt = new Thread(IrTelaInicial);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                    MessageBox.Show("Logado");
                }
                else
                {
                    MessageBox.Show("Login não encontrado");
                }
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
