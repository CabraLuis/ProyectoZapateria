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
            Label lblHoraActual;
            grpDatosCalzado = new GroupBox();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtTalla = new TextBox();
            txtID = new TextBox();
            txtCantidad = new TextBox();
            cmbBusqueda = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpDatosCliente = new GroupBox();
            txtDireccion = new TextBox();
            label8 = new Label();
            txtApellido = new TextBox();
            label7 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtNombreCliente = new TextBox();
            label5 = new Label();
            btnRealizarVenta = new Button();
            btnCancelarVenta = new Button();
            grpEmpleado = new GroupBox();
            label11 = new Label();
            lblFechaActual = new Label();
            label10 = new Label();
            cmbEmpleados = new ComboBox();
            label9 = new Label();
            dtgVentas = new DataGridView();
            lblHoraActual = new Label();
            grpDatosCalzado.SuspendLayout();
            grpDatosCliente.SuspendLayout();
            grpEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgVentas).BeginInit();
            SuspendLayout();
            // 
            // lblHoraActual
            // 
            lblHoraActual.AutoSize = true;
            lblHoraActual.BackColor = SystemColors.Info;
            lblHoraActual.BorderStyle = BorderStyle.Fixed3D;
            lblHoraActual.Location = new Point(896, 34);
            lblHoraActual.Name = "lblHoraActual";
            lblHoraActual.Size = new Size(2, 27);
            lblHoraActual.TabIndex = 5;
            // 
            // grpDatosCalzado
            // 
            grpDatosCalzado.BackgroundImage = Properties.Resources.FondoTenis11;
            grpDatosCalzado.Controls.Add(btnEliminar);
            grpDatosCalzado.Controls.Add(btnBuscar);
            grpDatosCalzado.Controls.Add(btnModificar);
            grpDatosCalzado.Controls.Add(btnAgregar);
            grpDatosCalzado.Controls.Add(txtTalla);
            grpDatosCalzado.Controls.Add(txtID);
            grpDatosCalzado.Controls.Add(txtCantidad);
            grpDatosCalzado.Controls.Add(cmbBusqueda);
            grpDatosCalzado.Controls.Add(label3);
            grpDatosCalzado.Controls.Add(label4);
            grpDatosCalzado.Controls.Add(label2);
            grpDatosCalzado.Controls.Add(label1);
            grpDatosCalzado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatosCalzado.Location = new Point(12, 12);
            grpDatosCalzado.Name = "grpDatosCalzado";
            grpDatosCalzado.Size = new Size(300, 331);
            grpDatosCalzado.TabIndex = 0;
            grpDatosCalzado.TabStop = false;
            grpDatosCalzado.Text = "Datos Calzado:";
            grpDatosCalzado.Enter += grpDatosCalzado_Enter;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(7, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(268, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(7, 246);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(268, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(7, 176);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(268, 29);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(7, 211);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(268, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(131, 134);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(151, 30);
            txtTalla.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(143, 69);
            txtID.Name = "txtID";
            txtID.Size = new Size(151, 30);
            txtID.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(131, 101);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(151, 30);
            txtCantidad.TabIndex = 1;
            // 
            // cmbBusqueda
            // 
            cmbBusqueda.FormattingEnabled = true;
            cmbBusqueda.Location = new Point(148, 26);
            cmbBusqueda.Name = "cmbBusqueda";
            cmbBusqueda.Size = new Size(151, 33);
            cmbBusqueda.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Location = new Point(19, 137);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 1;
            label3.Text = "Talla:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Location = new Point(16, 72);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 1;
            label4.Text = "ID o Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(19, 101);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Buscar por:";
            // 
            // grpDatosCliente
            // 
            grpDatosCliente.BackColor = SystemColors.ActiveCaptionText;
            grpDatosCliente.BackgroundImage = Properties.Resources.FondoTenis2;
            grpDatosCliente.Controls.Add(txtDireccion);
            grpDatosCliente.Controls.Add(label8);
            grpDatosCliente.Controls.Add(txtApellido);
            grpDatosCliente.Controls.Add(label7);
            grpDatosCliente.Controls.Add(txtTelefono);
            grpDatosCliente.Controls.Add(label6);
            grpDatosCliente.Controls.Add(txtNombreCliente);
            grpDatosCliente.Controls.Add(label5);
            grpDatosCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatosCliente.ForeColor = Color.DeepSkyBlue;
            grpDatosCliente.Location = new Point(12, 349);
            grpDatosCliente.Name = "grpDatosCliente";
            grpDatosCliente.Size = new Size(288, 224);
            grpDatosCliente.TabIndex = 1;
            grpDatosCliente.TabStop = false;
            grpDatosCliente.Text = "Datos del cliente:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(110, 176);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(172, 30);
            txtDireccion.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 179);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 2;
            label8.Text = "Direccion";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(110, 139);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 30);
            txtApellido.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 142);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 2;
            label7.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(110, 89);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 30);
            txtTelefono.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 96);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 2;
            label6.Text = "Telefono:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(110, 43);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(125, 30);
            txtNombreCliente.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 50);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 2;
            label5.Text = "Nombre:";
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.BackColor = Color.DarkCyan;
            btnRealizarVenta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRealizarVenta.Location = new Point(12, 579);
            btnRealizarVenta.Name = "btnRealizarVenta";
            btnRealizarVenta.Size = new Size(288, 29);
            btnRealizarVenta.TabIndex = 2;
            btnRealizarVenta.Text = "Realizar Venta";
            btnRealizarVenta.UseVisualStyleBackColor = false;
            btnRealizarVenta.Click += btnRealizarVenta_Click;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.BackColor = Color.DarkCyan;
            btnCancelarVenta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarVenta.Location = new Point(12, 614);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(288, 29);
            btnCancelarVenta.TabIndex = 3;
            btnCancelarVenta.Text = "Cancelar Venta";
            btnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // grpEmpleado
            // 
            grpEmpleado.BackColor = Color.DimGray;
            grpEmpleado.BackgroundImage = Properties.Resources.FondoTenis3;
            grpEmpleado.Controls.Add(lblHoraActual);
            grpEmpleado.Controls.Add(label11);
            grpEmpleado.Controls.Add(lblFechaActual);
            grpEmpleado.Controls.Add(label10);
            grpEmpleado.Controls.Add(cmbEmpleados);
            grpEmpleado.Controls.Add(label9);
            grpEmpleado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpEmpleado.ForeColor = Color.DarkTurquoise;
            grpEmpleado.Location = new Point(318, 12);
            grpEmpleado.Name = "grpEmpleado";
            grpEmpleado.RightToLeft = RightToLeft.No;
            grpEmpleado.Size = new Size(1311, 69);
            grpEmpleado.TabIndex = 4;
            grpEmpleado.TabStop = false;
            grpEmpleado.Text = "Identificacion:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(789, 34);
            label11.Name = "label11";
            label11.Size = new Size(132, 25);
            label11.TabIndex = 4;
            label11.Text = "Hora Actual:";
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.BorderStyle = BorderStyle.Fixed3D;
            lblFechaActual.Location = new Point(703, 32);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(2, 27);
            lblFechaActual.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(589, 34);
            label10.Name = "label10";
            label10.Size = new Size(146, 25);
            label10.TabIndex = 2;
            label10.Text = "Fecha Actual:";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(415, 29);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(151, 33);
            cmbEmpleados.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(294, 34);
            label9.Name = "label9";
            label9.Size = new Size(115, 25);
            label9.TabIndex = 0;
            label9.Text = "Empleado:";
            // 
            // dtgVentas
            // 
            dtgVentas.AllowUserToAddRows = false;
            dtgVentas.AllowUserToDeleteRows = false;
            dtgVentas.BorderStyle = BorderStyle.Fixed3D;
            dtgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVentas.Location = new Point(318, 99);
            dtgVentas.Name = "dtgVentas";
            dtgVentas.ReadOnly = true;
            dtgVentas.RowHeadersWidth = 51;
            dtgVentas.RowTemplate.Height = 29;
            dtgVentas.Size = new Size(1311, 544);
            dtgVentas.TabIndex = 5;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1647, 658);
            Controls.Add(dtgVentas);
            Controls.Add(grpEmpleado);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnRealizarVenta);
            Controls.Add(grpDatosCliente);
            Controls.Add(grpDatosCalzado);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            grpDatosCalzado.ResumeLayout(false);
            grpDatosCalzado.PerformLayout();
            grpDatosCliente.ResumeLayout(false);
            grpDatosCliente.PerformLayout();
            grpEmpleado.ResumeLayout(false);
            grpEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgVentas).EndInit();
            ResumeLayout(false);
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
        private Button btnModificar;
    }
}