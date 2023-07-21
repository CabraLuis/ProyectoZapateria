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
    public partial class ConsultarVentas : Form
    {
        public ConsultarVentas()
        {
            InitializeComponent();
        }
        public string connectionString = "server=LAPTOP-I1BSF5OM\\SQLEXPRESS; database=Zapateria ; integrated security = true";// Data Source=server;Initial Catalog=database;User ID=username;Password=password;";
       
        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        public  DataTable GetRegistrosEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM registros WHERE fecha BETWEEN @FechaInicio AND @FechaFin";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener los datos: " + ex.Message);
                }
            }
            return dataTable;
        }
    }
}






