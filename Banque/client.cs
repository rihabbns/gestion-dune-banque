using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class client
    {
        //fonction qui permet d'ajouter un nouveau client 
        MY_DB db = new MY_DB();
        public bool ajouterclient(string cnom, string cprenom, string cgenre, DateTime cdate, string ccin, string cadress, string ctel, string cmail, MemoryStream cpic, string cassurance)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `client`(`nom`, `prenom`, `genre`, `datenaiss`, `numcin`, `adresse`, `telephone`, `mail`, `picture`, `assurence`) VALUES (@cn,@cp,@cg,@cdn,@cc,@cad,@ctel,@cm,@cpic,@cass)", db.getConnection);

            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cnom;
            command.Parameters.Add("@cp", MySqlDbType.VarChar).Value = cprenom;
            command.Parameters.Add("@cg", MySqlDbType.VarChar).Value = cgenre;
            command.Parameters.Add("@cdn", MySqlDbType.Date).Value = cdate;
            command.Parameters.Add("@cc", MySqlDbType.VarChar).Value = ccin;
            command.Parameters.Add("@cad", MySqlDbType.Text).Value = cadress;
            command.Parameters.Add("@ctel", MySqlDbType.VarChar).Value = ctel;
            command.Parameters.Add("@cm", MySqlDbType.VarChar).Value = cmail;
            command.Parameters.Add("@cpic", MySqlDbType.Blob).Value = cpic.ToArray();
            command.Parameters.Add("@cass", MySqlDbType.VarChar).Value = cassurance;
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
        public DataTable listerclients(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
     
        public bool modifierclient(int id,string cnom, string cprenom, string cgenre, DateTime cdate, string ccin, string cadress, string ctel, string cmail, MemoryStream cpic, string cassurance)
          {
            MySqlCommand command = new MySqlCommand(" UPDATE `client` SET `nom`=@cn,`prenom`=@cp,`genre`=@cg,`datenaiss`=@cdn,`numcin`=@cc,`adresse`= @cad,`telephone`=@ctel,`mail`=@cm,`picture`=@cpic,`assurence`=@cass WHERE `id`=@ID", db.getConnection);
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cnom;
            command.Parameters.Add("@cp", MySqlDbType.VarChar).Value = cprenom;
            command.Parameters.Add("@cg", MySqlDbType.VarChar).Value = cgenre;
            command.Parameters.Add("@cdn", MySqlDbType.Date).Value = cdate;
            command.Parameters.Add("@cc", MySqlDbType.VarChar).Value = ccin;
            command.Parameters.Add("@cad", MySqlDbType.Text).Value = cadress;
            command.Parameters.Add("@ctel", MySqlDbType.VarChar).Value = ctel;
            command.Parameters.Add("@cm", MySqlDbType.VarChar).Value = cmail;
            command.Parameters.Add("@cpic", MySqlDbType.Blob).Value = cpic.ToArray();
            command.Parameters.Add("@cass", MySqlDbType.VarChar).Value = cassurance;
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

        internal bool modifierclient(object id, string cnom, string cprenom, string cgenre, DateTime cdate, string ccin, string cadress, string ctel, string cmail, MemoryStream cpic, string cassurance)
        {
            throw new NotImplementedException();
        }
    }
}
