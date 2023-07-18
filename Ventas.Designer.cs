namespace ProyectoZapateria
{
    partial class Ventas
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
            System.Windows.Forms.Label lblHoraActual;
            this.grpDatosCalzado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.grpEmpleado = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.dtgcIDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcIDZapato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcTipoCalzado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcgTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblHoraActual = new System.Windows.Forms.Label();
            this.grpDatosCalzado.SuspendLayout();
            this.grpDatosCliente.SuspendLayout();
            this.grpEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoraActual
            // 
            lblHoraActual.AutoSize = true;
            lblHoraActual.BackColor = System.Drawing.SystemColors.Info;
            lblHoraActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblHoraActual.Location = new System.Drawing.Point(896, 34);
            lblHoraActual.Name = "lblHoraActual";
            lblHoraActual.Size = new System.Drawing.Size(2, 24);
            lblHoraActual.TabIndex = 5;
            // 
            // grpDatosCalzado
            // 
            this.grpDatosCalzado.BackgroundImage = global::ProyectoZapateria.Properties.Resources.FondoTenis11;
            this.grpDatosCalzado.Controls.Add(this.btnEliminar);
            this.grpDatosCalzado.Controls.Add(this.btnBuscar);
            this.grpDatosCalzado.Controls.Add(this.btnAgregar);
            this.grpDatosCalzado.Controls.Add(this.btnModificar);
            this.grpDatosCalzado.Controls.Add(this.txtTalla);
            this.grpDatosCalzado.Controls.Add(this.txtID);
            this.grpDatosCalzado.Controls.Add(this.txtCantidad);
            this.grpDatosCalzado.Controls.Add(this.cmbBusqueda);
            this.grpDatosCalzado.Controls.Add(this.label3);
            this.grpDatosCalzado.Controls.Add(this.label4);
            this.grpDatosCalzado.Controls.Add(this.label2);
            this.grpDatosCalzado.Controls.Add(this.label1);
            this.grpDatosCalzado.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDatosCalzado.Location = new System.Drawing.Point(12, 12);
            this.grpDatosCalzado.Name = "grpDatosCalzado";
            this.grpDatosCalzado.Size = new System.Drawing.Size(288, 331);
            this.grpDatosCalzado.TabIndex = 0;
            this.grpDatosCalzado.TabStop = false;
            this.grpDatosCalzado.Text = "Datos Calzado:";
            this.grpDatosCalzado.Enter += new System.EventHandler(this.grpDatosCalzado_Enter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(7, 281);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(268, 29);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(7, 246);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(268, 29);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(7, 211);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(268, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(7, 176);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(268, 29);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(124, 134);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(151, 29);
            this.txtTalla.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 29);
            this.txtID.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(124, 101);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(151, 29);
            this.txtCantidad.TabIndex = 1;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Location = new System.Drawing.Point(124, 26);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(151, 30);
            this.cmbBusqueda.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(19, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Talla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID o Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(19, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por:";
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpDatosCliente.BackgroundImage = global::ProyectoZapateria.Properties.Resources.FondoTenis2;
            this.grpDatosCliente.Controls.Add(this.txtDireccion);
            this.grpDatosCliente.Controls.Add(this.label8);
            this.grpDatosCliente.Controls.Add(this.txtApellido);
            this.grpDatosCliente.Controls.Add(this.label7);
            this.grpDatosCliente.Controls.Add(this.txtTelefono);
            this.grpDatosCliente.Controls.Add(this.label6);
            this.grpDatosCliente.Controls.Add(this.txtNombreCliente);
            this.grpDatosCliente.Controls.Add(this.label5);
            this.grpDatosCliente.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDatosCliente.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.grpDatosCliente.Location = new System.Drawing.Point(12, 349);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(288, 224);
            this.grpDatosCliente.TabIndex = 1;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos del cliente:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(110, 176);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(172, 29);
            this.txtDireccion.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Direccion";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 139);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 29);
            this.txtApellido.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(110, 89);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(125, 29);
            this.txtTelefono.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefono:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(110, 43);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(125, 29);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre:";
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRealizarVenta.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRealizarVenta.Location = new System.Drawing.Point(12, 579);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(288, 29);
            this.btnRealizarVenta.TabIndex = 2;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancelarVenta.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarVenta.Location = new System.Drawing.Point(12, 614);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(288, 29);
            this.btnCancelarVenta.TabIndex = 3;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // grpEmpleado
            // 
            this.grpEmpleado.BackColor = System.Drawing.Color.DimGray;
            this.grpEmpleado.BackgroundImage = global::ProyectoZapateria.Properties.Resources.FondoTenis3;
            this.grpEmpleado.Controls.Add(lblHoraActual);
            this.grpEmpleado.Controls.Add(this.label11);
            this.grpEmpleado.Controls.Add(this.lblFechaActual);
            this.grpEmpleado.Controls.Add(this.label10);
            this.grpEmpleado.Controls.Add(this.cmbEmpleados);
            this.grpEmpleado.Controls.Add(this.label9);
            this.grpEmpleado.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpEmpleado.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.grpEmpleado.Location = new System.Drawing.Point(318, 12);
            this.grpEmpleado.Name = "grpEmpleado";
            this.grpEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpEmpleado.Size = new System.Drawing.Size(1311, 69);
            this.grpEmpleado.TabIndex = 4;
            this.grpEmpleado.TabStop = false;
            this.grpEmpleado.Text = "Identificacion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(789, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "Hora Actual:";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaActual.Location = new System.Drawing.Point(703, 32);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(2, 24);
            this.lblFechaActual.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fecha Actual:";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(415, 29);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(151, 30);
            this.cmbEmpleados.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Empleado:";
            // 
            // dtgVentas
            // 
            this.dtgVentas.AllowUserToAddRows = false;
            this.dtgVentas.AllowUserToDeleteRows = false;
            this.dtgVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgcIDVenta,
            this.dtgcIDZapato,
            this.dtgcTipoCalzado,
            this.dtgcTalla,
            this.dtcNombreCliente,
            this.dtgcCantidad,
            this.dtgcSubtotal,
            this.dtcgTotal,
            this.dtcDescuento,
            this.dtgcEmpleado});
            this.dtgVentas.Location = new System.Drawing.Point(318, 99);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.ReadOnly = true;
            this.dtgVentas.RowHeadersWidth = 51;
            this.dtgVentas.RowTemplate.Height = 29;
            this.dtgVentas.Size = new System.Drawing.Size(1311, 544);
            this.dtgVentas.TabIndex = 5;
            // 
            // dtgcIDVenta
            // 
            this.dtgcIDVenta.HeaderText = "Num.Venta";
            this.dtgcIDVenta.MinimumWidth = 6;
            this.dtgcIDVenta.Name = "dtgcIDVenta";
            this.dtgcIDVenta.ReadOnly = true;
            this.dtgcIDVenta.Width = 125;
            // 
            // dtgcIDZapato
            // 
            this.dtgcIDZapato.HeaderText = "IDZapato";
            this.dtgcIDZapato.MinimumWidth = 6;
            this.dtgcIDZapato.Name = "dtgcIDZapato";
            this.dtgcIDZapato.ReadOnly = true;
            this.dtgcIDZapato.Width = 125;
            // 
            // dtgcTipoCalzado
            // 
            this.dtgcTipoCalzado.HeaderText = "TipoCalzado";
            this.dtgcTipoCalzado.MinimumWidth = 6;
            this.dtgcTipoCalzado.Name = "dtgcTipoCalzado";
            this.dtgcTipoCalzado.ReadOnly = true;
            this.dtgcTipoCalzado.Width = 125;
            // 
            // dtgcTalla
            // 
            this.dtgcTalla.HeaderText = "Talla";
            this.dtgcTalla.MinimumWidth = 6;
            this.dtgcTalla.Name = "dtgcTalla";
            this.dtgcTalla.ReadOnly = true;
            this.dtgcTalla.Width = 125;
            // 
            // dtcNombreCliente
            // 
            this.dtcNombreCliente.HeaderText = "NombreCliente";
            this.dtcNombreCliente.MinimumWidth = 6;
            this.dtcNombreCliente.Name = "dtcNombreCliente";
            this.dtcNombreCliente.ReadOnly = true;
            this.dtcNombreCliente.Width = 125;
            // 
            // dtgcCantidad
            // 
            this.dtgcCantidad.HeaderText = "Cantidad";
            this.dtgcCantidad.MinimumWidth = 6;
            this.dtgcCantidad.Name = "dtgcCantidad";
            this.dtgcCantidad.ReadOnly = true;
            this.dtgcCantidad.Width = 125;
            // 
            // dtgcSubtotal
            // 
            this.dtgcSubtotal.HeaderText = "Subtotal";
            this.dtgcSubtotal.MinimumWidth = 6;
            this.dtgcSubtotal.Name = "dtgcSubtotal";
            this.dtgcSubtotal.ReadOnly = true;
            this.dtgcSubtotal.Width = 125;
            // 
            // dtcgTotal
            // 
            this.dtcgTotal.HeaderText = "Total";
            this.dtcgTotal.MinimumWidth = 6;
            this.dtcgTotal.Name = "dtcgTotal";
            this.dtcgTotal.ReadOnly = true;
            this.dtcgTotal.Width = 125;
            // 
            // dtcDescuento
            // 
            this.dtcDescuento.HeaderText = "Descuento";
            this.dtcDescuento.MinimumWidth = 6;
            this.dtcDescuento.Name = "dtcDescuento";
            this.dtcDescuento.ReadOnly = true;
            this.dtcDescuento.Width = 125;
            // 
            // dtgcEmpleado
            // 
            this.dtgcEmpleado.HeaderText = "Atendio";
            this.dtgcEmpleado.MinimumWidth = 6;
            this.dtgcEmpleado.Name = "dtgcEmpleado";
            this.dtgcEmpleado.ReadOnly = true;
            this.dtgcEmpleado.Width = 125;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1647, 658);
            this.Controls.Add(this.dtgVentas);
            this.Controls.Add(this.grpEmpleado);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.grpDatosCalzado);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.grpDatosCalzado.ResumeLayout(false);
            this.grpDatosCalzado.PerformLayout();
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            this.grpEmpleado.ResumeLayout(false);
            this.grpEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpDatosCalzado;
        private ComboBox cmbBusqueda;
        private Label label2;
        private Label label1;
        private TextBox txtTalla;
        private TextBox txtCantidad;
        private Label label3;
        private Button btnAgregar;
        private Button btnModificar;
        private TextBox txtID;
        private Label label4;
        private Button btnEliminar;
        private Button btnBuscar;
        private GroupBox grpDatosCliente;
        private Label label5;
        private TextBox txtDireccion;
        private Label label8;
        private TextBox txtApellido;
        private Label label7;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtNombreCliente;
        private Button btnRealizarVenta;
        private Button btnCancelarVenta;
        private GroupBox grpEmpleado;
        private Label label11;
        private Label lblFechaActual;
        private Label label10;
        private ComboBox cmbEmpleados;
        private Label label9;
        private DataGridView dtgVentas;
        private DataGridViewTextBoxColumn dtgcIDVenta;
        private DataGridViewTextBoxColumn dtgcIDZapato;
        private DataGridViewTextBoxColumn dtgcTipoCalzado;
        private DataGridViewTextBoxColumn dtgcTalla;
        private DataGridViewTextBoxColumn dtcNombreCliente;
        private DataGridViewTextBoxColumn dtgcCantidad;
        private DataGridViewTextBoxColumn dtgcSubtotal;
        private DataGridViewTextBoxColumn dtcgTotal;
        private DataGridViewTextBoxColumn dtcDescuento;
        private DataGridViewTextBoxColumn dtgcEmpleado;
    }
}