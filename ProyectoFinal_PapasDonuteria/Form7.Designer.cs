namespace ProyectoFinal_PapasDonuteria
{
    partial class FormPagoTarjeta
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonPagar = new Button();
            textBoxPin = new TextBox();
            label4 = new Label();
            textBoxAnio = new TextBox();
            textBoxMes = new TextBox();
            textBoxNumTarj = new TextBox();
            textBoxNom = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            labelUsuario = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonPagar);
            groupBox1.Controls.Add(textBoxPin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxAnio);
            groupBox1.Controls.Add(textBoxMes);
            groupBox1.Controls.Add(textBoxNumTarj);
            groupBox1.Controls.Add(textBoxNom);
            groupBox1.Location = new Point(121, 118);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(376, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 91);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha de vencimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 64);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 7;
            label2.Text = "Numero de tarjeta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre en la tarjeta";
            // 
            // buttonPagar
            // 
            buttonPagar.Location = new Point(147, 168);
            buttonPagar.Margin = new Padding(3, 2, 3, 2);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(82, 22);
            buttonPagar.TabIndex = 1;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = true;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // textBoxPin
            // 
            textBoxPin.Location = new Point(178, 115);
            textBoxPin.Margin = new Padding(3, 2, 3, 2);
            textBoxPin.MaxLength = 4;
            textBoxPin.Name = "textBoxPin";
            textBoxPin.PlaceholderText = "xxxx";
            textBoxPin.Size = new Size(110, 23);
            textBoxPin.TabIndex = 5;
            textBoxPin.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 118);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 4;
            label4.Text = "PIN";
            // 
            // textBoxAnio
            // 
            textBoxAnio.Location = new Point(242, 88);
            textBoxAnio.Margin = new Padding(3, 2, 3, 2);
            textBoxAnio.MaxLength = 4;
            textBoxAnio.Name = "textBoxAnio";
            textBoxAnio.PlaceholderText = "yyyy";
            textBoxAnio.Size = new Size(87, 23);
            textBoxAnio.TabIndex = 4;
            textBoxAnio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxMes
            // 
            textBoxMes.Location = new Point(178, 88);
            textBoxMes.Margin = new Padding(3, 2, 3, 2);
            textBoxMes.MaxLength = 2;
            textBoxMes.Name = "textBoxMes";
            textBoxMes.PlaceholderText = "mm";
            textBoxMes.Size = new Size(59, 23);
            textBoxMes.TabIndex = 3;
            textBoxMes.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNumTarj
            // 
            textBoxNumTarj.Location = new Point(178, 61);
            textBoxNumTarj.Margin = new Padding(3, 2, 3, 2);
            textBoxNumTarj.MaxLength = 16;
            textBoxNumTarj.Name = "textBoxNumTarj";
            textBoxNumTarj.PlaceholderText = "xxxx-xxxx-xxxx-xxxx";
            textBoxNumTarj.Size = new Size(151, 23);
            textBoxNumTarj.TabIndex = 2;
            textBoxNumTarj.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(178, 34);
            textBoxNom.Margin = new Padding(3, 2, 3, 2);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.PlaceholderText = "Nombre";
            textBoxNom.Size = new Size(184, 23);
            textBoxNom.TabIndex = 1;
            textBoxNom.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 220, 255);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 80);
            panel1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(194, 41);
            label6.Name = "label6";
            label6.Size = new Size(290, 22);
            label6.TabIndex = 21;
            label6.Text = "Elige, personaliza y difruta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(194, 11);
            label7.Name = "label7";
            label7.Size = new Size(272, 30);
            label7.TabIndex = 20;
            label7.Text = "PAPA'S DONUTERIA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(10, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(1712, 31);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(64, 18);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "usuario";
            // 
            // FormPagoTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 389);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPagoTarjeta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pago con Tarjeta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonPagar;
        private TextBox textBoxPin;
        private Label label4;
        private TextBox textBoxAnio;
        private TextBox textBoxMes;
        private TextBox textBoxNumTarj;
        private TextBox textBoxNom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Label labelUsuario;
    }
}