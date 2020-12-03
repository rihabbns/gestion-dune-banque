using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Banque
{
    class MY_DB
    {
      
      private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=banque;Convert Zero Datetime=True");
    public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
