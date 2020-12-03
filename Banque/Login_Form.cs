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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../pics/pic.png");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MY_DB db = new MY_DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            
            

                MySqlCommand command = new MySqlCommand("SELECT * FROM `acteur` WHERE `username`= @usn AND `password`=@pass", db.getConnection);
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                int userid = Convert.ToInt32(table.Rows[0][0].ToString());
                actG.mettreidglobale(userid);





                this.Hide();
                    MainForm MA = new MainForm();
                    MA.Show();

                }
                else { MessageBox.Show("utilisateur introuvable ou mot de passe incorrecte", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

           
























        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
