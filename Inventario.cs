using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoZapateria
{
    public partial class Inventario : Form
    {
        public string Usuario;
        public Inventario(string user)
        {
            InitializeComponent();
            Usuario = user;
        }
        public string connectionString = "server=LAPTOP-I1BSF5OM\\SQLEXPRESS; database=Zapateria ; integrated security = true";// Data Source=server;Initial Catalog=database;User ID=username;Password=password;";

        private void btnAccion_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                string tipo = txtTipoCalzado.Text;
                string Talla = txtTalla.Text;
                string Marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                string color = txtColor.Text;
                SqlMoney money = SqlMoney.Parse(txtPrecio.Text);
                int stock = int.Parse(txtExistencias.Text);
                int idprov = cmbProveedores.SelectedIndex + 3;
                if (HabilitarTextBox(grpDatosZapato) > 0)
                {
                    MessageBox.Show("Favor de ingresar de rellenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (radAgregar.Checked)
                    {
                        string query = $"INSERT INTO [General].[Zapato] (Tipo_Calzado,Talla,Marca,Modelo,Color,Precio,Stock,ID_Proveedor) VALUES (@TipoCalzado,@Talla,@Marca,@Modelo,@Color,@Precio,@Stock,@ID_Proveedor)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@TipoCalzado", tipo);
                        command.Parameters.AddWithValue("@Talla", Talla);
                        command.Parameters.AddWithValue("@Marca", Marca);
                        command.Parameters.AddWithValue("@Modelo", modelo);
                        command.Parameters.AddWithValue("@Color", color);
                        command.Parameters.AddWithValue("@Precio", money);
                        command.Parameters.AddWithValue("@Stock", stock);
                        command.Parameters.AddWithValue("@ID_Proveedor", idprov);
                        command.ExecuteScalar();
                        MessageBox.Show("Se han agregado correctamente los datos", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatagrid();
                        Limpiar(dtgDatosZapatos);
                        connection.Close();
                    }
                    if (radActualizar.Checked)
                    {
                        string query = $"Update [General].[Zapato] (Set Tipo_Calzado = @TipoCalzado, Set Talla = @Talla, Set Marca = @Marca, Set Modelo = @Modelo, Set Color = @Color, Set Precio = @Precio,Set Stock = @Stock, Set ID_Proveedor = @ID_Proveedor)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@TipoCalzado", txtTipoCalzado.Text);
                        command.Parameters.AddWithValue("@Talla", int.Parse(txtTalla.Text));
                        command.Parameters.AddWithValue("@Marca", txtMarca.Text);
                        command.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                        command.Parameters.AddWithValue("@Color", txtColor.Text);
                        command.Parameters.AddWithValue("@Precio", SqlMoney.Parse(txtPrecio.Text));
                        command.Parameters.AddWithValue("@Stock", int.Parse(txtExistencias.Text));
                        command.Parameters.AddWithValue("@ID_Proveedor", cmbProveedores.SelectedIndex);
                        command.ExecuteScalar();
                        MessageBox.Show("Se han agregado correctamente los datos", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatagrid();
                        Limpiar(dtgDatosZapatos);
                        connection.Close();
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }

        private void radAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (Usuario == "Administrador")
            {

            }
            btnAccion.Text = "Agregar";
            btnBuscar.Enabled = false;
            HabilitarTextBox(grpDatosZapato);
            txtID.Visible = false;
            lblcod.Visible = false;
        }

        private void radActualizar_CheckedChanged(object sender, EventArgs e)
        {
            btnAccion.Text = "Actualizar";
            btnBuscar.Enabled = true;
            InabilitarTextBox(grpDatosZapato);
            txtID.Enabled = true;
            txtID.Visible = true;
            lblcod.Visible = true;
        }

        public void CargarDatagrid()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string consultaSQL = "SELECT * from [General].[Zapato]"; // Reemplaza con tu consulta SQL para obtener los nuevos datos


                    using (SqlCommand comando = new SqlCommand(consultaSQL, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                            DataTable tablaDatos = new DataTable();
                            adaptador.Fill(tablaDatos);
                            dtgDatosZapatos.DataSource = tablaDatos; // Asigna la tabla como origen de datos para el DataGridView
                        }
                        catch (Exception ex)
                        {
                            // Manejo de excepciones (puedes mostrar un mensaje de error, por ejemplo)
                            MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    //connection.Open();
                    //dtgDatosZapatos.Refresh();
                    //string schemaName = "General";
                    //string tableName = "Zapato";
                    //string query = $"SELECT Tipo_Calzado,Talla,Marca,Modelo,Color,Precio,Stock,ID_Proveedor FROM [{schemaName}].[{tableName}]";

                    //using (SqlCommand command = new SqlCommand(query, connection))
                    //{
                    //    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    //    {
                    //        DataTable dataTable = new DataTable();
                    //        adapter.Fill(dataTable);
                    //        dtgDatosZapatos.DataSource = dataTable;
                    //    }
                    //}
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
            string query = "SELECT z.Id_Zapato, z.Tipo_Calzado,z.Talla,z.Marca,z.Modelo,z.Color,z.Stock,z.Precio,P.Nombre FROM General.Zapato z inner join General.Proveedor P ON z.ID_Proveedor = p.ID_Provedor where ID_Zapato  = @ValorBusqueda"; // Reemplaza "MiTabla" y "CampoBusqueda" con los nombres adecuados

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ValorBusqueda", valorBusqueda);
                    command.ExecuteScalar();
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
                            txtTalla.Text = Convert.ToString(Talla);
                            txtMarca.Text = Marca;
                            txtModelo.Text = Modelo;
                            txtColor.Text = Color;
                            txtExistencias.Text = Convert.ToString(Stock);
                            txtPrecio.Text = Precio;
                            cmbProveedores.SelectedIndex = int.Parse(reader["ID_Proveedor"].ToString());

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
            lblcod.Visible = false;
            txtID.Visible = false;
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

        public int HabilitarTextBox(Control container)
        {
            int a = 0;
            foreach (Control control in container.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == null) { a++; }
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = true;
                    //textBox.Text = default;

                }

            }
            return a;
        }
        public void Limpiar(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox)
                {

                    control.Text = default;

                }

            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            GenerarVenta zapateria = new GenerarVenta();
            zapateria.Show();
            this.Hide();
        }

        private void grpDatosZapato_Enter(object sender, EventArgs e)
        {

        }
    }
}


