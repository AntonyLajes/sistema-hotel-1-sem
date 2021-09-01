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
    public partial class consultarCliente : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        String strSQL;
        public consultarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(@"server=localhost;uid=root;database=unip; Port = 3306");

                strSQL = "select * from clientes where nome = @nome;";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                dr.Read();

                txtNumero.Text = dr.GetString(1);

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
