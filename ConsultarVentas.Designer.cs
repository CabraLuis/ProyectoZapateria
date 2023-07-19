namespace ProyectoZapateria
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
            this.grpConsultaVentas = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtmFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtgcIDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcIDZapato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgcCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConsultaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultaVentas
            // 
            this.grpConsultaVentas.BackgroundImage = global::ProyectoZapateria.Properties.Resources.FondoTenis6;
            this.grpConsultaVentas.Controls.Add(this.btnConsultar);
            this.grpConsultaVentas.Controls.Add(this.dtmFechaFinal);
            this.grpConsultaVentas.Controls.Add(this.label2);
            this.grpConsultaVentas.Controls.Add(this.dtpFechaInicio);
            this.grpConsultaVentas.Controls.Add(this.label1);
            this.grpConsultaVentas.Font = new System.Drawing.Font("212 Orion Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpConsultaVentas.ForeColor = System.Drawing.Color.Blue;
            this.grpConsultaVentas.Location = new System.Drawing.Point(22, 12);
            this.grpConsultaVentas.Name = "grpConsultaVentas";
            this.grpConsultaVentas.Size = new System.Drawing.Size(504, 199);
            this.grpConsultaVentas.TabIndex = 0;
            this.grpConsultaVentas.TabStop = false;
            this.grpConsultaVentas.Text = "Datos Consulta:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.LightGray;
            this.btnConsultar.Location = new System.Drawing.Point(105, 141);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(94, 29);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // dtmFechaFinal
            // 
            this.dtmFechaFinal.Location = new System.Drawing.Point(151, 88);
            this.dtmFechaFinal.Name = "dtmFechaFinal";
            this.dtmFechaFinal.Size = new System.Drawing.Size(250, 29);
            this.dtmFechaFinal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Final:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(151, 40);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(250, 29);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Inicial:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgcIDVenta,
            this.dtgcFecha,
            this.dtgcIDZapato,
            this.dtgcTotal,
            this.dtgcEmpleado,
            this.dtgcCantidad});
            this.dataGridView1.Location = new System.Drawing.Point(528, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(813, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // dtgcIDVenta
            // 
            this.dtgcIDVenta.HeaderText = "IDVenta";
            this.dtgcIDVenta.MinimumWidth = 6;
            this.dtgcIDVenta.Name = "dtgcIDVenta";
            this.dtgcIDVenta.ReadOnly = true;
            this.dtgcIDVenta.Width = 125;
            // 
            // dtgcFecha
            // 
            this.dtgcFecha.HeaderText = "Fecha";
            this.dtgcFecha.MinimumWidth = 6;
            this.dtgcFecha.Name = "dtgcFecha";
            this.dtgcFecha.ReadOnly = true;
            this.dtgcFecha.Width = 125;
            // 
            // dtgcIDZapato
            // 
            this.dtgcIDZapato.HeaderText = "IDZapato";
            this.dtgcIDZapato.MinimumWidth = 6;
            this.dtgcIDZapato.Name = "dtgcIDZapato";
            this.dtgcIDZapato.ReadOnly = true;
            this.dtgcIDZapato.Width = 125;
            // 
            // dtgcTotal
            // 
            this.dtgcTotal.HeaderText = "Total";
            this.dtgcTotal.MinimumWidth = 6;
            this.dtgcTotal.Name = "dtgcTotal";
            this.dtgcTotal.ReadOnly = true;
            this.dtgcTotal.Width = 125;
            // 
            // dtgcEmpleado
            // 
            this.dtgcEmpleado.HeaderText = "Empleado";
            this.dtgcEmpleado.MinimumWidth = 6;
            this.dtgcEmpleado.Name = "dtgcEmpleado";
            this.dtgcEmpleado.ReadOnly = true;
            this.dtgcEmpleado.Width = 125;
            // 
            // dtgcCantidad
            // 
            this.dtgcCantidad.HeaderText = "Cantidad";
            this.dtgcCantidad.MinimumWidth = 6;
            this.dtgcCantidad.Name = "dtgcCantidad";
            this.dtgcCantidad.ReadOnly = true;
            this.dtgcCantidad.Width = 125;
            // 
            // ConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoZapateria.Properties.Resources.FondoTenis6;
            this.ClientSize = new System.Drawing.Size(1353, 220);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpConsultaVentas);
            this.Name = "ConsultarVentas";
            this.Text = "ConsultarVentas";
            this.grpConsultaVentas.ResumeLayout(false);
            this.grpConsultaVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
    }
}