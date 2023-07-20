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

            // Obtener el valor ingresado en el TextBox de búsqueda
            string valorBusqueda = txtID.Text;

            // Realizar la consulta utilizando el valor de búsqueda
            string query = "SELECT z.Id_Zapato, z.Tipo_Calzado,z.Talla,z.Marca,z.Modelo,z.Color,z.Stock,z.Precio,P.Nombre FROM General.Zapato z inner join General.Proveedor P ON z.ID_Proveedor = p.ID_Provedor where ID_Zapato  = @ValorBusqueda"; // Reemplaza "MiTabla" y "CampoBusqueda" con los nombres adecuados

            // Crear una conexión y un adaptador para ejecutar la consulta y recuperar los datos.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dtgVentas.DataSource = dataTable;
                    int Cantidad = int.Parse(txtCantidad.Text);
                    
                    
                            // Obtener los valores de cada celda en la fila.
                            Cantidad = int.Parse(txtCantidad.Text);
                            string IDZapato = txtID.Text;
                            string precio = "Select Precio from general.zapato where Id_Zapato = @ID ";
                            SqlCommand comadno = new SqlCommand(precio, connection);
                            comadno.Parameters.AddWithValue("@ID", IDZapato);
                            comadno.ExecuteScalar();

                            int subtotal = Cantidad * int.Parse(comadno.ToString());
                            lblFechaActual.Text = Convert.ToString(DateTime.Now);
                           // Consulta SQL para insertar los datos en la nueva tabla.
                           DateTime valorColumna1 = DateTime.Now;
                            string insertQuery = "INSERT INTO General.Venta (Fecha, subtotal, Descuento,ID_Zapato,ID_Empleado) VALUES (@valorColumna1, @valorColumna2, @valorColumna3,@valorcolumna4,@valorcolumna5);";

                            // Crear el comando y agregar los parámetros.
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@valorColumna1", valorColumna1);
                                insertCommand.Parameters.AddWithValue("@valorColumna3", subtotal);
                                insertCommand.Parameters.AddWithValue("@valorColumna4", IDZapato);
                                insertCommand.Parameters.AddWithValue("valorcolumna5", cmbEmpleados.SelectedIndex);
                                // Ejecutar la consulta de inserción.
                                insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Se ha ingresado correctamente");
                            }
                        

                    
                }
                catch (Exception ex)
                {
                    // Manejo de errores, si es necesario.
                    Console.WriteLine(ex.Message);
                }
            }
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
            ObtenerEmpleados();
            CargarDatagrid();
        }

        public void ObtenerEmpleados()
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

        public void CargarDatagrid()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string consultaSQL = "Select * from [General].[Venta]";//"SELECT ID_Venta,Fecha,Subtotal,Descuento,Total from [General].[Venta] "; // Reemplaza con tu consulta SQL para obtener los nuevos datos
                    using (SqlCommand comando = new SqlCommand(consultaSQL, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                            DataTable tablaDatos = new DataTable();
                            adaptador.Fill(tablaDatos);
                            dtgVentas.DataSource = tablaDatos; // Asigna la tabla como origen de datos para el DataGridView
                        }
                        catch (Exception ex)
                        {
                            // Manejo de excepciones (puedes mostrar un mensaje de error, por ejemplo)
                            MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string Busqueda = "";
            if (cmbBusqueda.SelectedIndex == 0)
            {
                Busqueda = txtID.Text;
            }
            else if (cmbBusqueda.SelectedIndex == 1)
            {
                Busqueda = txtTalla.Text;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Consulta SQL para recuperar los datos que deseas mostrar en el DataGridView.
            // Obtener el valor ingresado en el TextBox de búsqueda
            string valorBusqueda = txtID.Text;

            // Realizar la consulta utilizando el valor de búsqueda
            string query = "SELECT z.Id_Zapato, z.Tipo_Calzado,z.Talla,z.Marca,z.Modelo,z.Color,z.Stock,z.Precio,P.Nombre FROM General.Zapato z inner join General.Proveedor P ON z.ID_Proveedor = p.ID_Provedor where ID_Zapato  = @ValorBusqueda"; // Reemplaza "MiTabla" y "CampoBusqueda" con los nombres adecuados

            // Crear una conexión y un adaptador para ejecutar la consulta y recuperar los datos.
            SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    MessageBox.Show("Si entra loco");
                    connection.Open();
                    int Cantidad = int.Parse(txtCantidad.Text);
                    // Obtener los valores de cada celda en la fila.
                    Cantidad = int.Parse(txtCantidad.Text);
                    string IDZapato = txtID.Text;
                    string precio = "Select Precio from general.zapato where Id_Zapato = @ID ";
                    SqlCommand comadno = new SqlCommand(precio, connection);
                    comadno.Parameters.AddWithValue("@ID", IDZapato);
                    comadno.ExecuteScalar();
                    connection.Close();
                    int subtotal = Cantidad * int.Parse(comadno.ToString());
                    lblFechaActual.Text = Convert.ToString(DateTime.Now);
                    // Consulta SQL para insertar los datos en la nueva tabla.
                    DateTime valorColumna1 = DateTime.Now;
                    string insertQuery = "INSERT INTO General.Venta (Fecha, subtotal, Descuento,ID_Zapato,ID_Empleado) VALUES (@valorColumna1, @valorColumna3, @Valor,@valorcolumna4,@valorcolumna5);";
                    
                    // Crear el comando y agregar los parámetros.
                    connection.Open();
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    
                        insertCommand.Parameters.AddWithValue("@valorColumna1", valorColumna1);
                        insertCommand.Parameters.AddWithValue("@valorColumna3", subtotal);
                        insertCommand.Parameters.AddWithValue("@Valor", 0.0);
                        insertCommand.Parameters.AddWithValue("@valorColumna4", IDZapato);
                        insertCommand.Parameters.AddWithValue("valorcolumna5", cmbEmpleados.SelectedIndex);
                        // Ejecutar la consulta de inserción.
                        insertCommand.ExecuteScalar();
                        MessageBox.Show("Se ha ingresado correctamente");

                    CargarDatagrid();



                }
                catch (Exception ex)
                {
                    // Manejo de errores, si es necesario.
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

