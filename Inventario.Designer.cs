namespace ProyectoZapateria
{
    partial class Inventario
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
            grpDatosZapato = new GroupBox();
            btnRegresar = new Button();
            btnBuscar = new Button();
            btnAccion = new Button();
            cmbProveedores = new ComboBox();
            txtPrecio = new TextBox();
            txtExistencias = new TextBox();
            txtColor = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtTalla = new TextBox();
            txtID = new TextBox();
            txtTipoCalzado = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblcod = new Label();
            label1 = new Label();
            radActualizar = new RadioButton();
            radAgregar = new RadioButton();
            dtgDatosZapatos = new DataGridView();
            grpDatosZapato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatosZapatos).BeginInit();
            SuspendLayout();
            // 
            // grpDatosZapato
            // 
            grpDatosZapato.BackColor = Color.Black;
            grpDatosZapato.BackgroundImage = Properties.Resources.FondoTenis4;
            grpDatosZapato.Controls.Add(btnRegresar);
            grpDatosZapato.Controls.Add(btnBuscar);
            grpDatosZapato.Controls.Add(btnAccion);
            grpDatosZapato.Controls.Add(cmbProveedores);
            grpDatosZapato.Controls.Add(txtPrecio);
            grpDatosZapato.Controls.Add(txtExistencias);
            grpDatosZapato.Controls.Add(txtColor);
            grpDatosZapato.Controls.Add(txtModelo);
            grpDatosZapato.Controls.Add(txtMarca);
            grpDatosZapato.Controls.Add(txtTalla);
            grpDatosZapato.Controls.Add(txtID);
            grpDatosZapato.Controls.Add(txtTipoCalzado);
            grpDatosZapato.Controls.Add(label8);
            grpDatosZapato.Controls.Add(label7);
            grpDatosZapato.Controls.Add(label6);
            grpDatosZapato.Controls.Add(label5);
            grpDatosZapato.Controls.Add(label4);
            grpDatosZapato.Controls.Add(label3);
            grpDatosZapato.Controls.Add(label2);
            grpDatosZapato.Controls.Add(lblcod);
            grpDatosZapato.Controls.Add(label1);
            grpDatosZapato.Controls.Add(radActualizar);
            grpDatosZapato.Controls.Add(radAgregar);
            grpDatosZapato.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatosZapato.ForeColor = Color.Yellow;
            grpDatosZapato.Location = new Point(4, 12);
            grpDatosZapato.Name = "grpDatosZapato";
            grpDatosZapato.Size = new Size(463, 426);
            grpDatosZapato.TabIndex = 0;
            grpDatosZapato.TabStop = false;
            grpDatosZapato.Text = "Datos del producto:";
            grpDatosZapato.Enter += grpDatosZapato_Enter;
            // 
            // btnRegresar
            // 
            btnRegresar.ForeColor = Color.MediumBlue;
            btnRegresar.Location = new Point(337, 392);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(120, 29);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(182, 391);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAccion
            // 
            btnAccion.Location = new Point(9, 391);
            btnAccion.Name = "btnAccion";
            btnAccion.Size = new Size(115, 29);
            btnAccion.TabIndex = 1;
            btnAccion.UseVisualStyleBackColor = true;
            btnAccion.Click += btnAccion_Click;
            // 
            // cmbProveedores
            // 
            cmbProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedores.FormattingEnabled = true;
            cmbProveedores.Location = new Point(196, 353);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(146, 33);
            cmbProveedores.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(196, 321);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(146, 30);
            txtPrecio.TabIndex = 1;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(196, 288);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(146, 30);
            txtExistencias.TabIndex = 1;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(196, 252);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(146, 30);
            txtColor.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(196, 219);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(146, 30);
            txtModelo.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(196, 182);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(146, 30);
            txtMarca.TabIndex = 1;
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(196, 147);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(146, 30);
            txtTalla.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(196, 90);
            txtID.Name = "txtID";
            txtID.Size = new Size(146, 30);
            txtID.TabIndex = 1;
            // 
            // txtTipoCalzado
            // 
            txtTipoCalzado.Location = new Point(196, 117);
            txtTipoCalzado.Name = "txtTipoCalzado";
            txtTipoCalzado.Size = new Size(146, 30);
            txtTipoCalzado.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 356);
            label8.Name = "label8";
            label8.Size = new Size(118, 25);
            label8.TabIndex = 1;
            label8.Text = "Proveedor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 324);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 1;
            label7.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 288);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 1;
            label6.Text = "Existencias:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 252);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 1;
            label5.Text = "Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 219);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 1;
            label4.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 189);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 1;
            label3.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 154);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 1;
            label2.Text = "Talla:";
            // 
            // lblcod
            // 
            lblcod.AutoSize = true;
            lblcod.Location = new Point(6, 90);
            lblcod.Name = "lblcod";
            lblcod.Size = new Size(133, 25);
            lblcod.TabIndex = 1;
            lblcod.Text = "ID o Codigo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 124);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 1;
            label1.Text = "Tipo de Calzado:";
            // 
            // radActualizar
            // 
            radActualizar.Appearance = Appearance.Button;
            radActualizar.AutoSize = true;
            radActualizar.BackColor = Color.Black;
            radActualizar.Location = new Point(261, 40);
            radActualizar.Name = "radActualizar";
            radActualizar.Size = new Size(211, 35);
            radActualizar.TabIndex = 1;
            radActualizar.Text = "Actualizar Calzado:";
            radActualizar.UseVisualStyleBackColor = false;
            radActualizar.CheckedChanged += radActualizar_CheckedChanged;
            // 
            // radAgregar
            // 
            radAgregar.Appearance = Appearance.Button;
            radAgregar.AutoSize = true;
            radAgregar.BackColor = Color.Black;
            radAgregar.Checked = true;
            radAgregar.Location = new Point(6, 40);
            radAgregar.Name = "radAgregar";
            radAgregar.Size = new Size(259, 35);
            radAgregar.TabIndex = 1;
            radAgregar.TabStop = true;
            radAgregar.Text = "Agregar Nuevo Producto";
            radAgregar.UseVisualStyleBackColor = false;
            radAgregar.CheckedChanged += radAgregar_CheckedChanged;
            // 
            // dtgDatosZapatos
            // 
            dtgDatosZapatos.AllowUserToAddRows = false;
            dtgDatosZapatos.AllowUserToDeleteRows = false;
            dtgDatosZapatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatosZapatos.Location = new Point(473, 17);
            dtgDatosZapatos.Name = "dtgDatosZapatos";
            dtgDatosZapatos.ReadOnly = true;
            dtgDatosZapatos.RowHeadersWidth = 51;
            dtgDatosZapatos.RowTemplate.Height = 29;
            dtgDatosZapatos.Size = new Size(1221, 415);
            dtgDatosZapatos.TabIndex = 1;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoTenis4;
            ClientSize = new Size(1713, 458);
            Controls.Add(dtgDatosZapatos);
            Controls.Add(grpDatosZapato);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            grpDatosZapato.ResumeLayout(false);
            grpDatosZapato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatosZapatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosZapato;
        private RadioButton radActualizar;
        private RadioButton radAgregar;
        private TextBox txtPrecio;
        private TextBox txtExistencias;
        private TextBox txtColor;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtTalla;
        private TextBox txtTipoCalzado;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbProveedores;
        private TextBox txtID;
        private Label label8;
        private Label lblcod;
        private Button btnAccion;
        private DataGridView dtgDatosZapatos;
        private Button btnBuscar;
        private Button btnRegresar;
    }
}