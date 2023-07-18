namespace ProyectoZapateria
{
    partial class RegistroProveedor
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
            this.grpDatosProveedor = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radEliminarProveedor = new System.Windows.Forms.RadioButton();
            this.radActualizarProveedor = new System.Windows.Forms.RadioButton();
            this.radAgregarProveedor = new System.Windows.Forms.RadioButton();
            this.dtgDatosProveedores = new System.Windows.Forms.DataGridView();
            this.dtgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosProveedor
            // 
            this.grpDatosProveedor.BackgroundImage = global::ProyectoZapateria.Properties.Resources.FondoTenis51;
            this.grpDatosProveedor.Controls.Add(this.btnSalir);
            this.grpDatosProveedor.Controls.Add(this.btnInicio);
            this.grpDatosProveedor.Controls.Add(this.btnAccion);
            this.grpDatosProveedor.Controls.Add(this.txtDireccion);
            this.grpDatosProveedor.Controls.Add(this.label3);
            this.grpDatosProveedor.Controls.Add(this.textBox1);
            this.grpDatosProveedor.Controls.Add(this.label2);
            this.grpDatosProveedor.Controls.Add(this.txtNombre);
            this.grpDatosProveedor.Controls.Add(this.label1);
            this.grpDatosProveedor.Controls.Add(this.radEliminarProveedor);
            this.grpDatosProveedor.Controls.Add(this.radActualizarProveedor);
            this.grpDatosProveedor.Controls.Add(this.radAgregarProveedor);
            this.grpDatosProveedor.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDatosProveedor.ForeColor = System.Drawing.Color.Lime;
            this.grpDatosProveedor.Location = new System.Drawing.Point(12, 12);
            this.grpDatosProveedor.Name = "grpDatosProveedor";
            this.grpDatosProveedor.Size = new System.Drawing.Size(595, 316);
            this.grpDatosProveedor.TabIndex = 0;
            this.grpDatosProveedor.TabStop = false;
            this.grpDatosProveedor.Text = "Datos Proveedores:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(260, 269);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Black;
            this.btnInicio.Location = new System.Drawing.Point(22, 269);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(94, 29);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnAccion
            // 
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccion.Location = new System.Drawing.Point(95, 207);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(213, 35);
            this.btnAccion.TabIndex = 5;
            this.btnAccion.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(124, 174);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(184, 29);
            this.txtDireccion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Direccion:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 29);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 29);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // radEliminarProveedor
            // 
            this.radEliminarProveedor.Appearance = System.Windows.Forms.Appearance.Button;
            this.radEliminarProveedor.AutoSize = true;
            this.radEliminarProveedor.BackColor = System.Drawing.Color.Black;
            this.radEliminarProveedor.Location = new System.Drawing.Point(403, 44);
            this.radEliminarProveedor.Name = "radEliminarProveedor";
            this.radEliminarProveedor.Size = new System.Drawing.Size(174, 32);
            this.radEliminarProveedor.TabIndex = 1;
            this.radEliminarProveedor.TabStop = true;
            this.radEliminarProveedor.Text = "Eliminar Proveedor";
            this.radEliminarProveedor.UseVisualStyleBackColor = false;
            // 
            // radActualizarProveedor
            // 
            this.radActualizarProveedor.Appearance = System.Windows.Forms.Appearance.Button;
            this.radActualizarProveedor.AutoSize = true;
            this.radActualizarProveedor.BackColor = System.Drawing.Color.Black;
            this.radActualizarProveedor.Location = new System.Drawing.Point(204, 44);
            this.radActualizarProveedor.Name = "radActualizarProveedor";
            this.radActualizarProveedor.Size = new System.Drawing.Size(179, 32);
            this.radActualizarProveedor.TabIndex = 1;
            this.radActualizarProveedor.Text = "ModificarProveedor";
            this.radActualizarProveedor.UseVisualStyleBackColor = false;
            // 
            // radAgregarProveedor
            // 
            this.radAgregarProveedor.Appearance = System.Windows.Forms.Appearance.Button;
            this.radAgregarProveedor.AutoSize = true;
            this.radAgregarProveedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radAgregarProveedor.Checked = true;
            this.radAgregarProveedor.Location = new System.Drawing.Point(6, 44);
            this.radAgregarProveedor.Name = "radAgregarProveedor";
            this.radAgregarProveedor.Size = new System.Drawing.Size(176, 32);
            this.radAgregarProveedor.TabIndex = 1;
            this.radAgregarProveedor.TabStop = true;
            this.radAgregarProveedor.Text = "Agregar Proveedor";
            this.radAgregarProveedor.UseVisualStyleBackColor = false;
            // 
            // dtgDatosProveedores
            // 
            this.dtgDatosProveedores.AllowUserToAddRows = false;
            this.dtgDatosProveedores.AllowUserToDeleteRows = false;
            this.dtgDatosProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgcID,
            this.dtgcNombre,
            this.dtgcTelefono,
            this.dtgcDireccion});
            this.dtgDatosProveedores.Location = new System.Drawing.Point(613, 12);
            this.dtgDatosProveedores.Name = "dtgDatosProveedores";
            this.dtgDatosProveedores.ReadOnly = true;
            this.dtgDatosProveedores.RowHeadersWidth = 51;
            this.dtgDatosProveedores.RowTemplate.Height = 29;
            this.dtgDatosProveedores.Size = new System.Drawing.Size(566, 316);
            this.dtgDatosProveedores.TabIndex = 1;
            // 
            // dtgcID
            // 
            this.dtgcID.HeaderText = "IDProveedor";
            this.dtgcID.MinimumWidth = 6;
            this.dtgcID.Name = "dtgcID";
            this.dtgcID.ReadOnly = true;
            this.dtgcID.Width = 125;
            // 
            // dtgcNombre
            // 
            this.dtgcNombre.HeaderText = "Nombre";
            this.dtgcNombre.MinimumWidth = 6;
            this.dtgcNombre.Name = "dtgcNombre";
            this.dtgcNombre.ReadOnly = true;
            this.dtgcNombre.Width = 125;
            // 
            // dtgcTelefono
            // 
            this.dtgcTelefono.HeaderText = "Telefono";
            this.dtgcTelefono.MinimumWidth = 6;
            this.dtgcTelefono.Name = "dtgcTelefono";
            this.dtgcTelefono.ReadOnly = true;
            this.dtgcTelefono.Width = 125;
            // 
            // dtgcDireccion
            // 
            this.dtgcDireccion.HeaderText = "Direccion";
            this.dtgcDireccion.MinimumWidth = 6;
            this.dtgcDireccion.Name = "dtgcDireccion";
            this.dtgcDireccion.ReadOnly = true;
            this.dtgcDireccion.Width = 125;
            // 
            // RegistroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoZapateria.Properties.Resources.FondoTenis52;
            this.ClientSize = new System.Drawing.Size(1191, 331);
            this.Controls.Add(this.dtgDatosProveedores);
            this.Controls.Add(this.grpDatosProveedor);
            this.Name = "RegistroProveedor";
            this.Text = "RegistroProveedor";
            this.grpDatosProveedor.ResumeLayout(false);
            this.grpDatosProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpDatosProveedor;
        private Label label1;
        private RadioButton radEliminarProveedor;
        private RadioButton radActualizarProveedor;
        private RadioButton radAgregarProveedor;
        private Button btnAccion;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtNombre;
        private DataGridView dtgDatosProveedores;
        private DataGridViewTextBoxColumn dtgcID;
        private DataGridViewTextBoxColumn dtgcNombre;
        private DataGridViewTextBoxColumn dtgcTelefono;
        private DataGridViewTextBoxColumn dtgcDireccion;
        private Button btnSalir;
        private Button btnInicio;
    }
}