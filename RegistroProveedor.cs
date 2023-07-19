using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //LIBIRERIA PARA CONECTAR BASE DE DATOS SQL
using System.Net.Sockets;
using System.Collections;

namespace ProyectoZapateria
{
    public partial class RegistroProveedor : Form
    {
        public RegistroProveedor()
        {
            InitializeComponent();
        }

        private void RegistroProveedor_Load(object sender, EventArgs e)
        {
            if (radActualizarProveedor.Checked) { btnAccion.Text = "Actualizar"; }
            if (radAgregarProveedor.Checked) { btnAccion.Text = "Agregar"; }
            if (radEliminarProveedor.Checked) { btnAccion.Text = "Eliminar"; }
        }

        private void radAgregarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Agregar";
        }

        private void radActualizarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Actualizar";
        }

        private void radEliminarProveedor_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Eliminar";
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            string connectionString = "server=LAPTOP-I1BSF5OM\\SQLEXPRESS ; database=PuntoVenta ; integrated security = true";// Data Source=server;Initial Catalog=database;User ID=username;Password=password;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //Sentencia para sacar el ID del proveedor
            string ase = "Select Count(*) from Proveedor";
            SqlCommand command2 = new SqlCommand(ase, connection);
            object d = command2.ExecuteScalar();
            d.GetType();
            int a = Convert.ToInt32(d);
            a = a + 1;
            {
                try
                {
                    if(radAgregarProveedor.Checked == true)
                    {
                        //Insercion de un nuevo proveedor
                        //connection.Open();
                        string query = "INSERT INTO Proveedor (ID_Provedor,Nombre,Telefono,Direccion) VALUES(@ID_Proveedor,@Nombre,@Direccion,@Telefono)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Proveedor", a);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        object Datos = command.ExecuteScalar();
                        MessageBox.Show("Datos Ingresados Correctamente");
                        connection.Close();
                    }  
                    else if (radActualizarProveedor.Checked == true)
                    {

                    }
                    else if (radEliminarProveedor.Checked == true)
                    {
                        //Insercion de un nuevo proveedor
                        //connection.Open();
                        string query = "Delete from Proveedor (ID_Provedor,Nombre,Telefono,Direccion) VALUES(@ID_Proveedor,@Nombre,@Direccion,@Telefono)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Proveedor", a);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        object Datos = command.ExecuteScalar();
                        MessageBox.Show("Proveedor Eliminado Correctamente");
                        connection.Close();
                    } 
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de conexión
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
        }

        public void MostrarDatos()
        {
           
        }
    }
}
