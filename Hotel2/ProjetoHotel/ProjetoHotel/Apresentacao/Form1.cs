using MySql.Data.MySqlClient;
using ProjetoHotel.Apresentacao;
using ProjetoHotel.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHotel
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bv = new BemVindo();
                    bv.Show();

                    Hide();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
            
        }
    }
}
