using MBIParent.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBIParent
{
    public partial class EtudiantForm : Form
    {
        public EtudiantForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FieldsFilled())
            {
                using (var db = new DbScolaireContext())
                {
                    Etudiant etudiant = new Etudiant();
                    etudiant.Prenom = textPrenom.Text;
                    etudiant.Nom = textNom.Text;
                    var selectedClasse = (Classe)cbClasse.SelectedItem;
                    etudiant.Classe = db.Classes.SingleOrDefault(c => c.ID == selectedClasse.ID);
                    etudiant.IdClasse = etudiant.Classe.ID;
                    db.Etudiants.Add(etudiant);
                    
                    db.SaveChanges();
                    ClearFields();
                    MessageBox.Show(
                            "Etudiant ajouté avec succès",
                            "",
                            MessageBoxButtons.OK

                            );
                    LoadDatas();

                }
            }
            else
            {
                MessageBox.Show(
                            "Veuillez remplir tous les champs",
                            "",
                            MessageBoxButtons.OK,
                            icon: MessageBoxIcon.Error

                            );
            }
        }
        private void LoadComboBox()
        {
            using (var db = new DbScolaireContext())
            {
                cbClasse.DataSource = db.Classes.ToList();
                cbClasse.DisplayMember = "Libelle";
                cbClasse.ValueMember = "Id";

            }
        }
        private void LoadDatas()
        {
            dataGridViewEtudiant.DataSource = null;
            using (var db = new DbScolaireContext())
            {
                dataGridViewEtudiant.DataSource = db.Etudiants.Select(
                e => new ViewEtudiant
                {
                    Prenom = e.Prenom,
                    Classe = e.Classe.Libelle,
                    Nom = e.Nom,
                    Id = e.ID,

                }
                ).ToList();

            }
        }
        private void EtudiantForm_Load(object sender, EventArgs e)
        {
            LoadDatas();
            LoadComboBox();
        }

        private void FillFields(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEtudiant_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEtudiant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (var db = new DbScolaireContext())
                {
                    int index = e.RowIndex;
                    var selectedObject = dataGridViewEtudiant.CurrentRow.DataBoundItem as ViewEtudiant;

                    textPrenom.Text = dataGridViewEtudiant.Rows[index].Cells[1].Value.ToString();
                    textNom.Text = dataGridViewEtudiant.Rows[index].Cells[2].Value.ToString();
                    cbClasse.Text = dataGridViewEtudiant.Rows[index].Cells[3].Value.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewEtudiant.CurrentRow != null)
            {
                using (var db = new DbScolaireContext())
                {
                    var selectedObject = dataGridViewEtudiant.CurrentRow.DataBoundItem as ViewEtudiant;
                    var result = db.Etudiants.SingleOrDefault(b => b.ID == selectedObject.Id);
                    if (result != null)
                    {
                        result.Nom = textNom.Text;
                        result.Prenom = textPrenom.Text;
                        result.Classe = (Classe)cbClasse.SelectedItem;
                        result.IdClasse = (int)cbClasse.SelectedValue;
                        db.SaveChanges();
                        ClearFields();
                        MessageBox.Show(
                        "Etudiant modifié avec succès",
                        "",
                        MessageBoxButtons.OK

                        );
                        LoadDatas();
                    }

                }

                // Do something with selectedObject
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new DbScolaireContext())
            {
                var selectedObject = dataGridViewEtudiant.CurrentRow.DataBoundItem as ViewEtudiant;
                var result = db.Etudiants.SingleOrDefault(b => b.ID == selectedObject.Id);

                if (result != null)
                {
                    
                    
                        db.Etudiants.Remove(result);
                        db.SaveChanges();
                        ClearFields();
                        LoadDatas();
                        MessageBox.Show(
                            "Etudiant supprimé avec succès",
                            "",
                            MessageBoxButtons.OK

                            );
                    }
                   

                    
                
            }
        }
        bool FieldsFilled()
        {
            return textNom.Text != "" || textNom.Text != "";
        }
        private void ClearFields()
        {
            textNom.Text = "";
            textPrenom.Text = "";
        }
    }
}
