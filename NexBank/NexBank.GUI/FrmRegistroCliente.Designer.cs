namespace NexBank.GUI
{
    partial class FrmRegistroCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSalir = new Button();
            btnReporte = new Button();
            btnDarDeBaja = new Button();
            btnActualziar = new Button();
            btnNuevo = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDocumentoIdentidad = new TextBox();
            txtNombreCompleto = new TextBox();
            label4 = new Label();
            txtBuscar = new TextBox();
            dtgvLista = new DataGridView();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 57, 127);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnReporte);
            panel1.Controls.Add(btnDarDeBaja);
            panel1.Controls.Add(btnActualziar);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1072, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 749);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Maroon;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(34, 615);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(5, 0, 0, 0);
            btnSalir.Size = new Size(231, 100);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(22, 151, 164);
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnReporte.ForeColor = Color.White;
            btnReporte.Location = new Point(34, 470);
            btnReporte.Name = "btnReporte";
            btnReporte.Padding = new Padding(5, 0, 0, 0);
            btnReporte.Size = new Size(231, 100);
            btnReporte.TabIndex = 3;
            btnReporte.Text = "Reporte";
            btnReporte.TextAlign = ContentAlignment.MiddleLeft;
            btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnDarDeBaja
            // 
            btnDarDeBaja.BackColor = Color.FromArgb(22, 151, 164);
            btnDarDeBaja.FlatAppearance.BorderSize = 0;
            btnDarDeBaja.FlatStyle = FlatStyle.Flat;
            btnDarDeBaja.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnDarDeBaja.ForeColor = Color.White;
            btnDarDeBaja.Location = new Point(34, 325);
            btnDarDeBaja.Name = "btnDarDeBaja";
            btnDarDeBaja.Padding = new Padding(5, 0, 0, 0);
            btnDarDeBaja.Size = new Size(231, 100);
            btnDarDeBaja.TabIndex = 2;
            btnDarDeBaja.Text = "Dar de baja";
            btnDarDeBaja.TextAlign = ContentAlignment.MiddleLeft;
            btnDarDeBaja.UseVisualStyleBackColor = false;
            // 
            // btnActualziar
            // 
            btnActualziar.BackColor = Color.FromArgb(22, 151, 164);
            btnActualziar.FlatAppearance.BorderSize = 0;
            btnActualziar.FlatStyle = FlatStyle.Flat;
            btnActualziar.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnActualziar.ForeColor = Color.White;
            btnActualziar.Location = new Point(34, 180);
            btnActualziar.Name = "btnActualziar";
            btnActualziar.Padding = new Padding(5, 0, 0, 0);
            btnActualziar.Size = new Size(231, 100);
            btnActualziar.TabIndex = 1;
            btnActualziar.Text = "Actualizar";
            btnActualziar.TextAlign = ContentAlignment.MiddleLeft;
            btnActualziar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(22, 151, 164);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Cambria", 18F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(34, 35);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(5, 0, 0, 0);
            btnNuevo.Size = new Size(231, 100);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 159, 176);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 161);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(108, 23);
            label1.Name = "label1";
            label1.Size = new Size(818, 112);
            label1.TabIndex = 0;
            label1.Text = "Clientes y Cuentas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 15.75F);
            label2.Location = new Point(18, 187);
            label2.Name = "label2";
            label2.Size = new Size(241, 25);
            label2.TabIndex = 2;
            label2.Text = "Documento de Identidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 15.75F);
            label3.Location = new Point(62, 224);
            label3.Name = "label3";
            label3.Size = new Size(182, 25);
            label3.TabIndex = 3;
            label3.Text = "Nombre Completo:";
            // 
            // txtDocumentoIdentidad
            // 
            txtDocumentoIdentidad.Location = new Point(264, 184);
            txtDocumentoIdentidad.Name = "txtDocumentoIdentidad";
            txtDocumentoIdentidad.Size = new Size(350, 26);
            txtDocumentoIdentidad.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(264, 221);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(350, 26);
            txtNombreCompleto.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 15.75F);
            label4.Location = new Point(141, 328);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 6;
            label4.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(264, 325);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(299, 26);
            txtBuscar.TabIndex = 7;
            // 
            // dtgvLista
            // 
            dtgvLista.AllowUserToAddRows = false;
            dtgvLista.AllowUserToDeleteRows = false;
            dtgvLista.AllowUserToOrderColumns = true;
            dtgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dtgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLista.Location = new Point(40, 386);
            dtgvLista.Name = "dtgvLista";
            dtgvLista.ReadOnly = true;
            dtgvLista.Size = new Size(465, 329);
            dtgvLista.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(22, 151, 164);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(264, 264);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 43);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(22, 151, 164);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(435, 264);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 43);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(22, 151, 164);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(569, 325);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(45, 26);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "go";
            btnBuscar.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(604, 386);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(439, 329);
            dataGridView1.TabIndex = 11;
            // 
            // FrmRegistroCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dtgvLista);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtDocumentoIdentidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "FrmRegistroCliente";
            WindowState = FormWindowState.Maximized;
            Load += FrmRegistroCliente_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDocumentoIdentidad;
        private TextBox txtNombreCompleto;
        private Label label4;
        private TextBox txtBuscar;
        private DataGridView dtgvLista;
        private Button btnNuevo;
        private Button btnSalir;
        private Button btnReporte;
        private Button btnDarDeBaja;
        private Button btnActualziar;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnBuscar;
        private DataGridView dataGridView1;
    }
}
