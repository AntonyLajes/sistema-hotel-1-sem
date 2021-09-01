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
    public partial class cadastrarCliente : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        String strSQL;
        public cadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(@"server=localhost;uid=root;database=unip; Port = 3306");
                
                strSQL = "insert into clientes VALUES (@nome, @numero);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@numero", txtNumero.Text);
                
                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!");

            }
            catch(Exception Erro)
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
