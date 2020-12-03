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
    public partial class ajoutclient : Form
    {
        public ajoutclient()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //téléchargement d'une image 
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = " Selectionner une photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(opf.ShowDialog()== DialogResult.OK)
            {
                pictureBoxpic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ajout d'un client
            client client= new client();
            string cnom = textBoxnom.Text;
            string cprenom = textBoxprenom.Text;
            string cgenre = "Homme";
            if(radioButtonfemme.Checked){
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
                cassurance= "avec motif";
            }

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;


            if(((this_year - born_year) < 18) || (this_year - born_year) > 90)
            {
                MessageBox.Show("le client doit etre superieur a 18 et inférieur a 90", "date naissance est invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (((textBoxtel.Text.Length) != 8) && ((textBoxcin.Text.Length) != 8)){
                MessageBox.Show("longeur doit etre egale 8", "longeur invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
               
               pictureBoxpic.Image.Save(cpic, pictureBoxpic.Image.RawFormat);
                if(client.ajouterclient(cnom,cprenom,cgenre,cdate,ccin,cadress,ctel,cmail,cpic,cassurance))
                    {
                    MessageBox.Show("un nouveau client est ajoutee", "ajoutclient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur", "ajoutclient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
            else
            {
                MessageBox.Show("les boxes sont vides", "ajoutclient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //fonction qui verfie les données
        bool verif()
        {
            if ((textBoxnom.Text.Trim() == "") ||
                (textBoxprenom.Text.Trim() == "") ||
                (textBoxcin.Text.Trim() == "") ||
                (textBoxadr.Text.Trim() == "") ||
               ( textBoxtel.Text.Trim() == "") ||
                (textBoxmail.Text.Trim() == "") ||
               (pictureBoxpic.Image == null))
            { return false; }
            else return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //annuler l'ajout d'un client
            Close();
        }

        private void textBoxnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxprenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxcin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxadr_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ajoutclient_Load(object sender, EventArgs e)
        {

        }
    }
}
