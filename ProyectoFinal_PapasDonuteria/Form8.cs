using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_PapasDonuteria
{
    public partial class Form8 : Form
    {
        double total;
        public Form8(double total)
        {
            InitializeComponent();
            this.total = total;
            textBoxNom.Text = total.ToString();
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            double recibido=double.Parse(textBoxRecibo.Text);
            double cambio = 0;
            cambio = recibido - total;
            textBoxcambio.Text = cambio.ToString();
        }
    }
}
