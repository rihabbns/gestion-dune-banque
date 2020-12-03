using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class acteur
    {
        MY_DB db = new MY_DB();
        public DataTable listeracteur(MySqlCommand commanda)
        {
            commanda.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(commanda);
            DataTable tablea = new DataTable();
            adapter.Fill(tablea);
            return tablea;
        }
    }
}
