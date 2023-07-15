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
            btnGenerarVenta = new Button();
            btnInventario = new Button();
            btnRegisProveedor = new Button();
            btnSalir = new Button();
            lblBienvenido = new Label();
            SuspendLayout();
            // 
            // btnGenerarVenta
            // 
            btnGenerarVenta.Location = new Point(93, 85);
            btnGenerarVenta.Name = "btnGenerarVenta";
            btnGenerarVenta.Size = new Size(96, 62);
            btnGenerarVenta.TabIndex = 0;
            btnGenerarVenta.Text = "Generar Venta";
            btnGenerarVenta.UseVisualStyleBackColor = true;
            btnGenerarVenta.Click += btnGenerarVenta_Click;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(222, 85);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(105, 62);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnRegisProveedor
            // 
            btnRegisProveedor.Location = new Point(351, 85);
            btnRegisProveedor.Name = "btnRegisProveedor";
            btnRegisProveedor.Size = new Size(103, 62);
            btnRegisProveedor.TabIndex = 2;
            btnRegisProveedor.Text = "Registrar Proveedor";
            btnRegisProveedor.UseVisualStyleBackColor = true;
            btnRegisProveedor.Click += btnRegisProveedor_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(482, 85);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 62);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Location = new Point(222, 26);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(0, 20);
            lblBienvenido.TabIndex = 4;
            // 
            // GenerarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 169);
            Controls.Add(lblBienvenido);
            Controls.Add(btnSalir);
            Controls.Add(btnRegisProveedor);
            Controls.Add(btnInventario);
            Controls.Add(btnGenerarVenta);
            Name = "GenerarVenta";
            Text = "Inicio";
            Load += GenerarVenta_Load;
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