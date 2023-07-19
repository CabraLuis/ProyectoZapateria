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
            grpDatosProveedor = new GroupBox();
            btnSalir = new Button();
            btnInicio = new Button();
            btnAccion = new Button();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            radEliminarProveedor = new RadioButton();
            radActualizarProveedor = new RadioButton();
            radAgregarProveedor = new RadioButton();
            dtgDatosProveedores = new DataGridView();
            dtgcID = new DataGridViewTextBoxColumn();
            dtgcNombre = new DataGridViewTextBoxColumn();
            dtgcTelefono = new DataGridViewTextBoxColumn();
            dtgcDireccion = new DataGridViewTextBoxColumn();
            grpDatosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatosProveedores).BeginInit();
            SuspendLayout();
            // 
            // grpDatosProveedor
            // 
            grpDatosProveedor.Controls.Add(btnSalir);
            grpDatosProveedor.Controls.Add(btnInicio);
            grpDatosProveedor.Controls.Add(btnAccion);
            grpDatosProveedor.Controls.Add(txtDireccion);
            grpDatosProveedor.Controls.Add(label3);
            grpDatosProveedor.Controls.Add(txtTelefono);
            grpDatosProveedor.Controls.Add(label2);
            grpDatosProveedor.Controls.Add(txtNombre);
            grpDatosProveedor.Controls.Add(label1);
            grpDatosProveedor.Controls.Add(radEliminarProveedor);
            grpDatosProveedor.Controls.Add(radActualizarProveedor);
            grpDatosProveedor.Controls.Add(radAgregarProveedor);
            grpDatosProveedor.Location = new Point(12, 12);
            grpDatosProveedor.Name = "grpDatosProveedor";
            grpDatosProveedor.Size = new Size(470, 316);
            grpDatosProveedor.TabIndex = 0;
            grpDatosProveedor.TabStop = false;
            grpDatosProveedor.Text = "Datos Proveedores:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(260, 269);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(22, 269);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(94, 29);
            btnInicio.TabIndex = 6;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnAccion
            // 
            btnAccion.FlatStyle = FlatStyle.Popup;
            btnAccion.Location = new Point(95, 207);
            btnAccion.Name = "btnAccion";
            btnAccion.Size = new Size(213, 35);
            btnAccion.TabIndex = 5;
            btnAccion.UseVisualStyleBackColor = true;
            btnAccion.Click += btnAccion_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(124, 174);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(184, 27);
            txtDireccion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 177);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 1;
            label3.Text = "Direccion:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(124, 131);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 138);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 105);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // radEliminarProveedor
            // 
            radEliminarProveedor.Appearance = Appearance.Button;
            radEliminarProveedor.AutoSize = true;
            radEliminarProveedor.Location = new Point(314, 44);
            radEliminarProveedor.Name = "radEliminarProveedor";
            radEliminarProveedor.Size = new Size(145, 30);
            radEliminarProveedor.TabIndex = 1;
            radEliminarProveedor.TabStop = true;
            radEliminarProveedor.Text = "Eliminar Proveedor";
            radEliminarProveedor.UseVisualStyleBackColor = true;
            radEliminarProveedor.CheckedChanged += radEliminarProveedor_CheckedChanged;
            // 
            // radActualizarProveedor
            // 
            radActualizarProveedor.Appearance = Appearance.Button;
            radActualizarProveedor.AutoSize = true;
            radActualizarProveedor.Location = new Point(157, 44);
            radActualizarProveedor.Name = "radActualizarProveedor";
            radActualizarProveedor.Size = new Size(151, 30);
            radActualizarProveedor.TabIndex = 1;
            radActualizarProveedor.Text = "ModificarProveedor";
            radActualizarProveedor.UseVisualStyleBackColor = true;
            radActualizarProveedor.CheckedChanged += radActualizarProveedor_CheckedChanged;
            // 
            // radAgregarProveedor
            // 
            radAgregarProveedor.Appearance = Appearance.Button;
            radAgregarProveedor.AutoSize = true;
            radAgregarProveedor.Checked = true;
            radAgregarProveedor.Location = new Point(6, 44);
            radAgregarProveedor.Name = "radAgregarProveedor";
            radAgregarProveedor.Size = new Size(145, 30);
            radAgregarProveedor.TabIndex = 1;
            radAgregarProveedor.TabStop = true;
            radAgregarProveedor.Text = "Agregar Proveedor";
            radAgregarProveedor.UseVisualStyleBackColor = true;
            radAgregarProveedor.CheckedChanged += radAgregarProveedor_CheckedChanged;
            // 
            // dtgDatosProveedores
            // 
            dtgDatosProveedores.AllowUserToAddRows = false;
            dtgDatosProveedores.AllowUserToDeleteRows = false;
            dtgDatosProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatosProveedores.Columns.AddRange(new DataGridViewColumn[] { dtgcID, dtgcNombre, dtgcTelefono, dtgcDireccion });
            dtgDatosProveedores.Location = new Point(500, 12);
            dtgDatosProveedores.Name = "dtgDatosProveedores";
            dtgDatosProveedores.ReadOnly = true;
            dtgDatosProveedores.RowHeadersWidth = 51;
            dtgDatosProveedores.RowTemplate.Height = 29;
            dtgDatosProveedores.Size = new Size(566, 316);
            dtgDatosProveedores.TabIndex = 1;
            // 
            // dtgcID
            // 
            dtgcID.HeaderText = "IDProveedor";
            dtgcID.MinimumWidth = 6;
            dtgcID.Name = "dtgcID";
            dtgcID.ReadOnly = true;
            dtgcID.Width = 125;
            // 
            // dtgcNombre
            // 
            dtgcNombre.HeaderText = "Nombre";
            dtgcNombre.MinimumWidth = 6;
            dtgcNombre.Name = "dtgcNombre";
            dtgcNombre.ReadOnly = true;
            dtgcNombre.Width = 125;
            // 
            // dtgcTelefono
            // 
            dtgcTelefono.HeaderText = "Telefono";
            dtgcTelefono.MinimumWidth = 6;
            dtgcTelefono.Name = "dtgcTelefono";
            dtgcTelefono.ReadOnly = true;
            dtgcTelefono.Width = 125;
            // 
            // dtgcDireccion
            // 
            dtgcDireccion.HeaderText = "Direccion";
            dtgcDireccion.MinimumWidth = 6;
            dtgcDireccion.Name = "dtgcDireccion";
            dtgcDireccion.ReadOnly = true;
            dtgcDireccion.Width = 125;
            // 
            // RegistroProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 331);
            Controls.Add(dtgDatosProveedores);
            Controls.Add(grpDatosProveedor);
            Name = "RegistroProveedor";
            Text = "RegistroProveedor";
            Load += RegistroProveedor_Load;
            grpDatosProveedor.ResumeLayout(false);
            grpDatosProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatosProveedores).EndInit();
            ResumeLayout(false);
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
        private TextBox txtTelefono;
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