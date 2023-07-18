namespace ProyectoZapateria
{
    partial class GenerarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarVenta));
            btnGenerarVenta = new Button();
            btnInventario = new Button();
            btnRegisProveedor = new Button();
            btnSalir = new Button();
            lblBienvenido = new Label();
            SuspendLayout();
            // 
            // btnGenerarVenta
            // 
            btnGenerarVenta.BackColor = Color.DodgerBlue;
            btnGenerarVenta.BackgroundImage = (Image)resources.GetObject("btnGenerarVenta.BackgroundImage");
            btnGenerarVenta.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGenerarVenta.Location = new Point(100, 26);
            btnGenerarVenta.Name = "btnGenerarVenta";
            btnGenerarVenta.Size = new Size(133, 89);
            btnGenerarVenta.TabIndex = 0;
            btnGenerarVenta.Text = "Generar Venta";
            btnGenerarVenta.UseVisualStyleBackColor = false;
            btnGenerarVenta.Click += btnGenerarVenta_Click_1;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.Aqua;
            btnInventario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnInventario.Location = new Point(86, 121);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(147, 46);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnRegisProveedor
            // 
            btnRegisProveedor.BackColor = Color.SlateBlue;
            btnRegisProveedor.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegisProveedor.Location = new Point(86, 173);
            btnRegisProveedor.Name = "btnRegisProveedor";
            btnRegisProveedor.Size = new Size(151, 91);
            btnRegisProveedor.TabIndex = 2;
            btnRegisProveedor.Text = "Registrar Proveedor";
            btnRegisProveedor.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.Location = new Point(100, 270);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 62);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBienvenido.Location = new Point(222, 26);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(0, 29);
            lblBienvenido.TabIndex = 4;
            // 
            // GenerarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(318, 459);
            Controls.Add(lblBienvenido);
            Controls.Add(btnSalir);
            Controls.Add(btnRegisProveedor);
            Controls.Add(btnInventario);
            Controls.Add(btnGenerarVenta);
            Name = "GenerarVenta";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerarVenta;
        private Button btnInventario;
        private Button btnRegisProveedor;
        private Button btnSalir;
        private Label lblBienvenido;
    }
}