﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CaballoForm : Form
    {
        public CaballoForm()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            this.Close();
            principal.Show();
        }
    }
}
