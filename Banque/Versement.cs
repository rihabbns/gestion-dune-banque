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
    public partial class Versement : Form
    {
        public Versement()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            db.openConnection();
            int idcl = int.Parse(txtNumeroCompte.Text);
            int idc = int.Parse(textBox1.Text);
            double montant = double.Parse(txtMontantVirement.Text);
            string update = "Update compte set solde=solde+'" + montant + "' where id_cl='" + idcl + "'";
            string select = "Select solde from compte where id_cl='" + idcl + "'";
            MySqlDataAdapter DA = new MySqlDataAdapter(select, db.getConnection);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            if (DS.Tables.Count > 0)
            {
                MessageBox.Show("Data found");
                dataGridView1.DataSource = DS.Tables[0];
                MySqlCommand cmd = new MySqlCommand(update, db.getConnection);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    dataGridView1.DataSource = DS.Tables[0];
                    label3.Text = "Apres retrait:";

                }
            }
            else
            {
                MessageBox.Show("Data not found");
            }

        }
    }
}
   
