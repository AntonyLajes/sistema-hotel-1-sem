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
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"server=localhost;uid=root;database=unip; Port = 3306";
        }

        public MySqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
