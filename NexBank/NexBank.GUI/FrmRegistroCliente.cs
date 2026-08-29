using Nexbank.Logica;

namespace NexBank.GUI
{
    public partial class FrmRegistroCliente : Form
    {
        public FrmRegistroCliente()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {
            Cliente cln = new Cliente();
            dtgvLista.DataSource = cln.ListarClientes("%");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente cln = new Cliente();
            dtgvLista.DataSource = cln.ListarClientes(txtBuscar.Text);
        }
    }
}
