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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZapateriaForm));
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.grpInicioSesion = new System.Windows.Forms.GroupBox();
            this.grpInicioSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(221, 69);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(219, 43);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(221, 117);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(219, 43);
            this.TxtContrasena.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(69, 75);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(116, 37);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContrasena.Location = new System.Drawing.Point(17, 123);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(168, 37);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.Location = new System.Drawing.Point(42, 222);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(143, 45);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(301, 219);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(129, 23);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(0, 37);
            this.lblBienvenida.TabIndex = 4;
            // 
            // grpInicioSesion
            // 
            this.grpInicioSesion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpInicioSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpInicioSesion.BackgroundImage")));
            this.grpInicioSesion.Controls.Add(this.btnSalir);
            this.grpInicioSesion.Controls.Add(this.lblBienvenida);
            this.grpInicioSesion.Controls.Add(this.TxtUsuario);
            this.grpInicioSesion.Controls.Add(this.TxtContrasena);
            this.grpInicioSesion.Controls.Add(this.btnIngresar);
            this.grpInicioSesion.Controls.Add(this.lblUsuario);
            this.grpInicioSesion.Controls.Add(this.lblContrasena);
            this.grpInicioSesion.Font = new System.Drawing.Font("212 Baby Girl", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpInicioSesion.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.grpInicioSesion.Location = new System.Drawing.Point(12, 37);
            this.grpInicioSesion.Name = "grpInicioSesion";
            this.grpInicioSesion.Size = new System.Drawing.Size(521, 288);
            this.grpInicioSesion.TabIndex = 5;
            this.grpInicioSesion.TabStop = false;
            this.grpInicioSesion.Text = "Ingresar Datos:";
            // 
            // ZapateriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 436);
            this.Controls.Add(this.grpInicioSesion);
            this.Name = "ZapateriaForm";
            this.Text = "Login";
            this.grpInicioSesion.ResumeLayout(false);
            this.grpInicioSesion.PerformLayout();
            this.ResumeLayout(false);

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