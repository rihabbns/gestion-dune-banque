namespace Banque
{
    partial class retrait
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
            this.label2 = new System.Windows.Forms.Label();
            this.gpbCreationVirement = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDateEmission = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontantVirement = new System.Windows.Forms.TextBox();
            this.txtNumeroCompte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbCreationVirement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 86);
            this.label2.TabIndex = 4;
            this.label2.Text = "Retrait ";
            // 
            // gpbCreationVirement
            // 
            this.gpbCreationVirement.Controls.Add(this.textBox1);
            this.gpbCreationVirement.Controls.Add(this.label1);
            this.gpbCreationVirement.Controls.Add(this.button1);
            this.gpbCreationVirement.Controls.Add(this.dtpDateEmission);
            this.gpbCreationVirement.Controls.Add(this.label7);
            this.gpbCreationVirement.Controls.Add(this.txtMontantVirement);
            this.gpbCreationVirement.Controls.Add(this.txtNumeroCompte);
            this.gpbCreationVirement.Controls.Add(this.label5);
            this.gpbCreationVirement.Controls.Add(this.label4);
            this.gpbCreationVirement.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCreationVirement.Location = new System.Drawing.Point(13, 92);
            this.gpbCreationVirement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbCreationVirement.Name = "gpbCreationVirement";
            this.gpbCreationVirement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbCreationVirement.Size = new System.Drawing.Size(507, 415);
            this.gpbCreationVirement.TabIndex = 5;
            this.gpbCreationVirement.TabStop = false;
            this.gpbCreationVirement.Text = "Retrait";
            this.gpbCreationVirement.Enter += new System.EventHandler(this.gpbCreationVirement_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 146);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 47);
            this.textBox1.TabIndex = 12;
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
            // 
            // txtNumeroCompte
            // 
            this.txtNumeroCompte.Location = new System.Drawing.Point(224, 60);
            this.txtNumeroCompte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroCompte.Name = "txtNumeroCompte";
            this.txtNumeroCompte.Size = new System.Drawing.Size(259, 47);
            this.txtNumeroCompte.TabIndex = 3;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(640, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(398, 398);
            this.dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(517, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 47);
            this.button2.TabIndex = 25;
            this.button2.Text = "Effectuer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Avant retrait:";
            // 
            // retrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1068, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbCreationVirement);
            this.Controls.Add(this.label2);
            this.Name = "retrait";
            this.Text = "retrait";
            this.gpbCreationVirement.ResumeLayout(false);
            this.gpbCreationVirement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbCreationVirement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDateEmission;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMontantVirement;
        private System.Windows.Forms.TextBox txtNumeroCompte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}