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
    public partial class Listerclient : Form
    {
        public Listerclient()
        {
            InitializeComponent();
        }
        client client = new client();

        private void Listerclient_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `client`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = client.listerclients(command);
            piccol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonrefrech_Click(object sender, EventArgs e)
        { //refraichir
            MySqlCommand command = new MySqlCommand("SELECT * FROM `client`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = client.listerclients(command);
            piccol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_doubleClick(object sender, EventArgs e)
        {
            editerclients editclient = new editerclients();
            editclient.textBoxid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
            pic = (byte[]) dataGridView1.CurrentRow.Cells[9].Value;
            MemoryStream picture = new MemoryStream(pic);
            editclient.pictureBoxpic.Image = Image.FromStream(picture);
            editclient.Show();
            if (dataGridView1.CurrentRow.Cells[10].Value.ToString() == "avec motif")
            {
                editclient.radioButton1.Checked = true;
            }
        }
    }
}
