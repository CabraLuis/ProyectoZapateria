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
                    }
                }
                else if (radEliminarProveedor.Checked)
                {

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

        }
    }
}
