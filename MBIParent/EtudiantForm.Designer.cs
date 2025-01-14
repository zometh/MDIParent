namespace MBIParent
{
    partial class EtudiantForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewEtudiant = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prénom";
            // 
            // textPrenom
            // 
            this.textPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrenom.Location = new System.Drawing.Point(42, 103);
            this.textPrenom.Multiline = true;
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(173, 35);
            this.textPrenom.TabIndex = 1;
            // 
            // textNom
            // 
            this.textNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNom.Location = new System.Drawing.Point(42, 193);
            this.textNom.Multiline = true;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(173, 35);
            this.textNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Classe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbClasse
            // 
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(42, 296);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(121, 24);
            this.cbClasse.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(109, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewEtudiant
            // 
            this.dataGridViewEtudiant.AllowUserToAddRows = false;
            this.dataGridViewEtudiant.AllowUserToDeleteRows = false;
            this.dataGridViewEtudiant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtudiant.Location = new System.Drawing.Point(298, 32);
            this.dataGridViewEtudiant.Name = "dataGridViewEtudiant";
            this.dataGridViewEtudiant.ReadOnly = true;
            this.dataGridViewEtudiant.RowHeadersWidth = 51;
            this.dataGridViewEtudiant.RowTemplate.Height = 24;
            this.dataGridViewEtudiant.Size = new System.Drawing.Size(479, 325);
            this.dataGridViewEtudiant.TabIndex = 7;
            this.dataGridViewEtudiant.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEtudiant_CellContentDoubleClick);
            this.dataGridViewEtudiant.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEtudiant_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(345, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(558, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EtudiantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewEtudiant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.label1);
            this.Name = "EtudiantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EtudiantForm";
            this.Load += new System.EventHandler(this.EtudiantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewEtudiant;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}