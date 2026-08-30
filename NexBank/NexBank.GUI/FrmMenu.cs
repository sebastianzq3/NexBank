using System;
using System.Windows.Forms;

namespace NexBank.GUI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

            ConfigurarBotones();
            ConfigurarEventos();
        }

        private void ConfigurarBotones()
        {
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.FlatAppearance.BorderSize = 0;

            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.FlatAppearance.BorderSize = 0;

            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.FlatAppearance.BorderSize = 0;

            btnCuentas.FlatStyle = FlatStyle.Flat;
            btnCuentas.FlatAppearance.BorderSize = 0;

            btnMantenimiento.FlatStyle = FlatStyle.Flat;
            btnMantenimiento.FlatAppearance.BorderSize = 0;

            btnOperaciones.FlatStyle = FlatStyle.Flat;
            btnOperaciones.FlatAppearance.BorderSize = 0;

            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderSize = 0;

            btnRegistrarCliente.FlatStyle = FlatStyle.Flat;
            btnRegistrarCliente.FlatAppearance.BorderSize = 0;

            btnAbrirCuenta.FlatStyle = FlatStyle.Flat;
            btnAbrirCuenta.FlatAppearance.BorderSize = 0;

            btnNuevaOperacion.FlatStyle = FlatStyle.Flat;
            btnNuevaOperacion.FlatAppearance.BorderSize = 0;

            btnTransferencia.FlatStyle = FlatStyle.Flat;
            btnTransferencia.FlatAppearance.BorderSize = 0;

            btnConsultarSaldo.FlatStyle = FlatStyle.Flat;
            btnConsultarSaldo.FlatAppearance.BorderSize = 0;

            btnVerHistorial.FlatStyle = FlatStyle.Flat;
            btnVerHistorial.FlatAppearance.BorderSize = 0;
        }

        private void ConfigurarEventos()
        {
            btnInicio.Click += btnInicio_Click;
            btnClientes.Click += btnClientes_Click;
            btnCuentas.Click += btnCuentas_Click;
            btnOperaciones.Click += btnOperaciones_Click;
            btnConsultas.Click += btnConsultas_Click;
            btnMantenimiento.Click += btnMantenimiento_Click;
            btnSalir.Click += btnSalir_Click;

            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            btnAbrirCuenta.Click += btnAbrirCuenta_Click;
            btnNuevaOperacion.Click += btnNuevaOperacion_Click;
            btnTransferencia.Click += btnTransferencia_Click;
            btnConsultarSaldo.Click += btnConsultarSaldo_Click;
            btnVerHistorial.Click += btnVerHistorial_Click;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelPrincipal.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmRegistroCliente ventana = new FrmRegistroCliente();
            ventana.ShowDialog();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {

        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            FrmOperaciones ventana = new FrmOperaciones();
            ventana.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FrmHistorialConsultas ventana = new FrmHistorialConsultas();
            ventana.ShowDialog();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEntidades ventana = new FrmMantenimientoEntidades();
            ventana.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Deseas salir del sistema?",
                "NexBank",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            FrmRegistroCliente ventana = new FrmRegistroCliente();
            ventana.ShowDialog();
        }

        private void btnAbrirCuenta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevaOperacion_Click(object sender, EventArgs e)
        {
            FrmOperaciones ventana = new FrmOperaciones();
            ventana.ShowDialog();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            FrmHistorialConsultas ventana = new FrmHistorialConsultas();
            ventana.ShowDialog();
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnInicio_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnSalir_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblSubtituloBanco_Click(object sender, EventArgs e)
        {
        }

        private void lblTituloAcciones_Click(object sender, EventArgs e)
        {
        }
    }
}