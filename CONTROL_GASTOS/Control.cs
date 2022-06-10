﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROL_GASTOS.Models;

namespace CONTROL_GASTOS
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            var obj = new CategoryManagement();
            obj.ShowDialog();
        }

        private void btnConceptManagement_Click(object sender, EventArgs e)
        {
            var obj = new ConceptManagement();
            obj.ShowDialog();
        }

    }
}