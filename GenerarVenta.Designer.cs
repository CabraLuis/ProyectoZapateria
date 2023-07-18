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
            this.btnGenerarVenta = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnRegisProveedor = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerarVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerarVenta.BackgroundImage")));
            this.btnGenerarVenta.Font = new System.Drawing.Font("212 Baby Girl", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGenerarVenta.Location = new System.Drawing.Point(100, 26);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(133, 89);
            this.btnGenerarVenta.TabIndex = 0;
            this.btnGenerarVenta.Text = "Generar Venta";
            this.btnGenerarVenta.UseVisualStyleBackColor = false;
            this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click_1);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Aqua;
            this.btnInventario.Font = new System.Drawing.Font("212 Baby Girl", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnInventario.Location = new System.Drawing.Point(100, 121);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(133, 46);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnRegisProveedor
            // 
            this.btnRegisProveedor.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRegisProveedor.Font = new System.Drawing.Font("212 Baby Girl", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRegisProveedor.Location = new System.Drawing.Point(100, 173);
            this.btnRegisProveedor.Name = "btnRegisProveedor";
            this.btnRegisProveedor.Size = new System.Drawing.Size(133, 91);
            this.btnRegisProveedor.TabIndex = 2;
            this.btnRegisProveedor.Text = "Registrar Proveedor";
            this.btnRegisProveedor.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("212 Baby Girl", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(100, 270);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 62);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("212 Baby Girl", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(222, 26);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(0, 30);
            this.lblBienvenido.TabIndex = 4;
            // 
            // GenerarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(318, 459);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegisProveedor);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnGenerarVenta);
            this.Name = "GenerarVenta";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerarVenta;
        private Button btnInventario;
        private Button btnRegisProveedor;
        private Button btnSalir;
        private Label lblBienvenido;
    }
}