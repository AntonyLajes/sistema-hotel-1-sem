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
    public partial class excluirCliente : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        String strSQL;
        public excluirCliente()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(@"server=localhost;uid=root;database=unip; Port = 3306");

                strSQL = "delete from users where nome = @nome";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Excluido com sucesso!");

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro com Banco de dados" + Erro.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            Close();
        }
    }
}
