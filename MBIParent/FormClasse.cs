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
    public partial class FormClasse : Form
    {
        public FormClasse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FieldsFilled())
            {
                using (var db = new DbScolaireContext())
                {
                    Classe classe = new Classe
                    {
                        Libelle = textLibelle.Text
                    };
                    int nbOccurence = db.Classes
                        .Where(c => c.Libelle.ToLower() == classe.Libelle.ToLower()).ToList().Count();
                    if(nbOccurence == 0)
                    {
                        db.Classes.Add(classe);
                        db.SaveChanges();
                        MessageBox.Show(
                                "Classe ajoutée avec succès",
                                "",
                                MessageBoxButtons.OK


                                );
                        ClearFields();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show(
                           "Cette classe existe déja",
                           "",
                           MessageBoxButtons.OK,
                           icon: MessageBoxIcon.Error

                           );
                    }
                    
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
        public void refresh()
        {
            using (var db = new DbScolaireContext())
            {
                dataGridView1.DataSource = db.Classes.ToList();

            }
        }

        private void FormClasse_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void ClearFields()
        {
            textLibelle.Text = "";
        }
        private bool FieldsFilled()
        {
            return textLibelle.Text != "";
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (FieldsFilled())
            {
                var selectedObject = dataGridView1.CurrentRow.DataBoundItem as Classe;
                using (var db = new DbScolaireContext())
                {
                    var result = db.Classes.FirstOrDefault(c => c.ID == selectedObject.ID);
                    if(result != null)
                    {
                        result.Libelle = textLibelle.Text;
                        db.Classes.AddOrUpdate(result);
                        db.SaveChanges();
                        ClearFields();
                        MessageBox.Show(
                            "Classe modifiée avec succès",
                            "",
                            MessageBoxButtons.OK
                        

                            );
                        refresh();

                    }
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var selectedObject = dataGridView1.CurrentRow.DataBoundItem as Classe;
                textLibelle.Text = selectedObject.Libelle;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedObject = dataGridView1.CurrentRow.DataBoundItem as Classe;
                using (var db = new DbScolaireContext())
                {
                    var result = db.Classes.SingleOrDefault(c => c.ID == selectedObject.ID);

                    if(result != null)
                    {
                        List<Etudiant> etudiants = db.Etudiants.Where(et => et.IdClasse == result.ID).ToList();
                        if (etudiants.Count() == 0)
                        {
                            db.Classes.Remove(result);
                            db.SaveChanges();
                            MessageBox.Show(
                                    "Classe supprimé avec succès",
                                    "",
                                    MessageBoxButtons.OK


                                    );
                            ClearFields();
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Cette classe ne peut pas etre supprimée car elle contient des étudiants",
                                "",
                                MessageBoxButtons.OK

                                );
                        }
                    }

                }

            }
        }
    }
}
