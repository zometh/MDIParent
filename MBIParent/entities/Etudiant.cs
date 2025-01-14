using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace MBIParent.entities
{
    internal class Etudiant
    {
        public int ID { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int IdClasse { get; set; }
        public Classe Classe { get; set; }
    }
    internal class ViewEtudiant
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public String Classe { get; set; }
   
    }
}
