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
    public partial class ListerComptes : Form
    {
        public ListerComptes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListerComptes_Load(object sender, EventArgs e)
        {
            MY_DB connection = new MY_DB();

            connection.openConnection();
            
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * from compte", connection.getConnection);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
               
            /*editclient.textBoxid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editclient.textBoxnom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editclient.textBoxprenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Femme")
            {
                editclient.radioButtonfemme.Checked = true;
            }
            editclient.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
            editclient.textBoxcin.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            editclient.textBoxadr.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            editclient.textBoxtel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            editclient.textBoxmail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[9].Value;
            MemoryStream picture = new MemoryStream(pic);
            editclient.pictureBoxpic.Image = Image.FromStream(picture);
            editclient.Show();
            if (dataGridView1.CurrentRow.Cells[10].Value.ToString() == "avec motif")
            {
                editclient.radioButton1.Checked = true;
            }*/
            connection.closeConnection();
        }
    }

}
    

