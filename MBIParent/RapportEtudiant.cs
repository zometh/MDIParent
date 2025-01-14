using MBIParent.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBIParent
{
    public partial class RapportEtudiant : Form
    {
        public RapportEtudiant()
        {
            InitializeComponent();
        }

        private void RapportEtudiant_Load(object sender, EventArgs e)
        {
            using(var db = new DbScolaireContext())
            {
                dataGridView1.DataSource = db.Etudiants.Select(
               et => new ViewEtudiant
               {
                   Prenom = et.Prenom,
                   Classe = et.Classe.Libelle,
                   Nom = et.Nom,
                   Id = et.ID,

               }
               ).ToList();
            }
        }
    }
}
