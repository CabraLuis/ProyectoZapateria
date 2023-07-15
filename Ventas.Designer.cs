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
            grpDatosCalzado = new GroupBox();
            SuspendLayout();
            // 
            // grpDatosCalzado
            // 
            grpDatosCalzado.Location = new Point(12, 12);
            grpDatosCalzado.Name = "grpDatosCalzado";
            grpDatosCalzado.Size = new Size(262, 172);
            grpDatosCalzado.TabIndex = 0;
            grpDatosCalzado.TabStop = false;
            grpDatosCalzado.Text = "Datos Calzado:";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpDatosCalzado);
            Name = "Ventas";
            Text = "Ventas";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosCalzado;
    }
}