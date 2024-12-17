using ProyectoFinal_PapasDonuteria.Properties;

namespace ProyectoFinal_PapasDonuteria
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            buttonInicio = new Button();
            textBoxUsuario = new TextBox();
            txtPassword = new TextBox();
            btnInvitado = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonInicio
            // 
            buttonInicio.Location = new Point(338, 394);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(125, 30);
            buttonInicio.TabIndex = 0;
            buttonInicio.Text = "Iniciar Sesion";
            buttonInicio.UseVisualStyleBackColor = true;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(275, 278);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Usuario";
            textBoxUsuario.Size = new Size(250, 23);
            textBoxUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(275, 307);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(250, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnInvitado
            // 
            btnInvitado.Location = new Point(326, 339);
            btnInvitado.Name = "btnInvitado";
            btnInvitado.Size = new Size(148, 46);
            btnInvitado.TabIndex = 3;
            btnInvitado.Text = "Acceder como Invitado";
            btnInvitado.UseVisualStyleBackColor = true;
            btnInvitado.Click += btnInvitado_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(119, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 220, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnInvitado);
            Controls.Add(txtPassword);
            Controls.Add(textBoxUsuario);
            Controls.Add(buttonInicio);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInicio;
        private TextBox textBoxUsuario;
        private TextBox txtPassword;
        private Button btnInvitado;
        private PictureBox pictureBox1;
    }
}