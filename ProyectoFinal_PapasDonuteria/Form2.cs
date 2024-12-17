using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal_PapasDonuteria
{
    public partial class Form2 : Form
    {
        AdminBD connexion;
        public Form2()
        {
            InitializeComponent();
            this.connexion = new AdminBD();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string password = txtPassword.Text;
            Usuario user = this.connexion.buscarUsuario(usuario);

            if (this.connexion.inicioSesion(usuario, password))
            {
                if (user.Admin == true)
                {
                    FormAdmin formAdmin = new FormAdmin(usuario);
                    this.Hide();
                    formAdmin.ShowDialog();
                    this.Show();
                }
                else
                {
                    Form3 form3 = new Form3(usuario);
                    this.Hide();
                    form3.ShowDialog();
                    this.Show();
                }
            }
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            if (this.connexion.inicioSesion("invitado", ""))
            {
                    Form3 form3 = new Form3("invitado");
                    this.Hide();
                    form3.ShowDialog();
                    this.Show();
            }
        }
    }
}
