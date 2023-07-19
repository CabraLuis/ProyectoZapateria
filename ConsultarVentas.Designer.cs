﻿namespace ProyectoZapateria
{
    partial class ConsultarVentas
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
            grpConsultaVentas = new GroupBox();
            btnConsultar = new Button();
            dtmFechaFinal = new DateTimePicker();
            label2 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dtgcIDVenta = new DataGridViewTextBoxColumn();
            dtgcFecha = new DataGridViewTextBoxColumn();
            dtgcIDZapato = new DataGridViewTextBoxColumn();
            dtgcTotal = new DataGridViewTextBoxColumn();
            dtgcEmpleado = new DataGridViewTextBoxColumn();
            dtgcCantidad = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            grpConsultaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grpConsultaVentas
            // 
            grpConsultaVentas.Controls.Add(btnRegresar);
            grpConsultaVentas.Controls.Add(btnConsultar);
            grpConsultaVentas.Controls.Add(dtmFechaFinal);
            grpConsultaVentas.Controls.Add(label2);
            grpConsultaVentas.Controls.Add(dtpFechaInicio);
            grpConsultaVentas.Controls.Add(label1);
            grpConsultaVentas.Location = new Point(22, 12);
            grpConsultaVentas.Name = "grpConsultaVentas";
            grpConsultaVentas.Size = new Size(386, 199);
            grpConsultaVentas.TabIndex = 0;
            grpConsultaVentas.TabStop = false;
            grpConsultaVentas.Text = "Datos Consulta:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(6, 135);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dtmFechaFinal
            // 
            dtmFechaFinal.Location = new Point(105, 90);
            dtmFechaFinal.Name = "dtmFechaFinal";
            dtmFechaFinal.Size = new Size(250, 27);
            dtmFechaFinal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 95);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha Final:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(105, 40);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 27);
            dtpFechaInicio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha Inicial:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dtgcIDVenta, dtgcFecha, dtgcIDZapato, dtgcTotal, dtgcEmpleado, dtgcCantidad });
            dataGridView1.Location = new Point(432, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(813, 188);
            dataGridView1.TabIndex = 1;
            // 
            // dtgcIDVenta
            // 
            dtgcIDVenta.HeaderText = "IDVenta";
            dtgcIDVenta.MinimumWidth = 6;
            dtgcIDVenta.Name = "dtgcIDVenta";
            dtgcIDVenta.ReadOnly = true;
            dtgcIDVenta.Width = 125;
            // 
            // dtgcFecha
            // 
            dtgcFecha.HeaderText = "Fecha";
            dtgcFecha.MinimumWidth = 6;
            dtgcFecha.Name = "dtgcFecha";
            dtgcFecha.ReadOnly = true;
            dtgcFecha.Width = 125;
            // 
            // dtgcIDZapato
            // 
            dtgcIDZapato.HeaderText = "IDZapato";
            dtgcIDZapato.MinimumWidth = 6;
            dtgcIDZapato.Name = "dtgcIDZapato";
            dtgcIDZapato.ReadOnly = true;
            dtgcIDZapato.Width = 125;
            // 
            // dtgcTotal
            // 
            dtgcTotal.HeaderText = "Total";
            dtgcTotal.MinimumWidth = 6;
            dtgcTotal.Name = "dtgcTotal";
            dtgcTotal.ReadOnly = true;
            dtgcTotal.Width = 125;
            // 
            // dtgcEmpleado
            // 
            dtgcEmpleado.HeaderText = "Empleado";
            dtgcEmpleado.MinimumWidth = 6;
            dtgcEmpleado.Name = "dtgcEmpleado";
            dtgcEmpleado.ReadOnly = true;
            dtgcEmpleado.Width = 125;
            // 
            // dtgcCantidad
            // 
            dtgcCantidad.HeaderText = "Cantidad";
            dtgcCantidad.MinimumWidth = 6;
            dtgcCantidad.Name = "dtgcCantidad";
            dtgcCantidad.ReadOnly = true;
            dtgcCantidad.Width = 125;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(261, 135);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // ConsultarVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 220);
            Controls.Add(dataGridView1);
            Controls.Add(grpConsultaVentas);
            Name = "ConsultarVentas";
            Text = "ConsultarVentas";
            grpConsultaVentas.ResumeLayout(false);
            grpConsultaVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpConsultaVentas;
        private DateTimePicker dtmFechaFinal;
        private Label label2;
        private DateTimePicker dtpFechaInicio;
        private Label label1;
        private Button btnConsultar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dtgcIDVenta;
        private DataGridViewTextBoxColumn dtgcFecha;
        private DataGridViewTextBoxColumn dtgcIDZapato;
        private DataGridViewTextBoxColumn dtgcTotal;
        private DataGridViewTextBoxColumn dtgcEmpleado;
        private DataGridViewTextBoxColumn dtgcCantidad;
        private Button btnRegresar;
    }
}