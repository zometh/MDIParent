﻿using MBIParent.entities;
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
    public partial class RapportClasse : Form
    {
        public RapportClasse()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RapportClasse_Load(object sender, EventArgs e)
        {
            using (var db = new DbScolaireContext())
            {
                dataGridView1.DataSource = db.Classes.ToList();
            }
        }
    }
}
