namespace M01A08B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            lblSmg.Text = "Muito prazer em te conhecer, " + nome + "!";
            lblSmg.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}