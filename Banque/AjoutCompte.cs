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
    public partial class AjoutCompte : Form
    {
        public AjoutCompte()
        {
            InitializeComponent();
        }

        private void AjoutCompte_Load(object sender, EventArgs e)
        {

        }

        private void nom_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MY_DB connection = new MY_DB();
            string idcl = textBox1.Text;
            int idcl1 = int.Parse(idcl);
            string type = comboBox1.SelectedItem.ToString();
            string solde = textBox2.Text;
            double sol = double.Parse(solde);
            string searchquery = "SELECT * from client where id='" + idcl1 + "'";
            int interet = 6;
            MySqlCommand cmd = new MySqlCommand(searchquery, connection.getConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connection.openConnection();
           
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Client found");
                    string insertquery = "INSERT INTO COMPTE (id_cl,type_cc,solde) values('" + idcl1 + "','" + type + "','" + solde + "')";
                    string insertquery2 = "INSERT INTO COMPTE (id_cl,type_cc,interet,solde) values('" + idcl1 + "','" + type + "','" + interet + "','" + solde + "')";

                    MySqlCommand command = new MySqlCommand(insertquery, connection.getConnection);
                    MySqlCommand command2 = new MySqlCommand(insertquery2, connection.getConnection);

                    if (type == "Epargne")
                    {
                        try
                        {

                            if (command2.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Compte ajoute avec succes");
                            }
                            else { MessageBox.Show("Compte pas ajoute"); }

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    if (type == "Courant")
                    {
                        try
                        {

                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Compte ajoute avec succes");
                            }
                            else { MessageBox.Show("Compte pas ajoute"); }

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }



                }
                else
                {
                    MessageBox.Show("No client found! Please add client before adding account!");
                ajoutclient ajoutclient = new ajoutclient();
                ajoutclient.Show(this);
                }






                connection.closeConnection();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
    }

