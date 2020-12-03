namespace Banque
{
    partial class Virements
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
            this.gpbCreationVirement = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinataire = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDateEmission = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontantVirement = new System.Windows.Forms.TextBox();
            this.txtNumeroCompte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbListeVirement = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.gpbCreationVirement.SuspendLayout();
            this.gpbListeVirement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCreationVirement
            // 
            this.gpbCreationVirement.Controls.Add(this.textBox1);
            this.gpbCreationVirement.Controls.Add(this.label1);
            this.gpbCreationVirement.Controls.Add(this.txtDestinataire);
            this.gpbCreationVirement.Controls.Add(this.button1);
            this.gpbCreationVirement.Controls.Add(this.dtpDateEmission);
            this.gpbCreationVirement.Controls.Add(this.label7);
            this.gpbCreationVirement.Controls.Add(this.txtMontantVirement);
            this.gpbCreationVirement.Controls.Add(this.txtNumeroCompte);
            this.gpbCreationVirement.Controls.Add(this.label6);
            this.gpbCreationVirement.Controls.Add(this.label5);
            this.gpbCreationVirement.Controls.Add(this.label4);
            this.gpbCreationVirement.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCreationVirement.Location = new System.Drawing.Point(25, 201);
            this.gpbCreationVirement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbCreationVirement.Name = "gpbCreationVirement";
            this.gpbCreationVirement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbCreationVirement.Size = new System.Drawing.Size(550, 566);
            this.gpbCreationVirement.TabIndex = 2;
            this.gpbCreationVirement.TabStop = false;
            this.gpbCreationVirement.Text = "Création d\'un virement";
            this.gpbCreationVirement.Enter += new System.EventHandler(this.gpbCreationVirement_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 146);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 47);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id-client:*";
            // 
            // txtDestinataire
            // 
            this.txtDestinataire.Location = new System.Drawing.Point(224, 368);
            this.txtDestinataire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestinataire.Name = "txtDestinataire";
            this.txtDestinataire.Size = new System.Drawing.Size(259, 47);
            this.txtDestinataire.TabIndex = 5;
            this.txtDestinataire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestinataire_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(429, 521);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDateEmission
            // 
            this.dtpDateEmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateEmission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEmission.Location = new System.Drawing.Point(224, 449);
            this.dtpDateEmission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateEmission.Name = "dtpDateEmission";
            this.dtpDateEmission.Size = new System.Drawing.Size(259, 26);
            this.dtpDateEmission.TabIndex = 7;
            this.dtpDateEmission.Value = new System.DateTime(2011, 3, 20, 0, 0, 0, 0);
            this.dtpDateEmission.ValueChanged += new System.EventHandler(this.dtpDateEmission_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 451);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date d\'émission *";
            // 
            // txtMontantVirement
            // 
            this.txtMontantVirement.Location = new System.Drawing.Point(224, 256);
            this.txtMontantVirement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontantVirement.Name = "txtMontantVirement";
            this.txtMontantVirement.Size = new System.Drawing.Size(259, 47);
            this.txtMontantVirement.TabIndex = 4;
            this.txtMontantVirement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontantVirement_KeyPress);
            // 
            // txtNumeroCompte
            // 
            this.txtNumeroCompte.Location = new System.Drawing.Point(224, 60);
            this.txtNumeroCompte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroCompte.Name = "txtNumeroCompte";
            this.txtNumeroCompte.Size = new System.Drawing.Size(259, 47);
            this.txtNumeroCompte.TabIndex = 3;
            this.txtNumeroCompte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCompte_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = " Compte Destinataire *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Montant *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numéro de compte *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(766, 86);
            this.label2.TabIndex = 3;
            this.label2.Text = " Créer / Afficher des virements";
            // 
            // gpbListeVirement
            // 
            this.gpbListeVirement.Controls.Add(this.dataGridView3);
            this.gpbListeVirement.Controls.Add(this.label9);
            this.gpbListeVirement.Controls.Add(this.dataGridView2);
            this.gpbListeVirement.Controls.Add(this.label3);
            this.gpbListeVirement.Controls.Add(this.dataGridView1);
            this.gpbListeVirement.Controls.Add(this.label8);
            this.gpbListeVirement.Location = new System.Drawing.Point(638, 201);
            this.gpbListeVirement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbListeVirement.Name = "gpbListeVirement";
            this.gpbListeVirement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbListeVirement.Size = new System.Drawing.Size(876, 588);
            this.gpbListeVirement.TabIndex = 4;
            this.gpbListeVirement.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(432, 222);
            this.dataGridView1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(364, 39);
            this.label8.TabIndex = 1;
            this.label8.Text = "afficher les données de virements,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "Donnees du premier compte";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(444, 81);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(432, 222);
            this.dataGridView2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 316);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 39);
            this.label9.TabIndex = 15;
            this.label9.Text = "Donnees du deuxieme compte";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(227, 357);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(432, 222);
            this.dataGridView3.TabIndex = 16;
            // 
            // Virements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1529, 854);
            this.Controls.Add(this.gpbListeVirement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpbCreationVirement);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Virements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virements";
            this.gpbCreationVirement.ResumeLayout(false);
            this.gpbCreationVirement.PerformLayout();
            this.gpbListeVirement.ResumeLayout(false);
            this.gpbListeVirement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCreationVirement;
        private System.Windows.Forms.TextBox txtDestinataire;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDateEmission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMontantVirement;
        private System.Windows.Forms.TextBox txtNumeroCompte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbListeVirement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
    }
}