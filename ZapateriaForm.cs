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

            // Formatear la hora actual como una cadena
            string horaActual = now.ToString("HH:mm:ss");

            // Construir el mensaje de bienvenida
            string mensajeBienvenida = "            Bienvenido/a.\nLa hora actual es: " + horaActual;

                // Mostrar el mensaje de bienvenida en el control Label
                lblBienvenida.Text = mensajeBienvenida;
            

        }
    }
}