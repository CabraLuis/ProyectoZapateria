using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grpDatosCalzado_Enter(object sender, EventArgs e)
        {

        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se a realizado la venta correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Question);
           GenerarVenta generarVenta = new GenerarVenta();
            generarVenta.Show();
            this.Hide();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            ObtenerEmpleados();
            CargarDatagrid();
            lblFechaActual.Text = (DateTime.Now).ToString();

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
                            try
                            {
                                connection.Open();
                                string query = "SELECT * FROM General.Venta";
                                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dtgVentas.DataSource = dt;
                            }
                            catch (Exception ex) { }
                            // Asigna la tabla como origen de datos para el DataGridView
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
            try
            {
                // MessageBox.Show("Que rollo si entro");
                string Nombre = txtNombreCliente.Text;
                string Apellido = txtApellido.Text;
                string Direccion = txtDireccion.Text;
                string Telefono = txtTelefono.Text;

                DateTime Fecha = DateTime.Now;
                int idzapato = int.Parse(txtID.Text);
                int idempleado = cmbEmpleados.SelectedIndex + 3;
                int cantidad = int.Parse(txtCantidad.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    MessageBox.Show("Sigo");
                    try
                    {
                        connection.Open();
                        //MessageBox.Show("Otra vez");
                        // Agregar el cliente y obtener su ID
                        string clienteQuery = $"INSERT INTO [General].[Cliente] (Nombre, Apellido, Direccion, Telefono) VALUES (@Nombre, @Apellido, @Direccion, @Telefono); SELECT SCOPE_IDENTITY();";
                        SqlCommand clienteCommand = new SqlCommand(clienteQuery, connection);
                        clienteCommand.Parameters.AddWithValue("@Nombre", Nombre);
                        clienteCommand.Parameters.AddWithValue("@Apellido", Apellido);
                        clienteCommand.Parameters.AddWithValue("@Direccion", Direccion);
                        clienteCommand.Parameters.AddWithValue("@Telefono", Telefono);
                        int idCliente = Convert.ToInt32(clienteCommand.ExecuteScalar());

                        // Obtener el precio del zapato
                        string precioQuery = "SELECT Precio FROM [General].Zapato WHERE ID_Zapato = @IDzapato";
                        SqlCommand precioCommand = new SqlCommand(precioQuery, connection);
                        precioCommand.Parameters.AddWithValue("@IDzapato", idzapato);
                        int precio = Convert.ToInt32(precioCommand.ExecuteScalar());

                        int subtotal = precio * cantidad;

                        // Agregar la venta utilizando el ID del cliente registrado
                        string query = "INSERT INTO [General].Venta (Fecha, Subtotal, Descuento, Total, Id_Cliente, Id_Zapato, Id_Empleado) VALUES (@Fecha, @Subtotal, @Descuento, @Total, @IDCliente, @IDZapato, @IDEmpleado)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Fecha", Fecha);
                        command.Parameters.AddWithValue("@Subtotal", subtotal);
                        command.Parameters.AddWithValue("@Descuento", 0);
                        command.Parameters.AddWithValue("@Total", subtotal);
                        command.Parameters.AddWithValue("@IDCliente", idCliente);
                        command.Parameters.AddWithValue("@IDZapato", idzapato);
                        command.Parameters.AddWithValue("@IDEmpleado", idempleado);
                        command.ExecuteNonQuery();
                        //MessageBox.Show("SI terminar");
                        MessageBox.Show("Cliente y venta agregados correctamente.");
                        connection.Close();
                        CargarDatagrid();
                    }

                    // Crear una conexión y un adaptador para ejecutar la consulta y recuperar los datos.
                    //SqlConnection connection = new SqlConnection(connectionString);
                    //    try
                    //    {
                    //    string Nombre = txtNombreCliente.Text;
                    //    string Apellido = txtApellido.Text;
                    //   string direccion = txtDireccion.Text;
                    //    string Telefono = txtTelefono.Text;
                    //    DateTime Fecha = DateTime.Now;
                    //    int idzapato = int.Parse(txtID.Text);
                    //    int idempleado = cmbEmpleados.SelectedIndex;
                    //    string query = $"INSERT INTO [General].Cliente (Nombre,Apellido,Direccion,Telefono) VALUES (@Nombre,@Apellido,@Direccion,@Telefono)";
                    //    SqlCommand command = new SqlCommand(query, connection);
                    //    connection.Open();
                    //    command.Parameters.AddWithValue("@Nombre", Nombre);
                    //    command.Parameters.AddWithValue("@Apellido", Apellido);
                    //    command.Parameters.AddWithValue("@Direccion", direccion);
                    //    command.Parameters.AddWithValue("@Telefono", Telefono);
                    //    command.ExecuteScalar();
                    //    connection.Close();
                    //    string q = "Select Precio from General.Zapato where ID_Zapato = @IDzapato";
                    //    SqlCommand ay = new SqlCommand(q, connection);
                    //   connection.Open();

                    //    ay.Parameters.AddWithValue("IDZapato", idzapato);
                    //    object ojo = ay.ExecuteScalar();
                    //    int subtotal = int.Parse(ojo.ToString()) * int.Parse(txtCantidad.Text) ;
                    //    string cliente = "Select ID_Cliente from General.Cliente where Nombre = @Nombre";
                    //    SqlCommand cleinte = new SqlCommand(q, connection);
                    //    cleinte.Parameters.AddWithValue("@Nombre",txtNombreCliente.Text);
                    //   object idclientea = cleinte.ExecuteScalar();
                    //    string IDEMpleado = idclientea.ToString();
                    //    string querys = $"INSERT INTO [General].Venta (Fecha,Subtotal,Descuento,Total,Id_Cliente,Id_Zaoato,ID_Empleaod,) VALUES (@Fecha,@Subtotal,@Descuento,@Total,@ID_cliente,@IDZapato,@IDEmpleado)";
                    //    SqlCommand commando = new SqlCommand(querys, connection);
                    //    commando.Parameters.AddWithValue("@Fecha", Fecha);
                    //    commando.Parameters.AddWithValue("@Subotal", subtotal);
                    //    commando.Parameters.AddWithValue("@Descuento", 0);
                    //    commando.Parameters.AddWithValue("@Total", subtotal);
                    //    commando.Parameters.AddWithValue("@ID_cliente", IDEMpleado);
                    //    commando.Parameters.AddWithValue("@IDZapato", idzapato);
                    //    commando.Parameters.AddWithValue("@IDEmpleado", idempleado);

                    //    command.ExecuteScalar();
                    //    MessageBox.Show("Se han agregado correctamente los datos", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    MessageBox.Show("Se ha ingresado correctamente");

                    //        CargarDatagrid();




                    catch (Exception ex)
                    {
                        // Manejo de errores, si es necesario.
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch { }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            GenerarVenta ef = new GenerarVenta();
            ef.Show();
            this.Hide();
        }
    }
}

