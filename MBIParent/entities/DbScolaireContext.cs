using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MBIParent.entities
{
    internal class DbScolaireContext : DbContext
    {
        public DbScolaireContext() : base("ecoleConnect") { }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Classe> Classes { get; set; }
    }
}
