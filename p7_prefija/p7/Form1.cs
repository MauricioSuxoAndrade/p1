using BibliotecaPrefija;
namespace p7
{
    public partial class Form1 : Form
    {
        private string expresion = "";
        private NotacionPrefija nPre = new NotacionPrefija();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void BotonNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pantalla.Text += btn.Text + " ";
        }

        private void BotonOperador_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pantalla.Text += btn.Text + " ";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = nPre.Evaluar(pantalla.Text); 
                pantalla.Text = resultado.ToString(); 
                expresion = string.Empty; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Text = "";
        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
