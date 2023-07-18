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
            this.grpDatosZapato = new System.Windows.Forms.GroupBox();
            this.btnAccion = new System.Windows.Forms.Button();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTipoCalzado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radActualizar = new System.Windows.Forms.RadioButton();
            this.radAgregar = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcTipoCalzado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatosZapato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatosZapato
            // 
            this.grpDatosZapato.BackColor = System.Drawing.Color.Black;
            this.grpDatosZapato.BackgroundImage = global::ProyectoZapateria.Properties.Resources.FondoTenis4;
            this.grpDatosZapato.Controls.Add(this.btnAccion);
            this.grpDatosZapato.Controls.Add(this.cmbProveedores);
            this.grpDatosZapato.Controls.Add(this.txtPrecio);
            this.grpDatosZapato.Controls.Add(this.txtExistencias);
            this.grpDatosZapato.Controls.Add(this.txtColor);
            this.grpDatosZapato.Controls.Add(this.txtModelo);
            this.grpDatosZapato.Controls.Add(this.txtMarca);
            this.grpDatosZapato.Controls.Add(this.txtTalla);
            this.grpDatosZapato.Controls.Add(this.txtID);
            this.grpDatosZapato.Controls.Add(this.txtTipoCalzado);
            this.grpDatosZapato.Controls.Add(this.label8);
            this.grpDatosZapato.Controls.Add(this.label7);
            this.grpDatosZapato.Controls.Add(this.label6);
            this.grpDatosZapato.Controls.Add(this.label5);
            this.grpDatosZapato.Controls.Add(this.label4);
            this.grpDatosZapato.Controls.Add(this.label3);
            this.grpDatosZapato.Controls.Add(this.label2);
            this.grpDatosZapato.Controls.Add(this.label9);
            this.grpDatosZapato.Controls.Add(this.label1);
            this.grpDatosZapato.Controls.Add(this.radActualizar);
            this.grpDatosZapato.Controls.Add(this.radAgregar);
            this.grpDatosZapato.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDatosZapato.ForeColor = System.Drawing.Color.Yellow;
            this.grpDatosZapato.Location = new System.Drawing.Point(12, 12);
            this.grpDatosZapato.Name = "grpDatosZapato";
            this.grpDatosZapato.Size = new System.Drawing.Size(423, 426);
            this.grpDatosZapato.TabIndex = 0;
            this.grpDatosZapato.TabStop = false;
            this.grpDatosZapato.Text = "Datos del producto:";
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(108, 390);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(115, 29);
            this.btnAccion.TabIndex = 1;
            this.btnAccion.UseVisualStyleBackColor = true;
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(196, 356);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(146, 30);
            this.cmbProveedores.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(196, 321);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(146, 29);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(196, 288);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(146, 29);
            this.txtExistencias.TabIndex = 1;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(196, 252);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(146, 29);
            this.txtColor.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(196, 219);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(146, 29);
            this.txtModelo.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(196, 182);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(146, 29);
            this.txtMarca.TabIndex = 1;
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(196, 147);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(146, 29);
            this.txtTalla.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(196, 90);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 29);
            this.txtID.TabIndex = 1;
            // 
            // txtTipoCalzado
            // 
            this.txtTipoCalzado.Location = new System.Drawing.Point(196, 117);
            this.txtTipoCalzado.Name = "txtTipoCalzado";
            this.txtTipoCalzado.Size = new System.Drawing.Size(146, 29);
            this.txtTipoCalzado.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Proveedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Existencias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Talla:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "ID o Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Calzado:";
            // 
            // radActualizar
            // 
            this.radActualizar.Appearance = System.Windows.Forms.Appearance.Button;
            this.radActualizar.AutoSize = true;
            this.radActualizar.BackColor = System.Drawing.Color.Black;
            this.radActualizar.Location = new System.Drawing.Point(233, 40);
            this.radActualizar.Name = "radActualizar";
            this.radActualizar.Size = new System.Drawing.Size(174, 32);
            this.radActualizar.TabIndex = 1;
            this.radActualizar.Text = "Actualizar Calzado:";
            this.radActualizar.UseVisualStyleBackColor = false;
            // 
            // radAgregar
            // 
            this.radAgregar.Appearance = System.Windows.Forms.Appearance.Button;
            this.radAgregar.AutoSize = true;
            this.radAgregar.BackColor = System.Drawing.Color.Black;
            this.radAgregar.Checked = true;
            this.radAgregar.Location = new System.Drawing.Point(6, 40);
            this.radAgregar.Name = "radAgregar";
            this.radAgregar.Size = new System.Drawing.Size(221, 32);
            this.radAgregar.TabIndex = 1;
            this.radAgregar.TabStop = true;
            this.radAgregar.Text = "Agregar Nuevo Producto";
            this.radAgregar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgcID,
            this.dtgcTipoCalzado,
            this.dtgcTalla,
            this.dtgcMarca,
            this.dtgcModelo,
            this.dtgcStock,
            this.dtgcColor,
            this.dtgcPrecio,
            this.dtgcProveedor});
            this.dataGridView1.Location = new System.Drawing.Point(441, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 415);
            this.dataGridView1.TabIndex = 1;
            // 
            // dtgcID
            // 
            this.dtgcID.HeaderText = "ID";
            this.dtgcID.MinimumWidth = 6;
            this.dtgcID.Name = "dtgcID";
            this.dtgcID.ReadOnly = true;
            this.dtgcID.Width = 125;
            // 
            // dtgcTipoCalzado
            // 
            this.dtgcTipoCalzado.HeaderText = "Tipo de Calzado";
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
            // dtgcMarca
            // 
            this.dtgcMarca.HeaderText = "Marca";
            this.dtgcMarca.MinimumWidth = 6;
            this.dtgcMarca.Name = "dtgcMarca";
            this.dtgcMarca.ReadOnly = true;
            this.dtgcMarca.Width = 125;
            // 
            // dtgcModelo
            // 
            this.dtgcModelo.HeaderText = "Modelo";
            this.dtgcModelo.MinimumWidth = 6;
            this.dtgcModelo.Name = "dtgcModelo";
            this.dtgcModelo.ReadOnly = true;
            this.dtgcModelo.Width = 125;
            // 
            // dtgcStock
            // 
            this.dtgcStock.HeaderText = "Stock";
            this.dtgcStock.MinimumWidth = 6;
            this.dtgcStock.Name = "dtgcStock";
            this.dtgcStock.ReadOnly = true;
            this.dtgcStock.Width = 125;
            // 
            // dtgcColor
            // 
            this.dtgcColor.HeaderText = "Color";
            this.dtgcColor.MinimumWidth = 6;
            this.dtgcColor.Name = "dtgcColor";
            this.dtgcColor.ReadOnly = true;
            this.dtgcColor.Width = 125;
            // 
            // dtgcPrecio
            // 
            this.dtgcPrecio.HeaderText = "Precio";
            this.dtgcPrecio.MinimumWidth = 6;
            this.dtgcPrecio.Name = "dtgcPrecio";
            this.dtgcPrecio.ReadOnly = true;
            this.dtgcPrecio.Width = 125;
            // 
            // dtgcProveedor
            // 
            this.dtgcProveedor.HeaderText = "Proveedor";
            this.dtgcProveedor.MinimumWidth = 6;
            this.dtgcProveedor.Name = "dtgcProveedor";
            this.dtgcProveedor.ReadOnly = true;
            this.dtgcProveedor.Width = 125;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoZapateria.Properties.Resources.FondoTenis4;
            this.ClientSize = new System.Drawing.Size(1661, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpDatosZapato);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.grpDatosZapato.ResumeLayout(false);
            this.grpDatosZapato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private Label label9;
        private Button btnAccion;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dtgcID;
        private DataGridViewTextBoxColumn dtgcTipoCalzado;
        private DataGridViewTextBoxColumn dtgcTalla;
        private DataGridViewTextBoxColumn dtgcMarca;
        private DataGridViewTextBoxColumn dtgcModelo;
        private DataGridViewTextBoxColumn dtgcStock;
        private DataGridViewTextBoxColumn dtgcColor;
        private DataGridViewTextBoxColumn dtgcPrecio;
        private DataGridViewTextBoxColumn dtgcProveedor;
    }
}