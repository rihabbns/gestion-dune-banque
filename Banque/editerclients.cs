using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Banque
{
    public partial class editerclients : Form
    {
        public editerclients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = " Selectionner une photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxpic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        bool verif()
        {
            if ((textBoxnom.Text.Trim() == "") ||
                (textBoxprenom.Text.Trim() == "") ||
                (textBoxcin.Text.Trim() == "") ||
                (textBoxadr.Text.Trim() == "") ||
               (textBoxtel.Text.Trim() == "") ||
                (textBoxmail.Text.Trim() == "") ||
               (pictureBoxpic.Image == null))
            { return false; }
            else return true;
        }
        private void button4_Click(object sender, EventArgs e)
        { //editer un client
            try { 
            client client = new client();
            int id = Convert.ToInt32(textBoxid.Text);
            string cnom = textBoxnom.Text;
            string cprenom = textBoxprenom.Text;
            string cgenre = "Homme";
            if (radioButtonfemme.Checked)
            {
                cgenre = "Femme";
            }
            DateTime cdate = dateTimePicker1.Value;
            string ccin = textBoxcin.Text;
            string cadress = textBoxadr.Text;
            string ctel = textBoxtel.Text;
            string cmail = textBoxmail.Text;
            MemoryStream cpic = new MemoryStream();
            string cassurance = "sans motif";
            if (radioButton1.Checked)
            {
                cassurance = "avec motif";
            }


            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;


            if (((this_year - born_year) < 18) || (this_year - born_year) > 90)
            {
                MessageBox.Show("le client doit etre superieur a 18 et inférieur a 90", "date naissance est invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (((textBoxtel.Text.Length) != 8) && ((textBoxcin.Text.Length) != 8))
            {
                MessageBox.Show("longeur doit etre egale 8", "longeur invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {

                pictureBoxpic.Image.Save(cpic, pictureBoxpic.Image.RawFormat);
                if (client.modifierclient(id,cnom, cprenom, cgenre, cdate, ccin, cadress, ctel, cmail, cpic, cassurance))
                {
                    MessageBox.Show("un client est modifié", "Modifier client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur", "modifier client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("les boxes sont vides", "ajoutclient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show("pas de client selectionner pour le modifier", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
            {
                try
                {
                    client client = new client();
                    int id = Convert.ToInt32(textBoxid.Text);
                    MySqlCommand command = new MySqlCommand("SELECT `id`, `nom`, `prenom`, `genre`, `datenaiss`, `numcin`, `adresse`, `telephone`, `mail`, `picture`, `assurence` FROM `client` WHERE `id`=" + id);
                    DataTable table = client.listerclients(command);
                    if (table.Rows.Count > 0)
                    {
                        textBoxnom.Text = table.Rows[0]["nom"].ToString();
                        textBoxprenom.Text = table.Rows[0]["prenom"].ToString();
                        textBoxcin.Text = table.Rows[0]["numcin"].ToString();
                        textBoxadr.Text = table.Rows[0]["adresse"].ToString();
                        textBoxtel.Text = table.Rows[0]["telephone"].ToString();
                        textBoxmail.Text = table.Rows[0]["mail"].ToString();
                        dateTimePicker1.Value = (DateTime)table.Rows[0]["datenaiss"];
                    }
                    if (table.Rows[0]["genre"].ToString() == "Femme")
                    {
                        radioButtonfemme.Checked = true;
                    }
                    else
                    {
                        radioButtonhomme.Checked = true;

                    }
                    if (table.Rows[0]["assurence"].ToString() == "sans motif")
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton1.Checked = true;

                    }
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxpic.Image = Image.FromStream(picture);

                } catch (Exception ex) {
                    MessageBox.Show("entrer un id", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            







        }

        private void textBoxid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBoxpic_Click(object sender, EventArgs e)
        {

        }

        private void editerclients_Load(object sender, EventArgs e)
        {

        }
    }
}
