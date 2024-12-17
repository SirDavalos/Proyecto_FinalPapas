namespace ProyectoFinal_PapasDonuteria
{
    partial class Form8
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
            textBoxcambio = new TextBox();
            textBoxRecibo = new TextBox();
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
            groupBox1.Controls.Add(textBoxcambio);
            groupBox1.Controls.Add(textBoxRecibo);
            groupBox1.Controls.Add(textBoxNom);
            groupBox1.Location = new Point(90, 100);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(376, 228);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 84);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 8;
            label3.Text = "Cambio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 62);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 7;
            label2.Text = "Recibo la cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 6;
            label1.Text = "Total a pagar";
            // 
            // buttonPagar
            // 
            buttonPagar.Location = new Point(300, 59);
            buttonPagar.Margin = new Padding(3, 2, 3, 2);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(71, 22);
            buttonPagar.TabIndex = 1;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = true;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // textBoxcambio
            // 
            textBoxcambio.Location = new Point(178, 84);
            textBoxcambio.Margin = new Padding(3, 2, 3, 2);
            textBoxcambio.Name = "textBoxcambio";
            textBoxcambio.Size = new Size(118, 23);
            textBoxcambio.TabIndex = 3;
            textBoxcambio.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxRecibo
            // 
            textBoxRecibo.Location = new Point(178, 59);
            textBoxRecibo.Margin = new Padding(3, 2, 3, 2);
            textBoxRecibo.Name = "textBoxRecibo";
            textBoxRecibo.Size = new Size(118, 23);
            textBoxRecibo.TabIndex = 2;
            textBoxRecibo.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNom
            // 
            textBoxNom.Enabled = false;
            textBoxNom.Location = new Point(178, 34);
            textBoxNom.Margin = new Padding(3, 2, 3, 2);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.ReadOnly = true;
            textBoxNom.Size = new Size(118, 23);
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
            panel1.Size = new Size(619, 89);
            panel1.TabIndex = 22;
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
            labelUsuario.Location = new Point(2156, 31);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(64, 18);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "usuario";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 338);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form8";
            Text = "Form8";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonPagar;
        private TextBox textBoxcambio;
        private TextBox textBoxRecibo;
        private TextBox textBoxNom;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Label labelUsuario;
    }
}