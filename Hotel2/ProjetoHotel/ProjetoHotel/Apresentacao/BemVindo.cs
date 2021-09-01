using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoHotel.Apresentacao
{
    public partial class BemVindo : Form
    {

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        String strSQL;
        public BemVindo()
        {
            InitializeComponent();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarCliente cadCliente = new cadastrarCliente();
            cadCliente.ShowDialog();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreOProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa criado para fins de aprendizado. \n Aluno: Antony Mateus Coelho Lajes \n Professor: Aldriano Silva");
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editarCliente editCliente = new editarCliente();
            editCliente.ShowDialog();
        }

        private void excluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excluirCliente excCliente = new excluirCliente();
            excCliente.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarCliente cnstrCliente = new consultarCliente();
            cnstrCliente.ShowDialog();
        }

        private void exibirClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(@"server=localhost;uid=root;database=unip; Port = 3306");

                strSQL = "select * from clientes";

                da = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDados.DataSource = dt;

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro com Banco de dados // Cliente não encontrado" + Erro.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
