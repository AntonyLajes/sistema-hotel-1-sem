using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoHotel.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader dr;

        public string txtSenha { get; private set; }

        public bool verificarLogin(String login, String senha)
        {
            //Comandos SQL para verificar se TEM no banco
            cmd.CommandText = "select login, senha from users where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (Exception Erro)
            {
                this.mensagem = "Erro com banco de dados!\n"+Erro.Message;
            }

            return tem;
        }

        public String cadastrar(String nome, String login, String senha, String confSenha)
        {
            tem = false;

            //Comandos para inserir no banco
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into users values (@n, @l, @s);";
                cmd.Parameters.AddWithValue("@n", nome);
                cmd.Parameters.AddWithValue("@l", login);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (Exception Error)
                {
                    this.mensagem = "Erro com Banco de dados"+Error.Message;
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem";
            }
            return mensagem;
            dr.Close();
        }
    }
}
