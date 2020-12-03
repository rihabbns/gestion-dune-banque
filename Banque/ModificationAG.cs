using MySql.Data.MySqlClient;
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

namespace Banque
{
    public partial class ModificationAG : Form
    {
        public ModificationAG()
        {
            InitializeComponent();
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
        private void buttonediter_Click(object sender, EventArgs e)
        {



            try
            {
                agent agent = new agent();
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
                
                


                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;


                if (((this_year - born_year) < 25) || (this_year - born_year) > 90)
                {
                    MessageBox.Show("l'agent doit etre superieur a 25et inférieur a 90", "date naissance est invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (((textBoxtel.Text.Length) != 8) && ((textBoxcin.Text.Length) != 8))
                {
                    MessageBox.Show("longeur doit etre egale 8", "longeur invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {

                    pictureBoxpic.Image.Save(cpic, pictureBoxpic.Image.RawFormat);
                    if (agent.modifieragent(id, cnom, cprenom, cgenre, cdate, ccin, cadress, ctel, cmail, cpic))
                    {
                        MessageBox.Show("l'agent est modifié", "Modifier agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur", "modifier agent", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("les boxes sont vides", "ajoutagent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("pas d'agent selectionner pour le modifier", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                agent agent = new agent();
                int id = Convert.ToInt32(textBoxid.Text);
                MySqlCommand command = new MySqlCommand("SELECT `id`, `nom`, `prenom`, `genre`, `datenaiss`, `numcin`, `adresse`, `telephone`, `mail`, `picture` FROM `agent` WHERE `id`=" + id);
                DataTable table = agent.listerclients(command);
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
                
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxpic.Image = Image.FromStream(picture);

            }
            catch (Exception ex)
            {
                MessageBox.Show("entrer un id", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
