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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listeÉtudianToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formEtudiant = new EtudiantForm();
            formEtudiant.Show();
            formEtudiant.MdiParent = this;
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formClasse = new FormClasse();
            formClasse.Show();
            formClasse.MdiParent = this;
        }
    }
}
