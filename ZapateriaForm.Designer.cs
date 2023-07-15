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
            SuspendLayout();
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(174, 79);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(125, 27);
            TxtUsuario.TabIndex = 0;
            // 
            // TxtContrasena
            // 
            TxtContrasena.Location = new Point(174, 127);
            TxtContrasena.Name = "TxtContrasena";
            TxtContrasena.Size = new Size(125, 27);
            TxtContrasena.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(82, 86);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(82, 134);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(86, 20);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(44, 172);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(253, 172);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(88, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(0, 20);
            lblBienvenida.TabIndex = 4;
            // 
            // ZapateriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 266);
            Controls.Add(lblBienvenida);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(TxtContrasena);
            Controls.Add(TxtUsuario);
            Name = "ZapateriaForm";
            Text = "Login";
            Load += ZapateriaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUsuario;
        private TextBox TxtContrasena;
        private Label lblUsuario;
        private Label lblContrasena;
        private Button btnIngresar;
        private Button btnSalir;
        private Label lblBienvenida;
    }
}