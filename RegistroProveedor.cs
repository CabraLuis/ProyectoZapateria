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
        string connectionString = "server=LAPTOP-I1BSF5OM\\SQLEXPRESS; database=PuntoVenta ; integrated security = true";// Data Source=server;Initial Catalog=database;User ID=username;Password=password;";
        string consulta = "";
        GenerarVenta Venta2 = new GenerarVenta();
        public RegistroProveedor()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

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
                  
            
            if (radActualizarProveedor.Checked)
            {

            }
            else if (radAgregarProveedor.Checked)
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                command.Parameters.AddWithValue("@IdProveedor", txtNombre.Tag);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@telefono", Telefono);
            }
            else if (radEliminarProveedor.Checked)
            {

            }

        }

        private void radAgregarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Agregar";
            consulta = "INSERT INTO PROVEEDOR(ID_Provedor,Nombre,Telefono,Direccion) VALUES(@Idproveedor,@Nombre,@Telefono,@Direccion)";
        }

        private void radActualizarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Actualizar";
        }

        private void radEliminarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Eliminar";
        }

        private void RegistroProveedor_Load(object sender, EventArgs e)
        {
            radAgregarProveedor.Checked = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Venta2.Show();
            this.Hide();
        }
    }
}
