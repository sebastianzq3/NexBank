namespace NexBank.GUI
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelMenu;
        private Panel panelPrincipal;
        private Panel panelHeader;
        private Panel panelUsuario;

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;

        private Label lblNombreBanco;
        private Label lblSubtituloBanco;
        private Label lblBienvenida;
        private Label lblDescripcion;
        private Label lblUsuario;
        private Label lblSesion;

        private Button btnInicio;
        private Button btnClientes;
        private Button btnCuentas;
        private Button btnOperaciones;
        private Button btnConsultas;
        private Button btnMantenimiento;
        private Button btnSalir;

        private Panel cardClientes;
        private Panel cardCuentas;
        private Panel cardTransacciones;
        private Panel cardSaldo;

        private Label lblTituloClientes;
        private Label lblNumeroClientes;
        private Label lblDetalleClientes;

        private Label lblTituloCuentas;
        private Label lblNumeroCuentas;
        private Label lblDetalleCuentas;

        private Label lblTituloTransacciones;
        private Label lblNumeroTransacciones;
        private Label lblDetalleTransacciones;

        private Label lblTituloSaldo;
        private Label lblNumeroSaldo;
        private Label lblDetalleSaldo;

        private Panel panelAcciones;
        private Panel panelInformacion;

        private Label lblTituloAcciones;
        private Label lblTituloInformacion;

        private Button btnRegistrarCliente;
        private Button btnAbrirCuenta;
        private Button btnNuevaOperacion;
        private Button btnTransferencia;
        private Button btnConsultarSaldo;
        private Button btnVerHistorial;

        private Label lblBaseDatos;
        private Label lblUsuarioActual;
        private Label lblUltimoAcceso;
        private Label lblVersion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            pictureBox1 = new PictureBox();
            lblNombreBanco = new Label();
            lblSubtituloBanco = new Label();

            btnInicio = new Button();
            btnClientes = new Button();
            btnCuentas = new Button();
            btnOperaciones = new Button();
            btnConsultas = new Button();
            btnMantenimiento = new Button();
            btnSalir = new Button();

            panelUsuario = new Panel();
            pictureBox2 = new PictureBox();
            lblUsuario = new Label();
            lblSesion = new Label();

            panelPrincipal = new Panel();
            panelHeader = new Panel();
            lblBienvenida = new Label();
            lblDescripcion = new Label();

            cardClientes = new Panel();
            cardCuentas = new Panel();
            cardTransacciones = new Panel();
            cardSaldo = new Panel();

            panelAcciones = new Panel();
            lblTituloAcciones = new Label();

            btnRegistrarCliente = new Button();
            btnAbrirCuenta = new Button();
            btnNuevaOperacion = new Button();
            btnTransferencia = new Button();
            btnConsultarSaldo = new Button();
            btnVerHistorial = new Button();

            panelInformacion = new Panel();
            lblTituloInformacion = new Label();
            lblBaseDatos = new Label();
            lblUsuarioActual = new Label();
            lblUltimoAcceso = new Label();
            lblVersion = new Label();

            lblTituloClientes = new Label();
            lblNumeroClientes = new Label();
            lblDetalleClientes = new Label();

            lblTituloCuentas = new Label();
            lblNumeroCuentas = new Label();
            lblDetalleCuentas = new Label();

            lblTituloTransacciones = new Label();
            lblNumeroTransacciones = new Label();
            lblDetalleTransacciones = new Label();

            lblTituloSaldo = new Label();
            lblNumeroSaldo = new Label();
            lblDetalleSaldo = new Label();

            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();

            panelPrincipal.SuspendLayout();
            panelHeader.SuspendLayout();
            panelAcciones.SuspendLayout();
            panelInformacion.SuspendLayout();

            SuspendLayout();

            // PANEL MENU
            panelMenu.BackColor = Color.FromArgb(3, 81, 163);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(lblNombreBanco);
            panelMenu.Controls.Add(lblSubtituloBanco);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnCuentas);
            panelMenu.Controls.Add(btnOperaciones);
            panelMenu.Controls.Add(btnConsultas);
            panelMenu.Controls.Add(btnMantenimiento);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(panelUsuario);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(270, 820);
            panelMenu.TabIndex = 0;

            // LOGO
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.NexBank;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(22, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 68);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            // NOMBRE BANCO
            lblNombreBanco.AutoSize = true;
            lblNombreBanco.Font = new Font(
                "Segoe UI",
                19F,
                FontStyle.Bold);

            lblNombreBanco.ForeColor = Color.White;
            lblNombreBanco.Location = new Point(96, 25);
            lblNombreBanco.Name = "lblNombreBanco";
            lblNombreBanco.Size = new Size(174, 45);
            lblNombreBanco.TabIndex = 1;
            lblNombreBanco.Text = "NEXBANK";

            // SUBTITULO
            lblSubtituloBanco.AutoSize = true;
            lblSubtituloBanco.Font = new Font(
                "Segoe UI",
                7.5F);

            lblSubtituloBanco.ForeColor =
                Color.FromArgb(220, 240, 255);

            lblSubtituloBanco.Location = new Point(97, 70);
            lblSubtituloBanco.Name = "lblSubtituloBanco";
            lblSubtituloBanco.Size = new Size(173, 17);
            lblSubtituloBanco.TabIndex = 2;
            lblSubtituloBanco.Text =
                "Sistema de Gestión Bancaria";

            // BOTONES DEL MENU
            ConfigurarBotonMenu(
                btnInicio,
                "🏠  Inicio",
                new Point(18, 145),
                true);

            ConfigurarBotonMenu(
                btnClientes,
                "👤  Clientes",
                new Point(18, 200),
                false);

            ConfigurarBotonMenu(
                btnCuentas,
                "💳  Cuentas",
                new Point(18, 255),
                false);

            ConfigurarBotonMenu(
                btnOperaciones,
                "💸  Operaciones",
                new Point(18, 310),
                false);

            ConfigurarBotonMenu(
                btnConsultas,
                "🔍  Consultas",
                new Point(18, 365),
                false);

            ConfigurarBotonMenu(
                btnMantenimiento,
                "⚙️  Mantenimiento",
                new Point(18, 420),
                false);

            ConfigurarBotonMenuSalir(
                btnSalir,
                "🚪  Salir",
                new Point(18, 475));

            // PANEL USUARIO
            panelUsuario.BackColor =
                Color.FromArgb(3, 97, 185);

            panelUsuario.Controls.Add(pictureBox2);
            panelUsuario.Controls.Add(lblUsuario);
            panelUsuario.Controls.Add(lblSesion);

            panelUsuario.Location = new Point(18, 650);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(234, 110);
            panelUsuario.TabIndex = 10;

            // FOTO USUARIO
            pictureBox2.BackColor =
                Color.FromArgb(14, 206, 223);

            pictureBox2.Location = new Point(15, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 65);
            pictureBox2.SizeMode =
                PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;

            // USUARIO
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font(
                "Segoe UI",
                10.5F,
                FontStyle.Bold);

            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(92, 23);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";

            // SESION
            lblSesion.AutoSize = true;
            lblSesion.Font = new Font(
                "Segoe UI",
                8.5F);

            lblSesion.ForeColor =
                Color.FromArgb(220, 240, 255);

            lblSesion.Location = new Point(92, 51);
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(95, 20);
            lblSesion.TabIndex = 2;
            lblSesion.Text = "Sesión activa";

            // PANEL PRINCIPAL
            panelPrincipal.BackColor =
                Color.FromArgb(244, 247, 250);

            panelPrincipal.Controls.Add(panelHeader);
            panelPrincipal.Controls.Add(cardClientes);
            panelPrincipal.Controls.Add(cardCuentas);
            panelPrincipal.Controls.Add(cardTransacciones);
            panelPrincipal.Controls.Add(cardSaldo);
            panelPrincipal.Controls.Add(panelAcciones);
            panelPrincipal.Controls.Add(panelInformacion);

            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(270, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1010, 820);
            panelPrincipal.TabIndex = 1;

            // HEADER
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblBienvenida);
            panelHeader.Controls.Add(lblDescripcion);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1010, 145);
            panelHeader.TabIndex = 0;

            // BIENVENIDA
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font(
                "Segoe UI",
                21F,
                FontStyle.Bold);

            lblBienvenida.ForeColor =
                Color.FromArgb(3, 45, 95);

            lblBienvenida.Location =
                new Point(35, 30);

            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(226, 47);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡Bienvenido!";

            // DESCRIPCION
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font(
                "Segoe UI",
                10.5F);

            lblDescripcion.ForeColor =
                Color.FromArgb(80, 95, 115);

            lblDescripcion.Location =
                new Point(37, 78);

            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(307, 25);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text =
                "Sistema de gestión bancaria NexBank";

            // TARJETAS
            CrearTarjeta(
                cardClientes,
                new Point(35, 165),
                new Size(215, 135));

            ConfigurarTarjeta(
                cardClientes,
                lblTituloClientes,
                lblNumeroClientes,
                lblDetalleClientes,
                "Clientes",
                "0",
                "Clientes registrados");

            CrearTarjeta(
                cardCuentas,
                new Point(270, 165),
                new Size(215, 135));

            ConfigurarTarjeta(
                cardCuentas,
                lblTituloCuentas,
                lblNumeroCuentas,
                lblDetalleCuentas,
                "Cuentas",
                "0",
                "Cuentas activas");

            CrearTarjeta(
                cardTransacciones,
                new Point(505, 165),
                new Size(215, 135));

            ConfigurarTarjeta(
                cardTransacciones,
                lblTituloTransacciones,
                lblNumeroTransacciones,
                lblDetalleTransacciones,
                "Transacciones",
                "0",
                "Operaciones realizadas");

            CrearTarjeta(
                cardSaldo,
                new Point(740, 165),
                new Size(235, 135));

            ConfigurarTarjeta(
                cardSaldo,
                lblTituloSaldo,
                lblNumeroSaldo,
                lblDetalleSaldo,
                "Saldo total",
                "Bs0.00",
                "Saldo administrado");

            // PANEL ACCIONES
            panelAcciones.BackColor = Color.White;

            panelAcciones.Controls.Add(lblTituloAcciones);
            panelAcciones.Controls.Add(btnRegistrarCliente);
            panelAcciones.Controls.Add(btnAbrirCuenta);
            panelAcciones.Controls.Add(btnNuevaOperacion);
            panelAcciones.Controls.Add(btnTransferencia);
            panelAcciones.Controls.Add(btnConsultarSaldo);
            panelAcciones.Controls.Add(btnVerHistorial);

            panelAcciones.Location = new Point(35, 320);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Size = new Size(940, 280);
            panelAcciones.TabIndex = 5;

            // TITULO ACCIONES
            lblTituloAcciones.AutoSize = true;
            lblTituloAcciones.Font = new Font(
                "Segoe UI",
                14F,
                FontStyle.Bold);

            lblTituloAcciones.ForeColor =
                Color.FromArgb(3, 45, 95);

            lblTituloAcciones.Location =
                new Point(25, 18);

            lblTituloAcciones.Name =
                "lblTituloAcciones";

            lblTituloAcciones.Size =
                new Size(272, 32);

            lblTituloAcciones.TabIndex = 0;
            lblTituloAcciones.Text =
                "Operaciones bancarias";

            // BOTONES ACCIONES
            ConfigurarBotonAccion(
                btnRegistrarCliente,
                "👤\r\nRegistrar cliente",
                new Point(25, 70),
                Color.FromArgb(20, 122, 210));

            ConfigurarBotonAccion(
                btnAbrirCuenta,
                "💳\r\nAbrir cuenta",
                new Point(175, 70),
                Color.FromArgb(20, 122, 210));

            ConfigurarBotonAccion(
                btnNuevaOperacion,
                "💰\r\nNueva operación",
                new Point(325, 70),
                Color.FromArgb(14, 150, 160));

            ConfigurarBotonAccion(
                btnTransferencia,
                "💸\r\nTransferencia",
                new Point(475, 70),
                Color.FromArgb(14, 150, 160));

            ConfigurarBotonAccion(
                btnConsultarSaldo,
                "💵\r\nConsultar saldo",
                new Point(625, 70),
                Color.FromArgb(20, 122, 210));

            ConfigurarBotonAccion(
                btnVerHistorial,
                "📋\r\nVer historial",
                new Point(775, 70),
                Color.FromArgb(20, 122, 210));

            // INFORMACION
            panelInformacion.BackColor = Color.White;

            panelInformacion.Controls.Add(
                lblTituloInformacion);

            panelInformacion.Controls.Add(
                lblBaseDatos);

            panelInformacion.Controls.Add(
                lblUsuarioActual);

            panelInformacion.Controls.Add(
                lblUltimoAcceso);

            panelInformacion.Controls.Add(
                lblVersion);

            panelInformacion.Location =
                new Point(35, 620);

            panelInformacion.Name =
                "panelInformacion";

            panelInformacion.Size =
                new Size(940, 110);

            panelInformacion.TabIndex = 6;

            // TITULO INFORMACION
            lblTituloInformacion.AutoSize = true;
            lblTituloInformacion.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold);

            lblTituloInformacion.ForeColor =
                Color.FromArgb(3, 45, 95);

            lblTituloInformacion.Location =
                new Point(20, 12);

            lblTituloInformacion.Name =
                "lblTituloInformacion";

            lblTituloInformacion.Size =
                new Size(224, 25);

            lblTituloInformacion.TabIndex = 0;

            lblTituloInformacion.Text =
                "Información del sistema";

            ConfigurarInformacion(
                lblBaseDatos,
                "🗄️ Base de datos: Conectada",
                new Point(20, 55));

            ConfigurarInformacion(
                lblUsuarioActual,
                "👤 Usuario: Administrador",
                new Point(250, 55));

            ConfigurarInformacion(
                lblUltimoAcceso,
                "🕐 Último acceso: Hoy",
                new Point(500, 55));

            ConfigurarInformacion(
                lblVersion,
                "ℹ️ Versión: 1.0",
                new Point(750, 55));

            // FORM
            AutoScaleDimensions =
                new SizeF(8F, 20F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(244, 247, 250);

            ClientSize =
                new Size(1280, 820);

            Controls.Add(panelPrincipal);
            Controls.Add(panelMenu);

            MinimumSize =
                new Size(1100, 700);

            Name = "FrmMenu";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "NexBank - Sistema de Gestión Bancaria";

            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                pictureBox1).EndInit();

            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                pictureBox2).EndInit();

            panelPrincipal.ResumeLayout(false);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();

            panelAcciones.ResumeLayout(false);
            panelAcciones.PerformLayout();

            panelInformacion.ResumeLayout(false);
            panelInformacion.PerformLayout();

            ResumeLayout(false);
        }

        private void ConfigurarBotonMenu(
            Button boton,
            string texto,
            Point ubicacion,
            bool seleccionado)
        {
            boton.BackColor = seleccionado
                ? Color.FromArgb(14, 206, 223)
                : Color.FromArgb(3, 81, 163);

            boton.FlatStyle = FlatStyle.Flat;

            boton.FlatAppearance.BorderSize = 0;

            boton.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(3, 174, 191);

            boton.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(2, 145, 159);

            boton.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            boton.ForeColor = Color.White;

            boton.Location = ubicacion;

            boton.Size =
                new Size(234, 45);

            boton.Text = texto;

            boton.TextAlign =
                ContentAlignment.MiddleLeft;

            boton.Padding =
                new Padding(15, 0, 0, 0);

            boton.Cursor =
                Cursors.Hand;

            boton.UseVisualStyleBackColor =
                false;
        }

        private void ConfigurarBotonMenuSalir(
            Button boton,
            string texto,
            Point ubicacion)
        {
            boton.BackColor =
                Color.FromArgb(3, 81, 163);

            boton.FlatStyle =
                FlatStyle.Flat;

            boton.FlatAppearance.BorderSize =
                0;

            boton.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(220, 70, 70);

            boton.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(190, 50, 50);

            boton.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            boton.ForeColor =
                Color.White;

            boton.Location =
                ubicacion;

            boton.Size =
                new Size(234, 45);

            boton.Text =
                texto;

            boton.TextAlign =
                ContentAlignment.MiddleLeft;

            boton.Padding =
                new Padding(15, 0, 0, 0);

            boton.Cursor =
                Cursors.Hand;

            boton.UseVisualStyleBackColor =
                false;
        }

        private void CrearTarjeta(
            Panel panel,
            Point ubicacion,
            Size tamaño)
        {
            panel.BackColor =
                Color.White;

            panel.Location =
                ubicacion;

            panel.Size =
                tamaño;
        }

        private void ConfigurarTarjeta(
            Panel panel,
            Label titulo,
            Label numero,
            Label detalle,
            string textoTitulo,
            string textoNumero,
            string textoDetalle)
        {
            titulo.AutoSize = true;

            titulo.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            titulo.ForeColor =
                Color.FromArgb(3, 45, 95);

            titulo.Location =
                new Point(20, 18);

            titulo.Text =
                textoTitulo;

            panel.Controls.Add(titulo);

            numero.AutoSize = true;

            numero.Font =
                new Font(
                    "Segoe UI",
                    23F,
                    FontStyle.Bold);

            numero.ForeColor =
                Color.FromArgb(20, 122, 210);

            numero.Location =
                new Point(20, 50);

            numero.Text =
                textoNumero;

            panel.Controls.Add(numero);

            detalle.AutoSize = true;

            detalle.Font =
                new Font(
                    "Segoe UI",
                    8.5F);

            detalle.ForeColor =
                Color.FromArgb(80, 95, 115);

            detalle.Location =
                new Point(20, 105);

            detalle.Text =
                textoDetalle;

            panel.Controls.Add(detalle);
        }

        private void ConfigurarBotonAccion(
            Button boton,
            string texto,
            Point ubicacion,
            Color color)
        {
            boton.BackColor =
                Color.FromArgb(248, 250, 253);

            boton.FlatStyle =
                FlatStyle.Flat;

            boton.FlatAppearance.BorderSize =
                1;

            boton.FlatAppearance.BorderColor =
                Color.FromArgb(220, 225, 235);

            boton.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(235, 248, 250);

            boton.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(220, 242, 245);

            boton.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            boton.ForeColor =
                color;

            boton.Location =
                ubicacion;

            boton.Size =
                new Size(130, 70);

            boton.Text =
                texto;

            boton.TextAlign =
                ContentAlignment.MiddleCenter;

            boton.Cursor =
                Cursors.Hand;

            boton.UseVisualStyleBackColor =
                false;
        }

        private void ConfigurarInformacion(
            Label label,
            string texto,
            Point ubicacion)
        {
            label.AutoSize = true;

            label.Font =
                new Font(
                    "Segoe UI",
                    8.5F);

            label.ForeColor =
                Color.FromArgb(80, 95, 115);

            label.Location =
                ubicacion;

            label.Text =
                texto;
        }
    }
}