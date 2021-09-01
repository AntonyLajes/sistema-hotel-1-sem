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
    public partial class editarCliente : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        String strSQL;
        public editarCliente()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(@"server=localhost;uid=root;database=unip; Port = 3306");

                strSQL = "update clientes SET nome = @nome, numero = @numero where nome = @nome;";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@numero", txtNumero.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Editado com sucesso!");

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
            Close();
        }
    }
}
