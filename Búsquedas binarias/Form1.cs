using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Búsquedas_binarias
{
    public partial class Form1 : Form
    {

        Vector vector;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            vector = new Vector(Convert.ToInt32(txtSize.Text));
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            vector.Fill(Convert.ToInt32(txtLimit.Text));
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            vector.Sort();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtShow.Text = vector.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int found = vector.Search(Convert.ToInt32(txtSearch.Text));
            txtShow.Text = (found > -1) ? "Número encontrado" : "Número no encontrado";
            txtShow.Text += Environment.NewLine + vector.GetComparaciones().ToString() + " comparaciones";
        }
    }
}