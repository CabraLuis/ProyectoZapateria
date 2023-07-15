
using System;
using System.Windows.Forms;
using System.Data.SqlClient; //LIBIRERIA PARA CONECTAR BASE DE DATOS SQL
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoZapateria

{
    public partial class ZapateriaForm : Form
    {
        public ZapateriaForm()
        {
            InitializeComponent();
        }

        private void ZapateriaForm_Load(object sender, EventArgs e)
        {
            // Obtener la hora actual
            DateTime now = DateTime.Now;

            // Darle forma a la hora actual
            string horaActual = now.ToString("HH:mm:ss");

            // Construir el mensaje de bienvenida
            string mensajeBienvenida = "            Bienvenido/a.\nLa hora actual es: " + horaActual;

            // Mostrar el mensaje de bienvenida en el control Label
            lblBienvenida.Text = mensajeBienvenida;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TxtUsuario.Text;
            string contraseña = TxtContrasena.Text;

            // Establecer la conexión con SQL Server
            string connectionString = "server=LAPTOP-I1BSF5OM\\SQLEXPRESS ; database=PuntoVenta ; integrated security = true";// Data Source=server;Initial Catalog=database;User ID=username;Password=password;";
            SqlConnection connection = new SqlConnection(connectionString);
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TipoUser FROM Usuarios WHERE Nom_User = @NombreUsuario AND Contra = @Contraseña";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    object tipoUsuario = command.ExecuteScalar();

                    if (tipoUsuario != null)
                    {
                        // El usuario ha iniciado sesión correctamente
                        string tipoUsuarioString = tipoUsuario.ToString();                   
                        switch (tipoUsuarioString)
                        {
                            case "Administrador":
                                // Lógica para el usuario administrador
                                MessageBox.Show("Si entras perrio");
                                Limpiar();
                                break;
                            case "Empleado":
                                // Lógica para el usuario normal
                                break;                           
                        }
                    }
                    else
                    {                    
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de conexión
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
        }
        public void Limpiar()
        {
          
            TxtContrasena.Text = string.Empty;
            TxtUsuario.Text = string.Empty;

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}