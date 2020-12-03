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
    public partial class EditerComptes : Form
    {
        public EditerComptes()
        {
            InitializeComponent();
        }

        private void EditerComptes_Load(object sender, EventArgs e)
        {

        }
        private void recherche()
        {

            MY_DB db = new MY_DB();
            int idcl = int.Parse(textBoxid.Text);

            string searchquery = "SELECT COUNT(*) from compte where id_cl='" + idcl + "'";
            MySqlCommand cmd = new MySqlCommand(searchquery, db.getConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 0)
            {
                MessageBox.Show("Pas de comptes!",
                     "window title",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Compte trouve!",
                     "window title",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from compte where id_cl='" + idcl + "'", db.getConnection);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            recherche();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void afficher()
        {
            MY_DB connection = new MY_DB();

            connection.openConnection();
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from compte", connection.getConnection);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
                connection.closeConnection();

            
        }
        private void modifier()
        {
            MY_DB db = new MY_DB();
            int idcl = int.Parse(textBoxid.Text);
            int interet = int.Parse(textBox2.Text);
            string type = comboBox1.SelectedItem.ToString();
            string updatequery = "UPDATE compte set type_cc='" + type + "',interet='" + interet + "' where id_compte='" + idcl + "'";
            MySqlCommand command = new MySqlCommand(updatequery, db.getConnection);
            db.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Updated");
                    MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from compte where id_compte='" + idcl + "'", db.getConnection);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    dataGridView1.DataSource = DS.Tables[0];

                }
                else { MessageBox.Show("Data not Updated"); }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.closeConnection();
        }
        private void button1_Click(object sender, EventArgs e)

        {

            modifier();

            
        }
    }
}


