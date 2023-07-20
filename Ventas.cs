using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoZapateria
{
    public partial class Ventas : Form
    {
        public string usuario;
        public Ventas(string usuari)
        {
            InitializeComponent();
            this.usuario = usuari;
        }
        public string connectionString = "server=LAPTOP-I1BSF5OM\\SQLEXPRESS; database=Zapateria ; integrated security = true";
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grpDatosCalzado_Enter(object sender, EventArgs e)
        {

        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        public void ObtenerProveedores()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string schemaName = "General";
                    string tableName = "Empleado";
                    string columnName = "Nombre";
                    // Reemplaza "nombre_esquema", "nombre_tabla" y "nombre_columna" con los nombres adecuados del esquema, tabla y columna que deseas mostrar en el ComboBox.

                    string query = $"SELECT {columnName} FROM [{schemaName}].[{tableName}] Order by ID_Empleado ASC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            cmbEmpleados.DataSource = dataTable;
                            cmbEmpleados.DisplayMember = columnName;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
