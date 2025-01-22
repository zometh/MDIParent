using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_DB_FIRST
{
    public partial class Form1 : Form
    {
        int _age = 0;
        public Form1()
        {
            InitializeComponent();
            tabPage1.Text = "Classe";
            tabPage2.Text = "Etudiant";
            tabPage3.Text = "Rapport";
            textAge.Text = _age.ToString();
            LoadEtudiant();
            LoadClasses();
            LoadClassesBox();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dbfirstDataSet1.Classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classeTableAdapter1.Fill(this.dbfirstDataSet1.Classe);
            // TODO: cette ligne de code charge les données dans la table 'dbfirstDataSet.Classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classeTableAdapter.Fill(this.dbfirstDataSet.Classe);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FieldsFilled())
            {
                using (var db = new dbfirstEntities())
                {
                    Classe classe = new Classe
                    {
                        Libelle = textLibelle.Text,
                        Niveau = cbNiveau.Text,
                        Specialite = cbSpecialite.Text
                    };
                    db.Classe.Add(classe);
                    db.SaveChanges();
                    LoadClasses();
                    ClearFields();
                    LoadClassesBox();
                    ShowMessage("Classe ajoutée");

                }
            }
            else
            {
                ShowMessage("Veuillez remplir tous les champs", true);
            }

        }
        private void LoadClasses()
        {
            using (var db = new dbfirstEntities())
            {
                
                dataGridView1.DataSource = db.Classe.Select(classe => new ClassView { id = classe.id,
                
                Libelle = classe.Libelle,
                Niveau = classe.Niveau,
                Specialite = classe.Specialite
                }).ToList();
            }
              }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FieldsFilled())
            {
                using (var db = new dbfirstEntities())
                {
                    var selectedRow = dataGridView1.CurrentRow.DataBoundItem as ClassView;
                    var selectedClasse = db.Classe.FirstOrDefault(c => c.id == selectedRow.id);
                    if (selectedClasse != null)
                    {
                        Classe classe = new Classe
                        {
                            id = selectedClasse.id,
                            Libelle = textLibelle.Text,
                            Niveau = cbNiveau.Text,
                            Specialite = cbSpecialite.Text
                        };
                        db.Classe.AddOrUpdate(classe);
                        db.SaveChanges();
                        LoadClasses();
                        ClearFields();
                        ShowMessage("Classe modifiée");

                       
                    }
                }
            }
            else
            {
                ShowMessage("Selectionnez d'abord une ligne", true);
                
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dataGridView1.CurrentRow.DataBoundItem as ClassView;
            textLibelle.Text = selectedRow.Libelle;
            cbNiveau.Text = selectedRow.Niveau;
            cbSpecialite.Text = selectedRow.Specialite;
        }
        private void ClearFields()
        {
            textLibelle.Clear();
            cbNiveau.Text = "";
            cbSpecialite.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.CurrentRow.DataBoundItem as ClassView;
            if(selectedRow != null)
            {
                using (var db = new dbfirstEntities())
                {

                    var selectedClasse = db.Classe.FirstOrDefault(c => c.id == selectedRow.id);
                    db.Classe.Remove(selectedClasse);
                    db.SaveChanges();
                    LoadClasses();
                    ClearFields();

                    ShowMessage("Classe supprimée");
                }
            }
            
        }
        private bool FieldsFilled()
        {
            return textLibelle.Text != "" && cbNiveau.Text != "" && cbSpecialite.Text != "";
        }
        private void ShowMessage(String text, bool isError = false)
        {
           if(isError) MessageBox.Show(

                    text, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
           else MessageBox.Show(

                    text, "", MessageBoxButtons.OK);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textLibelle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textLibelle.Text))
            {
                e.Cancel = true;
                textLibelle.Focus();
                errorProvider1.SetError(textLibelle, "Champs requis");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textLibelle, null);
            }
        }

        private void textFacturation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void textPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCaracter(e);
            
        }
        void CheckCaracter(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckCaracter(e);
        }

        private void textPrenom_Validating(object sender, CancelEventArgs e)
        {
            ValidateForm(e, textPrenom, errorProviderPrénom);

        }

        private void textNom_Validating(object sender, CancelEventArgs e)
        {
            ValidateForm(e, textNom, errorProviderNom);

        }

        private void textPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFacturation_Validating(object sender, CancelEventArgs e)
        {
            ValidateForm(e, textFacturation, errorProviderFacturation);
        }
        private void ValidateForm(CancelEventArgs e, TextBox text, ErrorProvider errorProvider)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                e.Cancel = true;
                text.Focus();
                errorProvider.SetError(text, "Champs requis");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(text, null);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = birthDate.Value;

            // Calculer l'âge
            int age = CalculateAge(selectedDate);
            _age = age;
            // Remplir le champ âge
            textAge.Text = age.ToString() + " ans";
        }
      

        private int CalculateAge(DateTime birthDate)
        {
            // Date actuelle
            DateTime today = DateTime.Today;

            // Calcul de l'âge
            int age = today.Year - birthDate.Year;

            // Ajuster l'âge si la date d'anniversaire n'est pas encore passée cette année
            /*if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }*/

            return age;
        }
        private void LoadClassesBox()
        {
            using (var db = new dbfirstEntities())
            {
                comboBoxClasse.DataSource = db.Classe.ToList();
                comboBoxClasse.DisplayMember = "Libelle";
                comboBoxClasse.ValueMember = "id";
            }

        }
        private void ClearFieldsEtudiant()
        {
            textPrenom.Clear();
            textNom.Clear();
            textFacturation.Clear();
            birthDate.MinDate = new DateTime(month: 1, year: 2010, day: 1);
            comboBoxClasse.Text = "";
            _age = 0;
            textAge.Text = _age.ToString();           

        }
        private bool FieldsFilledEtudiant()
        {
            String sexe = "";
            if (rdHomme.Checked) sexe = "Homme";
            if (rdFemme.Checked) sexe = "Femme";

            return textPrenom.Text != ""
                && textPrenom.Text != ""
                && textFacturation.Text != ""
                && comboBoxClasse.Text != ""
                && sexe != ""
                && _age != 0;
        }
        private void LoadEtudiant()
        {
            using (var db = new dbfirstEntities())
            {
                db.Etudiant.Load();
                var bindingList = new BindingList<EtudiantView>(
                    db.Etudiant.Local
                        .Select(e => new EtudiantView
                        {
                            id = e.id,
                            Prénom = e.Prénom,
                            Nom = e.Nom,
                            Age = e.Age,
                            facturation = (int)e.facturation,
                            Classe = e.Classe.Libelle,
                            Sexe = e.Sexe
                        })
                        .ToList()
                );
                dataGridView2.DataSource = bindingList;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (FieldsFilledEtudiant())
            {
                using (var db = new dbfirstEntities())
                {
                    Etudiant etudiant = new Etudiant();
                    var selected = (Classe)comboBoxClasse.SelectedItem;
                    Classe classe = db.Classe.SingleOrDefault(c => c.id == selected.id);
                    etudiant.Prénom = textPrenom.Text;
                    etudiant.Nom = textNom.Text;
                    etudiant.Age = _age;
                    etudiant.facturation = int.Parse(textFacturation.Text);
                    etudiant.IdClasse = classe.id;
                    etudiant.Classe = classe;
                    etudiant.Sexe = (rdFemme.Checked) ? "Femme" : "Homme";
                    db.Etudiant.Add(etudiant);
                    db.SaveChanges();
                    ClearFieldsEtudiant();
                    LoadEtudiant();
                    ShowMessage("Etudiant ajouté");
                }
            }
            else
            {
                ShowMessage("Veuillez remplir tous les champs", true);
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = dataGridView2.CurrentRow.DataBoundItem as EtudiantView;
            if(selected != null)
            {
                textPrenom.Text = selected.Prénom;
                textNom.Text = selected.Nom;
                _age = selected.Age;
                textAge.Text = _age.ToString();
                textFacturation.Text = selected.facturation.ToString();
                if(selected.Sexe == "Homme")
                {
                    rdHomme.Checked = true;
                }
                else
                {
                    rdFemme.Checked = true;
                }
                Classe classe;
                using (var db = new dbfirstEntities())
                {
                    classe = db.Classe.SingleOrDefault(c => c.id == selected.id);
                }
              

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (FieldsFilledEtudiant())
            {
                using (var db = new dbfirstEntities())
                {
                    var current = dataGridView2.CurrentRow.DataBoundItem as EtudiantView;

                    Etudiant etudiant = new Etudiant();
                    etudiant.id = current.id;
                    var selected = (Classe)comboBoxClasse.SelectedItem;
                    Classe classe = db.Classe.FirstOrDefault(c => c.id == selected.id);
                    etudiant.Prénom = textPrenom.Text;
                    etudiant.Nom = textNom.Text;
                    etudiant.Age = _age;
                    etudiant.facturation = int.Parse(textFacturation.Text);
                    etudiant.IdClasse = classe.id;
                    etudiant.Classe = classe;
                    etudiant.Sexe = (rdFemme.Checked) ? "Femme" : "Homme";
                    db.Etudiant.AddOrUpdate(etudiant);
                    db.SaveChanges();
                    ClearFieldsEtudiant();
                    LoadEtudiant();
                    ShowMessage("Etudiant modifié");
                }
            }
            else
            {
                ShowMessage("Veuillez remplir tous les champs", true);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var selected = dataGridView2.CurrentRow.DataBoundItem as EtudiantView;
            if (selected != null)
            {
                using (var db = new dbfirstEntities())
                {
                    Etudiant etudiant = db.Etudiant.FirstOrDefault(et => et.id == selected.id);
                    db.Etudiant.Remove(etudiant);
                    db.SaveChanges();
                    ClearFieldsEtudiant();
                    LoadEtudiant();
                    ShowMessage("Etudiant supprimé");
                }

                    
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != "")
            {
                using (var db = new dbfirstEntities())

                {

                    List<Etudiant> etudiants = db.Etudiant.Where(et => et.Prénom.ToLower().Contains(textSearch.Text.ToLower())

                    || et.Nom.ToLower().Contains(textSearch.Text.ToLower())


                    ).ToList();
                    dataGridView2.DataSource = etudiants.Select(et => new EtudiantView
                    {
                        id = et.id,
                        Prénom = et.Prénom,
                        Nom = et.Nom,
                        Age = et.Age,
                        facturation = (int)et.facturation,
                        Classe = et.Classe.Libelle,
                        Sexe = et.Sexe
                    }).ToList();
                }
            }
            else
            {
                LoadEtudiant();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textSearch.Clear();
            LoadEtudiant();
        }
    }
    }

