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
    public partial class Virements : Form
    {
        public Virements()
        {
            InitializeComponent();
        }

        private void gpbCreationVirement_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumeroCompte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMontantVirement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDestinataire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            db.openConnection();
            int idcl = int.Parse(txtNumeroCompte.Text);
            int idc = int.Parse(textBox1.Text);
            double montant = double.Parse(txtMontantVirement.Text);
            int idc2 = int.Parse(txtDestinataire.Text);
            string date = dtpDateEmission.Value.ToString("yyyy-mm-dd");
            
            string insertquery = "INSERT INTO CAISSE values('" + date + "','" + "Virement" + "','" + montant + "','" + idc + "','" + idcl + "')";
            MySqlCommand cmd = new MySqlCommand(insertquery, db.getConnection);
            try
            {

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from caisse ", db.getConnection);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    dataGridView1.DataSource = DS.Tables[0];
                    MessageBox.Show("Mouvement ajoute avec succes");
                }
                else { MessageBox.Show("Mouvement pas ajoute"); }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            
            string update1 = "Update compte set solde=solde-'" + montant + "' where id_compte='"+idc+"'";
            MySqlCommand cmd3 = new MySqlCommand(update1, db.getConnection);
            if(cmd3.ExecuteNonQuery()==1)
            {

                MessageBox.Show("Update du solde du compte initial effectue");
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from compte where id_compte='" + idc + "'", db.getConnection);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView2.DataSource = DS.Tables[0];
            }
            string update2 = "Update compte set solde=solde+'" + montant + "' where id_compte='" + idc2 + "'";
            MySqlCommand cmd4 = new MySqlCommand(update2, db.getConnection);
            if (cmd4.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Update du solde du compte destinataire effectue");
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from compte where id_compte='" + idc2 + "'", db.getConnection);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView3.DataSource = DS.Tables[0];
            }


        }

        private void dtpDateEmission_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
