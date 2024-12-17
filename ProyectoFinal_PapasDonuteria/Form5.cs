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
    public partial class FormMetPago : Form
    {
        double pagoTotal;
        public FormMetPago(double pagoTotal, string datos)
        {
            InitializeComponent();
            this.pagoTotal = pagoTotal;
            textBoxTotal.Text = Convert.ToString(pagoTotal);
            textBoxDonas.Text = datos;
        }

        private void buttonEfec_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
            this.Show();
        }

        private void buttonTarj_Click(object sender, EventArgs e)
        {
            FormPagoTarjeta form7 = new FormPagoTarjeta(this.pagoTotal);
            this.Hide();
            form7.ShowDialog();
            this.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this.pagoTotal);
            this.Hide();
            form8.ShowDialog();
            this.Show();
        }
    }
}
