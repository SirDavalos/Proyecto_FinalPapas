namespace ProyectoFinal_PapasDonuteria
{
    partial class FormAdmin
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
            btnAgregar = new Button();
            btnVerLista = new Button();
            btnEliminar = new Button();
            lblSalir = new Button();
            groupBoxProductos = new GroupBox();
            panel1 = new Panel();
            lblNombreAdmin = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonLogOut = new Button();
            labelUsuario = new Label();
            groupBoxProductos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(25, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 44);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVerLista
            // 
            btnVerLista.Location = new Point(25, 98);
            btnVerLista.Name = "btnVerLista";
            btnVerLista.Size = new Size(114, 44);
            btnVerLista.TabIndex = 3;
            btnVerLista.Text = "Ver lista de Productos";
            btnVerLista.UseVisualStyleBackColor = true;
            btnVerLista.Click += btnVerLista_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(242, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 44);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblSalir
            // 
            lblSalir.Location = new Point(242, 98);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(114, 44);
            lblSalir.TabIndex = 5;
            lblSalir.Text = "Salir";
            lblSalir.UseVisualStyleBackColor = true;
            lblSalir.Click += lblSalir_Click;
            // 
            // groupBoxProductos
            // 
            groupBoxProductos.Controls.Add(btnEliminar);
            groupBoxProductos.Controls.Add(lblSalir);
            groupBoxProductos.Controls.Add(btnVerLista);
            groupBoxProductos.Controls.Add(btnAgregar);
            groupBoxProductos.Location = new Point(303, 140);
            groupBoxProductos.Name = "groupBoxProductos";
            groupBoxProductos.Size = new Size(379, 157);
            groupBoxProductos.TabIndex = 6;
            groupBoxProductos.TabStop = false;
            groupBoxProductos.Text = "Productos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 220, 255);
            panel1.Controls.Add(lblNombreAdmin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonLogOut);
            panel1.Controls.Add(labelUsuario);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 84);
            panel1.TabIndex = 25;
            // 
            // lblNombreAdmin
            // 
            lblNombreAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNombreAdmin.AutoSize = true;
            lblNombreAdmin.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreAdmin.Location = new Point(824, 30);
            lblNombreAdmin.Name = "lblNombreAdmin";
            lblNombreAdmin.RightToLeft = RightToLeft.No;
            lblNombreAdmin.Size = new Size(64, 18);
            lblNombreAdmin.TabIndex = 22;
            lblNombreAdmin.Text = "usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 41);
            label3.Name = "label3";
            label3.Size = new Size(300, 22);
            label3.TabIndex = 21;
            label3.Text = "Elige, personaliza y disfruta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(194, 11);
            label1.Name = "label1";
            label1.Size = new Size(272, 30);
            label1.TabIndex = 20;
            label1.Text = "PAPA'S DONUTERIA";
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
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Location = new Point(894, 24);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(74, 30);
            buttonLogOut.TabIndex = 18;
            buttonLogOut.Text = "log out";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(1629, 31);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.RightToLeft = RightToLeft.No;
            labelUsuario.Size = new Size(64, 18);
            labelUsuario.TabIndex = 17;
            labelUsuario.Text = "usuario";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 371);
            Controls.Add(panel1);
            Controls.Add(groupBoxProductos);
            Name = "FormAdmin";
            Text = "Menu de Admin";
            groupBoxProductos.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregar;
        private Button btnVerLista;
        private Button btnEliminar;
        private Button lblSalir;
        private GroupBox groupBoxProductos;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonLogOut;
        private Label labelUsuario;
        private Label lblNombreAdmin;
    }
}