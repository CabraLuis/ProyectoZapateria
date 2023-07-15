namespace ProyectoZapateria
{
    partial class ZapateriaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtUsuario = new TextBox();
            TxtContrasena = new TextBox();
            lblUsuario = new Label();
            lblContrasena = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            lblBienvenida = new Label();
            grpInicioSesion = new GroupBox();
            grpInicioSesion.SuspendLayout();
            SuspendLayout();
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(221, 69);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(125, 27);
            TxtUsuario.TabIndex = 0;
            // 
            // TxtContrasena
            // 
            TxtContrasena.Location = new Point(221, 117);
            TxtContrasena.Name = "TxtContrasena";
            TxtContrasena.Size = new Size(125, 27);
            TxtContrasena.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(129, 76);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(129, 124);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(86, 20);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(91, 162);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(300, 162);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(129, 23);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(0, 20);
            lblBienvenida.TabIndex = 4;
            // 
            // grpInicioSesion
            // 
            grpInicioSesion.Controls.Add(btnSalir);
            grpInicioSesion.Controls.Add(lblBienvenida);
            grpInicioSesion.Controls.Add(TxtUsuario);
            grpInicioSesion.Controls.Add(TxtContrasena);
            grpInicioSesion.Controls.Add(btnIngresar);
            grpInicioSesion.Controls.Add(lblUsuario);
            grpInicioSesion.Controls.Add(lblContrasena);
            grpInicioSesion.Location = new Point(25, 12);
            grpInicioSesion.Name = "grpInicioSesion";
            grpInicioSesion.Size = new Size(521, 206);
            grpInicioSesion.TabIndex = 5;
            grpInicioSesion.TabStop = false;
            grpInicioSesion.Text = "Ingresar Datos:";
            // 
            // ZapateriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 233);
            Controls.Add(grpInicioSesion);
            Name = "ZapateriaForm";
            Text = "Login";
            Load += ZapateriaForm_Load;
            grpInicioSesion.ResumeLayout(false);
            grpInicioSesion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtUsuario;
        private TextBox TxtContrasena;
        private Label lblUsuario;
        private Label lblContrasena;
        private Button btnIngresar;
        private Button btnSalir;
        private Label lblBienvenida;
        private GroupBox grpInicioSesion;
    }
}