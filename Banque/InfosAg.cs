using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banque
{
    public partial class InfosAg : Form
    {
        public InfosAg()
        {
            InitializeComponent();
        }

        private void InfosAg_Load(object sender, EventArgs e)
        {
            MY_DB connection = new MY_DB();

            connection.openConnection();
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from agence", connection.getConnection);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
                connection.closeConnection();

            
        }
    }
}
