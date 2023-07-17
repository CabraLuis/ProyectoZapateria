﻿namespace ProyectoZapateria
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
            label9 = new Label();
            label1 = new Label();
            radActualizar = new RadioButton();
            radAgregar = new RadioButton();
            dataGridView1 = new DataGridView();
            dtgcID = new DataGridViewTextBoxColumn();
            dtgcTipoCalzado = new DataGridViewTextBoxColumn();
            dtgcTalla = new DataGridViewTextBoxColumn();
            dtgcMarca = new DataGridViewTextBoxColumn();
            dtgcModelo = new DataGridViewTextBoxColumn();
            dtgcStock = new DataGridViewTextBoxColumn();
            dtgcColor = new DataGridViewTextBoxColumn();
            dtgcPrecio = new DataGridViewTextBoxColumn();
            dtgcProveedor = new DataGridViewTextBoxColumn();
            grpDatosZapato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grpDatosZapato
            // 
            grpDatosZapato.Controls.Add(btnRegresar);
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
            grpDatosZapato.Controls.Add(label9);
            grpDatosZapato.Controls.Add(label1);
            grpDatosZapato.Controls.Add(radActualizar);
            grpDatosZapato.Controls.Add(radAgregar);
            grpDatosZapato.Location = new Point(12, 12);
            grpDatosZapato.Name = "grpDatosZapato";
            grpDatosZapato.Size = new Size(353, 426);
            grpDatosZapato.TabIndex = 0;
            grpDatosZapato.TabStop = false;
            grpDatosZapato.Text = "Datos del producto:";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(230, 397);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAccion
            // 
            btnAccion.Location = new Point(6, 391);
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
            cmbProveedores.Location = new Point(196, 356);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(146, 28);
            cmbProveedores.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(196, 321);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(146, 27);
            txtPrecio.TabIndex = 1;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(196, 288);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(146, 27);
            txtExistencias.TabIndex = 1;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(196, 252);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(146, 27);
            txtColor.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(196, 219);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(146, 27);
            txtModelo.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(196, 182);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(146, 27);
            txtMarca.TabIndex = 1;
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(196, 147);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(146, 27);
            txtTalla.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(196, 90);
            txtID.Name = "txtID";
            txtID.Size = new Size(146, 27);
            txtID.TabIndex = 1;
            // 
            // txtTipoCalzado
            // 
            txtTipoCalzado.Location = new Point(196, 117);
            txtTipoCalzado.Name = "txtTipoCalzado";
            txtTipoCalzado.Size = new Size(146, 27);
            txtTipoCalzado.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 356);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 1;
            label8.Text = "Proveedor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 324);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 1;
            label7.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 288);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 1;
            label6.Text = "Existencias:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 252);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 1;
            label5.Text = "Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 219);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 1;
            label4.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 189);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 1;
            label3.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 154);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Talla:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 90);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 1;
            label9.Text = "ID o Codigo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 124);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Tipo de Calzado:";
            // 
            // radActualizar
            // 
            radActualizar.Appearance = Appearance.Button;
            radActualizar.AutoSize = true;
            radActualizar.BackColor = SystemColors.Control;
            radActualizar.Location = new Point(196, 40);
            radActualizar.Name = "radActualizar";
            radActualizar.Size = new Size(146, 30);
            radActualizar.TabIndex = 1;
            radActualizar.Text = "Actualizar Calzado:";
            radActualizar.UseVisualStyleBackColor = false;
            radActualizar.CheckedChanged += radActualizar_CheckedChanged;
            // 
            // radAgregar
            // 
            radAgregar.Appearance = Appearance.Button;
            radAgregar.AutoSize = true;
            radAgregar.Checked = true;
            radAgregar.Location = new Point(6, 40);
            radAgregar.Name = "radAgregar";
            radAgregar.Size = new Size(184, 30);
            radAgregar.TabIndex = 1;
            radAgregar.TabStop = true;
            radAgregar.Text = "Agregar Nuevo Producto";
            radAgregar.UseVisualStyleBackColor = true;
            radAgregar.CheckedChanged += radAgregar_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dtgcID, dtgcTipoCalzado, dtgcTalla, dtgcMarca, dtgcModelo, dtgcStock, dtgcColor, dtgcPrecio, dtgcProveedor });
            dataGridView1.Location = new Point(371, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1185, 415);
            dataGridView1.TabIndex = 1;
            // 
            // dtgcID
            // 
            dtgcID.HeaderText = "ID";
            dtgcID.MinimumWidth = 6;
            dtgcID.Name = "dtgcID";
            dtgcID.ReadOnly = true;
            dtgcID.Width = 125;
            // 
            // dtgcTipoCalzado
            // 
            dtgcTipoCalzado.HeaderText = "Tipo de Calzado";
            dtgcTipoCalzado.MinimumWidth = 6;
            dtgcTipoCalzado.Name = "dtgcTipoCalzado";
            dtgcTipoCalzado.ReadOnly = true;
            dtgcTipoCalzado.Width = 125;
            // 
            // dtgcTalla
            // 
            dtgcTalla.HeaderText = "Talla";
            dtgcTalla.MinimumWidth = 6;
            dtgcTalla.Name = "dtgcTalla";
            dtgcTalla.ReadOnly = true;
            dtgcTalla.Width = 125;
            // 
            // dtgcMarca
            // 
            dtgcMarca.HeaderText = "Marca";
            dtgcMarca.MinimumWidth = 6;
            dtgcMarca.Name = "dtgcMarca";
            dtgcMarca.ReadOnly = true;
            dtgcMarca.Width = 125;
            // 
            // dtgcModelo
            // 
            dtgcModelo.HeaderText = "Modelo";
            dtgcModelo.MinimumWidth = 6;
            dtgcModelo.Name = "dtgcModelo";
            dtgcModelo.ReadOnly = true;
            dtgcModelo.Width = 125;
            // 
            // dtgcStock
            // 
            dtgcStock.HeaderText = "Stock";
            dtgcStock.MinimumWidth = 6;
            dtgcStock.Name = "dtgcStock";
            dtgcStock.ReadOnly = true;
            dtgcStock.Width = 125;
            // 
            // dtgcColor
            // 
            dtgcColor.HeaderText = "Color";
            dtgcColor.MinimumWidth = 6;
            dtgcColor.Name = "dtgcColor";
            dtgcColor.ReadOnly = true;
            dtgcColor.Width = 125;
            // 
            // dtgcPrecio
            // 
            dtgcPrecio.HeaderText = "Precio";
            dtgcPrecio.MinimumWidth = 6;
            dtgcPrecio.Name = "dtgcPrecio";
            dtgcPrecio.ReadOnly = true;
            dtgcPrecio.Width = 125;
            // 
            // dtgcProveedor
            // 
            dtgcProveedor.HeaderText = "Proveedor";
            dtgcProveedor.MinimumWidth = 6;
            dtgcProveedor.Name = "dtgcProveedor";
            dtgcProveedor.ReadOnly = true;
            dtgcProveedor.Width = 125;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1568, 458);
            Controls.Add(dataGridView1);
            Controls.Add(grpDatosZapato);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            grpDatosZapato.ResumeLayout(false);
            grpDatosZapato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btnRegresar;
    }
}