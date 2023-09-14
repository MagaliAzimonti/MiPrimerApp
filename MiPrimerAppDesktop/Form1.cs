namespace MiPrimerAppDesktop
{
    public partial class Form1 : Form
    {

        const string EMPRESA = "Maga S.A.";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = EMPRESA;

            lblTitulo.Text = "Esto es " + EMPRESA;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = "";

            nombre = txtValorNombre.Text;

  

            lblResultado.Text = "Hola " + nombre + " bienvenido a " + EMPRESA;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBoxHombre_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}