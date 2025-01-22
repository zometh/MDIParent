namespace MDI_DB_FIRST
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSpecialite = new System.Windows.Forms.ComboBox();
            this.cbNiveau = new System.Windows.Forms.ComboBox();
            this.textLibelle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.textFacturation = new System.Windows.Forms.TextBox();
            this.rdFemme = new System.Windows.Forms.RadioButton();
            this.rdHomme = new System.Windows.Forms.RadioButton();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dbfirstDataSet = new MDI_DB_FIRST.dbfirstDataSet();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classeTableAdapter = new MDI_DB_FIRST.dbfirstDataSetTableAdapters.ClasseTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrénom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFacturation = new System.Windows.Forms.ErrorProvider(this.components);
            this.dbfirstDataSet1 = new MDI_DB_FIRST.dbfirstDataSet1();
            this.classeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classeTableAdapter1 = new MDI_DB_FIRST.dbfirstDataSet1TableAdapters.ClasseTableAdapter();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfirstDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrénom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFacturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfirstDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1168, 767);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1160, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 455);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbSpecialite);
            this.groupBox2.Controls.Add(this.cbNiveau);
            this.groupBox2.Controls.Add(this.textLibelle);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(7, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 455);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classe";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(172, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(318, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSpecialite
            // 
            this.cbSpecialite.FormattingEnabled = true;
            this.cbSpecialite.Items.AddRange(new object[] {
            "INFORMATIQUE",
            "GESTION",
            "MARKETING",
            "RESEAUX",
            "MANAGEMENT"});
            this.cbSpecialite.Location = new System.Drawing.Point(192, 289);
            this.cbSpecialite.Name = "cbSpecialite";
            this.cbSpecialite.Size = new System.Drawing.Size(190, 24);
            this.cbSpecialite.TabIndex = 7;
            // 
            // cbNiveau
            // 
            this.cbNiveau.FormattingEnabled = true;
            this.cbNiveau.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "M1",
            "M2"});
            this.cbNiveau.Location = new System.Drawing.Point(192, 190);
            this.cbNiveau.Name = "cbNiveau";
            this.cbNiveau.Size = new System.Drawing.Size(190, 24);
            this.cbNiveau.TabIndex = 6;
            // 
            // textLibelle
            // 
            this.textLibelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLibelle.Location = new System.Drawing.Point(192, 83);
            this.textLibelle.Multiline = true;
            this.textLibelle.Name = "textLibelle";
            this.textLibelle.Size = new System.Drawing.Size(190, 29);
            this.textLibelle.TabIndex = 5;
            this.textLibelle.Validating += new System.ComponentModel.CancelEventHandler(this.textLibelle_Validating);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(20, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Spécialité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Niveau";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Libellé";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.textSearch);
            this.tabPage2.Controls.Add(this.comboBoxClasse);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textAge);
            this.tabPage2.Controls.Add(this.birthDate);
            this.tabPage2.Controls.Add(this.textFacturation);
            this.tabPage2.Controls.Add(this.rdFemme);
            this.tabPage2.Controls.Add(this.rdHomme);
            this.tabPage2.Controls.Add(this.textNom);
            this.tabPage2.Controls.Add(this.textPrenom);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1160, 738);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(214, 576);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClasse.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(209, 528);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Classe";
            // 
            // textAge
            // 
            this.textAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAge.Enabled = false;
            this.textAge.Location = new System.Drawing.Point(955, 484);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 22);
            this.textAge.TabIndex = 18;
            // 
            // birthDate
            // 
            this.birthDate.CustomFormat = "dd-MM-yyyy";
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(649, 485);
            this.birthDate.MaxDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(124, 22);
            this.birthDate.TabIndex = 17;
            this.birthDate.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.birthDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textFacturation
            // 
            this.textFacturation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFacturation.Location = new System.Drawing.Point(7, 579);
            this.textFacturation.Name = "textFacturation";
            this.textFacturation.Size = new System.Drawing.Size(138, 22);
            this.textFacturation.TabIndex = 16;
            this.textFacturation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFacturation_KeyPress);
            this.textFacturation.Validating += new System.ComponentModel.CancelEventHandler(this.textFacturation_Validating);
            // 
            // rdFemme
            // 
            this.rdFemme.AutoSize = true;
            this.rdFemme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemme.Location = new System.Drawing.Point(491, 485);
            this.rdFemme.Name = "rdFemme";
            this.rdFemme.Size = new System.Drawing.Size(79, 20);
            this.rdFemme.TabIndex = 15;
            this.rdFemme.TabStop = true;
            this.rdFemme.Text = "Femme";
            this.rdFemme.UseVisualStyleBackColor = true;
            // 
            // rdHomme
            // 
            this.rdHomme.AutoSize = true;
            this.rdHomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHomme.Location = new System.Drawing.Point(408, 485);
            this.rdHomme.Name = "rdHomme";
            this.rdHomme.Size = new System.Drawing.Size(81, 20);
            this.rdHomme.TabIndex = 14;
            this.rdHomme.TabStop = true;
            this.rdHomme.Text = "Homme";
            this.rdHomme.UseVisualStyleBackColor = true;
            // 
            // textNom
            // 
            this.textNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNom.Location = new System.Drawing.Point(214, 483);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(146, 22);
            this.textNom.TabIndex = 13;
            this.textNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNom_KeyPress);
            this.textNom.Validating += new System.ComponentModel.CancelEventHandler(this.textNom_Validating);
            // 
            // textPrenom
            // 
            this.textPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrenom.Location = new System.Drawing.Point(7, 484);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(138, 22);
            this.textPrenom.TabIndex = 12;
            this.textPrenom.TextChanged += new System.EventHandler(this.textPrenom_TextChanged);
            this.textPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrenom_KeyPress);
            this.textPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.textPrenom_Validating);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(840, 639);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 39);
            this.button7.TabIndex = 11;
            this.button7.Text = "Fermer X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(645, 639);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 39);
            this.button6.TabIndex = 10;
            this.button6.Text = "Supprimer";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(422, 639);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 39);
            this.button5.TabIndex = 9;
            this.button5.Text = "Modifier";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(210, 639);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "Enregistrer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Facturation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(950, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(644, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date de naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prénom";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1147, 356);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1160, 611);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dbfirstDataSet
            // 
            this.dbfirstDataSet.DataSetName = "dbfirstDataSet";
            this.dbfirstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataMember = "Classe";
            this.classeBindingSource.DataSource = this.dbfirstDataSet;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProviderPrénom
            // 
            this.errorProviderPrénom.ContainerControl = this;
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // errorProviderFacturation
            // 
            this.errorProviderFacturation.ContainerControl = this;
            // 
            // dbfirstDataSet1
            // 
            this.dbfirstDataSet1.DataSetName = "dbfirstDataSet1";
            this.dbfirstDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classeBindingSource1
            // 
            this.classeBindingSource1.DataMember = "Classe";
            this.classeBindingSource1.DataSource = this.dbfirstDataSet1;
            // 
            // classeTableAdapter1
            // 
            this.classeTableAdapter1.ClearBeforeFill = true;
            // 
            // textSearch
            // 
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSearch.Location = new System.Drawing.Point(7, 13);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(177, 26);
            this.textSearch.TabIndex = 21;
            this.textSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Teal;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(190, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 37);
            this.button8.TabIndex = 22;
            this.button8.Text = "Rechercher";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SteelBlue;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(308, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 37);
            this.button9.TabIndex = 23;
            this.button9.Text = "Effacer";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 739);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfirstDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrénom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFacturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbfirstDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSpecialite;
        private System.Windows.Forms.ComboBox cbNiveau;
        private System.Windows.Forms.TextBox textLibelle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbfirstDataSet dbfirstDataSet;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private dbfirstDataSetTableAdapters.ClasseTableAdapter classeTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.RadioButton rdFemme;
        private System.Windows.Forms.RadioButton rdHomme;
        private System.Windows.Forms.TextBox textFacturation;
        private System.Windows.Forms.ErrorProvider errorProviderPrénom;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.ErrorProvider errorProviderFacturation;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxClasse;
        private dbfirstDataSet1 dbfirstDataSet1;
        private System.Windows.Forms.BindingSource classeBindingSource1;
        private dbfirstDataSet1TableAdapters.ClasseTableAdapter classeTableAdapter1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button button9;
    }
}

