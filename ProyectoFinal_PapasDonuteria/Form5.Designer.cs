namespace ProyectoFinal_PapasDonuteria
{
    partial class FormMetPago
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBoxTotal = new TextBox();
            textBoxDonas = new TextBox();
            groupBox2 = new GroupBox();
            btnEfectivo = new Button();
            buttonTarj = new Button();
            buttonEfec = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            labelUsuario = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 110);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "Datos de la compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(374, 110);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 1;
            label2.Text = "Métodos de pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 27);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 2;
            label3.Text = "Informacion de donas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 229);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Total a pagar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTotal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxDonas);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(18, 134);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(252, 265);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(136, 229);
            textBoxTotal.Margin = new Padding(3, 2, 3, 2);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(110, 23);
            textBoxTotal.TabIndex = 9;
            // 
            // textBoxDonas
            // 
            textBoxDonas.Location = new Point(5, 44);
            textBoxDonas.Margin = new Padding(3, 2, 3, 2);
            textBoxDonas.Multiline = true;
            textBoxDonas.Name = "textBoxDonas";
            textBoxDonas.ReadOnly = true;
            textBoxDonas.Size = new Size(241, 170);
            textBoxDonas.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEfectivo);
            groupBox2.Controls.Add(buttonTarj);
            groupBox2.Controls.Add(buttonEfec);
            groupBox2.Location = new Point(374, 134);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(140, 233);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // btnEfectivo
            // 
            btnEfectivo.BackColor = Color.FromArgb(255, 220, 255);
            btnEfectivo.Location = new Point(16, 162);
            btnEfectivo.Margin = new Padding(3, 2, 3, 2);
            btnEfectivo.Name = "btnEfectivo";
            btnEfectivo.Size = new Size(105, 52);
            btnEfectivo.TabIndex = 2;
            btnEfectivo.Text = "Efectivo";
            btnEfectivo.UseVisualStyleBackColor = false;
            btnEfectivo.Click += btnEfectivo_Click;
            // 
            // buttonTarj
            // 
            buttonTarj.BackColor = Color.FromArgb(255, 220, 255);
            buttonTarj.Location = new Point(16, 94);
            buttonTarj.Margin = new Padding(3, 2, 3, 2);
            buttonTarj.Name = "buttonTarj";
            buttonTarj.Size = new Size(105, 52);
            buttonTarj.TabIndex = 1;
            buttonTarj.Text = "Tarjeta";
            buttonTarj.UseVisualStyleBackColor = false;
            buttonTarj.Click += buttonTarj_Click;
            // 
            // buttonEfec
            // 
            buttonEfec.BackColor = Color.FromArgb(255, 220, 255);
            buttonEfec.Location = new Point(16, 26);
            buttonEfec.Margin = new Padding(3, 2, 3, 2);
            buttonEfec.Name = "buttonEfec";
            buttonEfec.Size = new Size(105, 52);
            buttonEfec.TabIndex = 0;
            buttonEfec.Text = "Oxxo";
            buttonEfec.UseVisualStyleBackColor = false;
            buttonEfec.Click += buttonEfec_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 220, 255);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 80);
            panel1.TabIndex = 20;
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
            labelUsuario.Location = new Point(1293, 31);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(64, 18);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "usuario";
            // 
            // FormMetPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 429);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMetPago";
            Text = "Form5";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxTotal;
        private TextBox textBoxDonas;
        private Button buttonTarj;
        private Button buttonEfec;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Label labelUsuario;
        private Button btnEfectivo;
    }
}