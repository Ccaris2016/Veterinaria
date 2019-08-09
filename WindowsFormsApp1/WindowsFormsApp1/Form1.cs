using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Deseas salir?", "salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void Vaca_Click(object sender, EventArgs e)
        {
            VacaForm Vaca_f = new VacaForm();
            Vaca_f.Show();
            this.Hide();
        }
    }
}
