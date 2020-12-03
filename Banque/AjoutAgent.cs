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
    public partial class AjoutAgent : Form
    {
        public AjoutAgent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //téléchargement d'une image 
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = " Selectionner une photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxpic.Image = Image.FromFile(opf.FileName);
            }
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
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            agent agent = new agent();
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
                MessageBox.Show("l'agent doit etre superieur a 25 et inférieur a 90", "date naissance est invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (((textBoxtel.Text.Length) != 8) && ((textBoxcin.Text.Length) != 8))
            {
                MessageBox.Show("longeur doit etre egale 8", "longeur invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {

                pictureBoxpic.Image.Save(cpic, pictureBoxpic.Image.RawFormat);
                if (agent.ajouteragent(cnom, cprenom, cgenre, cdate, ccin, cadress, ctel, cmail, cpic))
                {
                    MessageBox.Show("un nouveau agent est ajoutee", "ajoutagent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur", "ajoutagent", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("les boxes sont vides", "ajoutagent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();        }
    }
}
