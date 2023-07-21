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
    public partial class RegistroProveedor : Form
    {
        string connectionString = "server=LAPTOP-I1BSF5OM\\SQLEXPRESS; database=Zapateria ; integrated security = true";// Data Source=server;Initial Catalog=database;User ID=username;Password=password;";
        string consulta = "";
        public string usuario;

        public RegistroProveedor(string usuari)
        {
            InitializeComponent();
            usuario = usuari;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            GenerarVenta Venta2 = new GenerarVenta(usuario);
            Venta2.Show();
            this.Hide();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = ""; //"SELECT TipoUser FROM Usuarios WHERE Nom_User = @NombreUsuario AND Contra = @Contraseña";
            string Nombre = txtNombre.Text;
            string Telefono = txtTelefono.Text;
            string Direccion = txtDireccion.Text;

            try
            {
                if (radActualizarProveedor.Checked)
                {
                    if (txtDireccion.Text == null || txtNombre.Text == null || txtTelefono.Text == null)
                    {
                        MessageBox.Show("Favor de llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        consulta = $"Update[General].[Proveedor] Set Nombre = @Nomre,Telefono = @Telefono,Direccion=@Direccion";
                        SqlCommand command = new SqlCommand(consulta, connection);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        command.ExecuteScalar();
                        connection.Close();
                        MessageBox.Show("Se han guardado los datos correctamente");
                        limpiar();
                        CargarDatagrid();
                    }
                }
                else if (radAgregarProveedor.Checked)
                {
                    if (txtDireccion.Text == null || txtNombre.Text == null || txtTelefono.Text == null)
                    {
                        MessageBox.Show("Favor de llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        consulta = $"INSERT INTO [General].[Proveedor] (Nombre,Telefono,Direccion) VALUES(@Nombre,@Telefono,@Direccion)";
                        SqlCommand command = new SqlCommand(consulta, connection);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        command.ExecuteScalar();
                        connection.Close();
                        MessageBox.Show("Se han guardado los datos correctamente");
                        limpiar();
                        CargarDatagrid();
                    }
                }
                else if (radEliminarProveedor.Checked)
                {
                    if (txtDireccion.Text == null || txtNombre.Text == null || txtTelefono.Text == null)
                    {
                        MessageBox.Show("Favor de llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        consulta = $"Delete [General].[Proveedor] where Nombre = Nombre";
                        SqlCommand command = new SqlCommand(consulta, connection);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        command.ExecuteScalar();
                        connection.Close();
                        MessageBox.Show("Se han guardado los datos correctamente");
                        limpiar();
                        CargarDatagrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void radAgregarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Agregar";
            btnBuscar.Visible = false;
        }

        private void radActualizarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Actualizar";
            btnBuscar.Visible = true;
        }

        private void radEliminarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Eliminar";
            btnBuscar.Visible = true;
        }

        private void RegistroProveedor_Load(object sender, EventArgs e)
        {
            radAgregarProveedor.Checked = true;
            btnAccion.Text = "Agregar";
            btnBuscar.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            GenerarVenta Venta2 = new GenerarVenta(usuario);
            Venta2.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el valor ingresado en el TextBox de búsqueda


            // Realizar la consulta utilizando el valor de búsqueda


            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string valorBusqueda = txtNombre.Text;
                string query = "Select Nombre,Direccion,Telefono from General.Proveedor";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ValorBusqueda", valorBusqueda);
                    command.ExecuteScalar();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Si se encuentra el registro, llenar los controles con los datos obtenidos
                            string id = reader["Nombre"].ToString();
                            string Tipo = reader["Direccion"].ToString();
                            int Talla = int.Parse(reader["Telefono"].ToString());

                            txtNombre.Text = id;
                            txtDireccion.Text = Tipo;
                            txtTelefono.Text = Convert.ToString(Talla);
                            CargarDatagrid();

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

        public void CargarDatagrid()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string consultaSQL = "SELECT * from [General].[Proveedor]"; // Reemplaza con tu consulta SQL para obtener los nuevos datos


                    using (SqlCommand comando = new SqlCommand(consultaSQL, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                            DataTable tablaDatos = new DataTable();
                            adaptador.Fill(tablaDatos);
                            dtgDatosProveedores.DataSource = tablaDatos; // Asigna la tabla como origen de datos para el DataGridView
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

        public void limpiar()
        {
            txtDireccion.Text = default;
            txtNombre.Text = default;
            txtTelefono.Text = default;
        }

    }
}
