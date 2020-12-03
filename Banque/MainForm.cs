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
using MySql.Data.MySqlClient;
using System.IO;

namespace Banque
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        private void ajouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajoutclient ajoutc = new ajoutclient();
            ajoutc.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listerLesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listerclient listerc = new Listerclient();
            listerc.Show(this);
        }

        private void editerLeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editerclients up = new editerclients();
            up.Show(this);
        }

        private void créationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutAgent agent = new AjoutAgent();
            agent.Show(this);
        }

        private void pictureBoxpic_Click(object sender, EventArgs e)
        {
           
        }

        private void gpbproprietes_Enter(object sender, EventArgs e)
        {
            
        }
      //houni
        public void donneeuser()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `acteur` WHERE `id`=@uid", mydb.getConnection);

            command.Parameters.Add("@uid", MySqlDbType.Int32).Value = actG.useridglobale;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {//taswira
                byte[] pic = (byte[])table.Rows[0]["photo"];
                MemoryStream picture = new MemoryStream(pic);
               pictureBox1.Image = Image.FromStream(picture);
                //nom
                label1.Text = "BIENVENUE:" + table.Rows[0]["nom"] + table.Rows[0]["prenom"];
                label2.Text = "VOTRE PRIVILEGE EST :" + table.Rows[0]["privelege"];
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            donneeuser();
        }

        private void ajoutCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutCompte ajoutc = new AjoutCompte();
            ajoutc.Show(this);
        }

        private void listerComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListerComptes listerComptes = new ListerComptes();
            listerComptes.Show(this);
        }

        private void modificationCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditerComptes editerComptes = new EditerComptes();
            editerComptes.Show(this);
        }

        private void virementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Virements vr = new Virements();
            vr.Show(this); 
        }

        private void retraitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void versementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void affichageDesEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AffichageEmp emp = new AffichageEmp();
            emp.Show(this);
        }

        private void versementsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Versement vr = new Versement();
            vr.Show(this);
        }

        private void retraitsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            retrait rt = new retrait();
            rt.Show(this);
        }

        private void virementsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Virements vr = new Virements();
            vr.Show(this);
        }

        private void ajoutCompteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AjoutCompte a = new AjoutCompte();
            a.Show(this);
        }

        private void listerComptesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListerComptes l = new ListerComptes();
            l.Show(this);
        }

        private void modificationCompteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditerComptes ed = new EditerComptes();
            ed.Show(this);
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void créditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificationAG ag = new ModificationAG();
            ag.Show(this);
        }
    }
}
