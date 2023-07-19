
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
            string contrase�a = TxtContrasena.Text;
  

      
                string connectionString = "Data Source=tu_servidor;Initial Catalog=nombre_basededatos;User ID=nombre_login;Password=tu_contrase�a;";

                // Reemplaza los valores adecuados en la cadena de conexi�n

               

                bool isValid = ValidateLogin(connectionString, nombreUsuario, contrase�a);

                if (isValid)
                {
                    Console.WriteLine("Inicio de sesi�n v�lido.");
                    // Aqu� puedes redirigir al usuario a la p�gina principal, realizar otras operaciones, etc.
                }
                else
                {
                    Console.WriteLine("Inicio de sesi�n inv�lido.");
                }

                Console.ReadLine();
            }

            static bool ValidateLogin(string connectionString, string username, string password)
            {
                bool isValid = false;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM [nombre_esquema].[nombre_tabla] WHERE Username = @Username AND Password = @Password";
                        // Reemplaza [nombre_esquema].[nombre_tabla] con el esquema y la tabla adecuados donde almacenas los datos de inicio de sesi�n.

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);

                            int count = (int)command.ExecuteScalar();
                            isValid = count > 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }

                return isValid;
            
        
    

    //// Establecer la conexi�n con SQL Server
    //string connectionString = "server=LAPTOP-I1BSF5OM\\SQLEXPRESS; database=PuntoVenta ; integrated security = true";// Data Source=server;Initial Catalog=database;User ID=username;Password=password;";
    //SqlConnection connection = new SqlConnection(connectionString);
    //{
    //    try
    //    {
    //        connection.Open();
    //        string query = "SELECT TipoUser FROM Usuarios WHERE Nom_User = @NombreUsuario AND Contra = @Contrase�a";
    //        string query2 = "SELECT Sexo FROM Usuarios where Nom_User =@NombreUsuario";
    //        SqlCommand command = new SqlCommand(query, connection);
    //        SqlCommand command2 = new SqlCommand(query2, connection);
    //        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
    //        command.Parameters.AddWithValue("@Contrase�a", contrase�a);
    //        command2.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
    //        command2.Parameters.AddWithValue("@Contrase�a", contrase�a);



    //        object tipoUsuario = command.ExecuteScalar();
    //        object sexo = command2.ExecuteScalar();
    //        if (tipoUsuario != null)
    //        {
    //            // El usuario ha iniciado sesi�n correctamente
    //            string tipoUsuarioString = tipoUsuario.ToString();
    //            GenerarVenta GenerarVenta = new GenerarVenta(sexo);
    //            switch (tipoUsuarioString)
    //            {

    //                case "Administrador":
    //                    // L�gica para el usuario administrador
    //                    MessageBox.Show("Si entras perrio");

    //                    GenerarVenta.Show();
    //                    Limpiar();
    //                    break;
    //                case "Empleado":
    //                    // L�gica para el usuario normal

    //                    GenerarVenta.Show();
    //                    this.Hide();

    //                    break;                           
    //            }
    //        }
    //        else
    //        {                    
    //            MessageBox.Show("Nombre de usuario o contrase�a incorrectos.");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        // Manejar cualquier error de conexi�n
    //        MessageBox.Show("Error de conexi�n: " + ex.Message);
    //    }
    //}
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