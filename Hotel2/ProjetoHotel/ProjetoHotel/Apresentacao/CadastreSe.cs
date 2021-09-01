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

namespace ProjetoHotel.Apresentacao
{
    public partial class CadastreSe : Form
    {
        private object loginDao;
        private bool loginDaoComando;

        public CadastreSe()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtNome.Text, txtLogin.Text, txtSenha.Text, txtConfirmarSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
