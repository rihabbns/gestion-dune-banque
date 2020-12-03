namespace Banque
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerLesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerLeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerComptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAISSEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.virementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retraitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageDesEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.cOMPTEToolStripMenuItem,
            this.cAISSEToolStripMenuItem1,
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1025, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnClientToolStripMenuItem,
            this.listerLesClientsToolStripMenuItem,
            this.editerLeClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // ajouterUnClientToolStripMenuItem
            // 
            this.ajouterUnClientToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite;
            this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
            this.ajouterUnClientToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.ajouterUnClientToolStripMenuItem.Text = "ajouter un client";
            this.ajouterUnClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnClientToolStripMenuItem_Click);
            // 
            // listerLesClientsToolStripMenuItem
            // 
            this.listerLesClientsToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite;
            this.listerLesClientsToolStripMenuItem.Name = "listerLesClientsToolStripMenuItem";
            this.listerLesClientsToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.listerLesClientsToolStripMenuItem.Text = "lister les clients";
            this.listerLesClientsToolStripMenuItem.Click += new System.EventHandler(this.listerLesClientsToolStripMenuItem_Click);
            // 
            // editerLeClientToolStripMenuItem
            // 
            this.editerLeClientToolStripMenuItem.BackColor = System.Drawing.Color.GhostWhite;
            this.editerLeClientToolStripMenuItem.Name = "editerLeClientToolStripMenuItem";
            this.editerLeClientToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.editerLeClientToolStripMenuItem.Text = "Editer un client";
            this.editerLeClientToolStripMenuItem.Click += new System.EventHandler(this.editerLeClientToolStripMenuItem_Click);
            // 
            // cOMPTEToolStripMenuItem
            // 
            this.cOMPTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutCompteToolStripMenuItem,
            this.listerComptesToolStripMenuItem,
            this.modificationCompteToolStripMenuItem});
            this.cOMPTEToolStripMenuItem.Name = "cOMPTEToolStripMenuItem";
            this.cOMPTEToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.cOMPTEToolStripMenuItem.Text = "Compte";
            // 
            // ajoutCompteToolStripMenuItem
            // 
            this.ajoutCompteToolStripMenuItem.Name = "ajoutCompteToolStripMenuItem";
            this.ajoutCompteToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.ajoutCompteToolStripMenuItem.Text = "Ajout compte";
            this.ajoutCompteToolStripMenuItem.Click += new System.EventHandler(this.ajoutCompteToolStripMenuItem_Click_1);
            // 
            // listerComptesToolStripMenuItem
            // 
            this.listerComptesToolStripMenuItem.Name = "listerComptesToolStripMenuItem";
            this.listerComptesToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.listerComptesToolStripMenuItem.Text = "Lister comptes";
            this.listerComptesToolStripMenuItem.Click += new System.EventHandler(this.listerComptesToolStripMenuItem_Click_1);
            // 
            // modificationCompteToolStripMenuItem
            // 
            this.modificationCompteToolStripMenuItem.Name = "modificationCompteToolStripMenuItem";
            this.modificationCompteToolStripMenuItem.Size = new System.Drawing.Size(344, 36);
            this.modificationCompteToolStripMenuItem.Text = "Modification compte";
            this.modificationCompteToolStripMenuItem.Click += new System.EventHandler(this.modificationCompteToolStripMenuItem_Click_1);
            // 
            // cAISSEToolStripMenuItem1
            // 
            this.cAISSEToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.virementsToolStripMenuItem,
            this.retraitsToolStripMenuItem,
            this.versementsToolStripMenuItem});
            this.cAISSEToolStripMenuItem1.Name = "cAISSEToolStripMenuItem1";
            this.cAISSEToolStripMenuItem1.Size = new System.Drawing.Size(99, 36);
            this.cAISSEToolStripMenuItem1.Text = "Caisse";
            // 
            // virementsToolStripMenuItem
            // 
            this.virementsToolStripMenuItem.Name = "virementsToolStripMenuItem";
            this.virementsToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.virementsToolStripMenuItem.Text = "Virements";
            this.virementsToolStripMenuItem.Click += new System.EventHandler(this.virementsToolStripMenuItem_Click_1);
            // 
            // retraitsToolStripMenuItem
            // 
            this.retraitsToolStripMenuItem.Name = "retraitsToolStripMenuItem";
            this.retraitsToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.retraitsToolStripMenuItem.Text = "Retraits";
            this.retraitsToolStripMenuItem.Click += new System.EventHandler(this.retraitsToolStripMenuItem_Click_1);
            // 
            // versementsToolStripMenuItem
            // 
            this.versementsToolStripMenuItem.Name = "versementsToolStripMenuItem";
            this.versementsToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.versementsToolStripMenuItem.Text = "Versements";
            this.versementsToolStripMenuItem.Click += new System.EventHandler(this.versementsToolStripMenuItem_Click_1);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créationToolStripMenuItem,
            this.créditToolStripMenuItem,
            this.affichageDesEmployeesToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(151, 36);
            this.transactionsToolStripMenuItem.Text = "Employees";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // créationToolStripMenuItem
            // 
            this.créationToolStripMenuItem.Name = "créationToolStripMenuItem";
            this.créationToolStripMenuItem.Size = new System.Drawing.Size(388, 36);
            this.créationToolStripMenuItem.Text = "Ajout employee";
            this.créationToolStripMenuItem.Click += new System.EventHandler(this.créationToolStripMenuItem_Click);
            // 
            // créditToolStripMenuItem
            // 
            this.créditToolStripMenuItem.Name = "créditToolStripMenuItem";
            this.créditToolStripMenuItem.Size = new System.Drawing.Size(388, 36);
            this.créditToolStripMenuItem.Text = "Modification employee";
            this.créditToolStripMenuItem.Click += new System.EventHandler(this.créditToolStripMenuItem_Click);
            // 
            // affichageDesEmployeesToolStripMenuItem
            // 
            this.affichageDesEmployeesToolStripMenuItem.Name = "affichageDesEmployeesToolStripMenuItem";
            this.affichageDesEmployeesToolStripMenuItem.Size = new System.Drawing.Size(388, 36);
            this.affichageDesEmployeesToolStripMenuItem.Text = "Affichage des employees";
            this.affichageDesEmployeesToolStripMenuItem.Click += new System.EventHandler(this.affichageDesEmployeesToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "SORTIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 136);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRIVILEGE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENUE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1025, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerLesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerLeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAISSEToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ajoutCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerComptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retraitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageDesEmployeesToolStripMenuItem;
    }
}