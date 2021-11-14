using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCC.Connector
{
    public class Conector
    {

        SqlConnection con = new SqlConnection();
        public Conector()
        {
            con.ConnectionString = @"Data Source=DESKTOP-WEINER\SQLEXPRESS;Initial Catalog=DBTCC;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            con.Close();
        }

        public void StringConexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-WEINER\SQLEXPRESS;Initial Catalog=DBTCC;Integrated Security=True";
        }


    }
}
