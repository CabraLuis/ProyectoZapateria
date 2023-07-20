using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoZapateria
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        public string connectionString = "server=LAPTOP-I1BSF5OM\\SQLEXPRESS; database=PuntoVenta ; integrated security = true";// Data Source=server;Initial Catalog=database;User ID=username;Password=password;";

        private void btnAccion_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                if (radAgregar.Checked)
                {
                    string query = $"INSERT INTO [General].[Zapato] (ID_Zapato,Tipo_Calzado,Talla,Marca,Modelo,Color,Precio,Stock,ID_Proveedor) VALUES (@Id_Zapato, @TipoCalzado,@Talla,@Marca,@Modelo,@Color,@Precio,@Stock,@ID_Proveedor)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id_Zapato", txtID.Text);
                    command.Parameters.AddWithValue("@TipoCalzado", txtTipoCalzado.Text);
                    command.Parameters.AddWithValue("@Talla", int.Parse(txtTalla.Text));
                    command.Parameters.AddWithValue("@Marca", txtMarca.Text);
                    command.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                    command.Parameters.AddWithValue("@Color", txtColor.Text);
                    command.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio.Text));
                    command.Parameters.AddWithValue("@Stock", int.Parse(txtExistencias.Text));
                    command.Parameters.AddWithValue("@ID_Proveedor", cmbProveedores.SelectedIndex);
                    command.ExecuteScalar();
                    MessageBox.Show("Se han agregado correctamente los datos", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatagrid();
                    connection.Close();
                }
                if (radActualizar.Checked)
                {

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }

        private void radAgregar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Agregar";
            btnBuscar.Enabled = false;
        }

        private void radActualizar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Actualizar";
            btnBuscar.Enabled = true;
            InabilitarTextBox(grpDatosZapato);
            txtID.Enabled = true;
        }

        public void CargarDatagrid()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    dtgDatosZapatos.Refresh();
                    string schemaName = "General";
                    string tableName = "Zapato";
                    string query = $"SELECT * FROM [{schemaName}].[{tableName}]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dtgDatosZapatos.DataSource = dataTable;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el valor ingresado en el TextBox de búsqueda
            string valorBusqueda = txtID.Text;

            // Realizar la consulta utilizando el valor de búsqueda
            string query = "SELECT Id_Zapato, Tipo_Calzado,Talla,Marca,Modelo,Color,Stock,Precio,P.Nombre FROM General.Zapato inner join General.Proveedor P ON General.Zapato. WHERE ID_Zapato  = @ValorBusqueda"; // Reemplaza "MiTabla" y "CampoBusqueda" con los nombres adecuados

            SqlConnection connection = new SqlConnection(connectionString);
            
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ValorBusqueda", valorBusqueda);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Si se encuentra el registro, llenar los controles con los datos obtenidos
                                string id = reader["Id_Zapato"].ToString();
                                string Tipo = reader["Tipo_Calzado"].ToString();
                                int Talla = int.Parse(reader["Talla"].ToString());
                                string Marca = reader["Marca"].ToString();
                                string Modelo = reader["Modelo"].ToString();
                                string Color = reader["Color"].ToString();
                                int Stock = int.Parse(reader["Stock"].ToString());
                                string Precio = reader["Precio"].ToString();
                                txtID.Text = id;
                                txtTipoCalzado.Text = Tipo;
                                
                            }
                            else
                            {
                                // Si no se encuentra el registro, mostrar un mensaje o realizar alguna acción adicional
                                MessageBox.Show("No se encontró el registro.");
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

        private void Inventario_Load(object sender, EventArgs e)
        {
            radAgregar.Checked = true;
            ObtenerProveedores();
            CargarDatagrid();
        }

        public void ObtenerProveedores()
        {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string schemaName = "General";
                        string tableName = "Proveedor";
                        string columnName = "Nombre";
                        // Reemplaza "nombre_esquema", "nombre_tabla" y "nombre_columna" con los nombres adecuados del esquema, tabla y columna que deseas mostrar en el ComboBox.

                        string query = $"SELECT {columnName} FROM [{schemaName}].[{tableName}] Order by ID_Provedor ASC";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                cmbProveedores.DataSource = dataTable;
                                cmbProveedores.DisplayMember = columnName;
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
        public void InabilitarTextBox(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = false;
                }
            }
        }

    }
}


