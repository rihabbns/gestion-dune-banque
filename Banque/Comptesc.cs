using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class Comptesc
    {
        //fonction qui permet d'ajouter un nouveau compte 
        MY_DB db = new MY_DB();
        public bool ajouterccompte(int cid, string ctype, double csolde)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `compte`(`id_cl`, `type_cc`, `solde`) VALUES (@cid,@ctype,@csolde)", db.getConnection);

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = cid;
           
            command.Parameters.Add("@ctype", MySqlDbType.VarChar).Value = ctype;
            command.Parameters.Add("@csolde", MySqlDbType.Double).Value = csolde;


            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;

            }


        }
        //table clients
        public DataTable listercomptes(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool modifiercompte(int cid, string ctype, double csolde)
        {
            MySqlCommand command = new MySqlCommand(" UPDATE `compte` SET `type_cc`=@ctype,`solde`=@csolde WHERE `id_compte`=@ID", db.getConnection);
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = cid;
            command.Parameters.Add("@ctype", MySqlDbType.VarChar).Value = ctype;
            command.Parameters.Add("@csolde", MySqlDbType.Double).Value = csolde;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;

            }

        }

     
    }
}
