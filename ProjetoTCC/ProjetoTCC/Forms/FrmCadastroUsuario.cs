using ProjetoTCC.Controlers;
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
    public partial class frmCadastroUsuario : Form
    {
        Controle cont = new Controle();
        public frmCadastroUsuario()
        {
            InitializeComponent();
            txbSenha.MaxLength = 4;
            txbConfSenha.MaxLength = 4;
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBTCCDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.dBTCCDataSet.Usuario);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btbCadastra_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txbNome.Text) || String.IsNullOrEmpty(txbSenha.Text) || String.IsNullOrEmpty(txbConfSenha.Text))
            {
                MessageBox.Show("POR FAVOR PREENCHA OS CAMPOS OBRIGATÓRIOS PARA O CADASRTO DE USUÁRIO");
            }
            else
            {
                if(txbSenha.Text == txbConfSenha.Text)
                {
                    String mensagem = cont.CadastrarUsuario(txbNome.Text, txbSenha.Text, txbConfSenha.Text);
                    if (cont.verificador)
                    {
                        MessageBox.Show(mensagem, "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Validate();
                        this.usuarioBindingSource.EndEdit();
                        this.usuarioTableAdapter.Update(this.dBTCCDataSet.Usuario);
                        this.usuarioTableAdapter.Fill(this.dBTCCDataSet.Usuario);
                    }
                    else
                    {
                        MessageBox.Show(cont.mensagem);

                    }
                }
                else
                {
                    MessageBox.Show("CAMPOS SENHA E CONFIRMAR SENHA DEVEM SEM IGUAIS!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("DESEJA EXCLUIR O USUÁRIO SELECIONADO?", "EXCLUIR CADASTRO DE USUÁRIO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirmar.ToString().ToUpper() == "YES")
            {
                this.usuarioBindingSource.RemoveCurrent();
                this.Validate();
                this.usuarioBindingSource.EndEdit();
                this.usuarioTableAdapter.Update(this.dBTCCDataSet.Usuario);
                this.usuarioTableAdapter.Fill(this.dBTCCDataSet.Usuario);
            }
            else if (confirmar.ToString().ToUpper() == "NO")
            {

            }
                
        }
    }
}
