using FmrCategoriass.Forms;
using Lemondromede.Services;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using FmrVentass.Forms;
using FmrUsuarioss.Forms;
using Login.Forms;

namespace Lemondromede.Fomrs
{
    public partial class FmrDashboard : Form
    {

        private readonly System.Windows.Forms.Timer _reloj = new();

        public FmrDashboard()
        {
            InitializeComponent();
            string nombreCompleto = Sesion.UsuarioActual?.Nombre ?? "";
            string primerNombre = nombreCompleto.Split(' ')[0];
            lblBienvenida.Text = string.IsNullOrEmpty(primerNombre)
            ? "Bienvenido a Lendromede"
            : $"Bienvenido, {primerNombre}";

            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.Sizable;

            bool esAdmin = Sesion.EsAdministrador;
            btnUsuarios.Enabled = esAdmin;
            btnCategorias.Enabled = esAdmin;
            buttonProductos.Enabled = esAdmin;

            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "IMAGENES", "Arome_De_Mel_Doux.png"));
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "IMAGENES", "Cœur_rouge.png"));
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "IMAGENES", "Rockbotton.png"));
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox4.Image = Image.FromFile(Path.Combine(Application.StartupPath, "IMAGENES", "Trotil Doux.png"));
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox5.Image = Image.FromFile(Path.Combine(Application.StartupPath, "IMAGENES", "Une_Touche_Deau.png"));
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox6.Image = Image.FromFile(Path.Combine(Application.StartupPath, "IMAGENES", "Universe Parfum.png"));
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox7.Image = Image.FromFile(Path.Combine(Application.StartupPath, "IMAGENES", "Lemon Acid.png"));
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox8.Image = Image.FromFile(Path.Combine(Application.StartupPath, "IMAGENES", "Galaxie Royal.png"));
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrDashboard));
            pnlMenu = new Panel();
            btnReportes = new Button();
            btnCerrar = new Button();
            btnCategorias = new Button();
            btnClientes = new Button();
            lblMenu = new Label();
            buttonProductos = new Button();
            btnVentas = new Button();
            btnUsuarios = new Button();
            btnVentasDetalle = new Button();
            panel3 = new Panel();
            picLogo = new PictureBox();
            pnlContenido = new Panel();
            pnlBanner = new Panel();
            lblLociones = new Label();
            panel2 = new Panel();
            pnlDestacados = new Panel();
            label8 = new Label();
            label1 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblBienvenida = new Label();
            pnlMenu.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlContenido.SuspendLayout();
            pnlBanner.SuspendLayout();
            pnlDestacados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Indigo;
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnCerrar);
            pnlMenu.Controls.Add(btnCategorias);
            pnlMenu.Controls.Add(btnClientes);
            pnlMenu.Controls.Add(lblMenu);
            pnlMenu.Controls.Add(buttonProductos);
            pnlMenu.Controls.Add(btnVentas);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnVentasDetalle);
            pnlMenu.Controls.Add(panel3);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(300, 653);
            pnlMenu.TabIndex = 5;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(55, 15, 75);
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10F);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(20, 510);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(260, 45);
            btnReportes.TabIndex = 8;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrar.BackColor = Color.FromArgb(64, 0, 64);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(20, 596);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(260, 45);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar Sesion";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.FromArgb(55, 15, 75);
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 10F);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(20, 210);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(260, 45);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(55, 15, 75);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 10F);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(20, 310);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(260, 45);
            btnClientes.TabIndex = 7;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // lblMenu
            // 
            lblMenu.BackColor = Color.FromArgb(55, 15, 75);
            lblMenu.Cursor = Cursors.Hand;
            lblMenu.FlatStyle = FlatStyle.Flat;
            lblMenu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = SystemColors.ButtonFace;
            lblMenu.Location = new Point(20, 150);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(260, 50);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Menu";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonProductos
            // 
            buttonProductos.BackColor = Color.FromArgb(55, 15, 75);
            buttonProductos.Cursor = Cursors.Hand;
            buttonProductos.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            buttonProductos.FlatStyle = FlatStyle.Flat;
            buttonProductos.Font = new Font("Segoe UI", 10F);
            buttonProductos.ForeColor = Color.White;
            buttonProductos.Location = new Point(20, 260);
            buttonProductos.Name = "buttonProductos";
            buttonProductos.Size = new Size(260, 45);
            buttonProductos.TabIndex = 4;
            buttonProductos.Text = "Productos";
            buttonProductos.UseVisualStyleBackColor = false;
            buttonProductos.Click += buttonProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(55, 15, 75);
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10F);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(20, 360);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(260, 45);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(55, 15, 75);
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 10F);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(20, 460);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(260, 45);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentasDetalle
            // 
            btnVentasDetalle.BackColor = Color.FromArgb(55, 15, 75);
            btnVentasDetalle.Cursor = Cursors.Hand;
            btnVentasDetalle.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            btnVentasDetalle.FlatStyle = FlatStyle.Flat;
            btnVentasDetalle.Font = new Font("Segoe UI", 10F);
            btnVentasDetalle.ForeColor = Color.White;
            btnVentasDetalle.Location = new Point(20, 410);
            btnVentasDetalle.Name = "btnVentasDetalle";
            btnVentasDetalle.Size = new Size(260, 45);
            btnVentasDetalle.TabIndex = 6;
            btnVentasDetalle.Text = "Consulta de ventas";
            btnVentasDetalle.UseVisualStyleBackColor = false;
            btnVentasDetalle.Click += btnVentasDetalle_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Indigo;
            panel3.Controls.Add(picLogo);
            panel3.Location = new Point(30, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 4;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Enabled = false;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(-30, -32);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(300, 217);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(245, 240, 250);
            pnlContenido.CausesValidation = false;
            pnlContenido.Controls.Add(pnlBanner);
            pnlContenido.Controls.Add(pnlMenu);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1323, 653);
            pnlContenido.TabIndex = 0;
            // 
            // pnlBanner
            // 
            pnlBanner.BackColor = Color.FromArgb(50, 10, 80);
            pnlBanner.Controls.Add(lblLociones);
            pnlBanner.Controls.Add(panel2);
            pnlBanner.Controls.Add(pnlDestacados);
            pnlBanner.Controls.Add(lblBienvenida);
            pnlBanner.Location = new Point(300, 0);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(1029, 653);
            pnlBanner.TabIndex = 6;
            pnlBanner.Paint += pnlBanner_Paint;
            // 
            // lblLociones
            // 
            lblLociones.BackColor = Color.Indigo;
            lblLociones.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLociones.ForeColor = Color.White;
            lblLociones.Location = new Point(429, 78);
            lblLociones.Name = "lblLociones";
            lblLociones.Size = new Size(103, 40);
            lblLociones.TabIndex = 0;
            lblLociones.Text = "Catálogo";
            lblLociones.Click += lblLociones_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Location = new Point(294, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 53);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // pnlDestacados
            // 
            pnlDestacados.BackColor = Color.White;
            pnlDestacados.Controls.Add(label8);
            pnlDestacados.Controls.Add(label1);
            pnlDestacados.Controls.Add(pictureBox8);
            pnlDestacados.Controls.Add(pictureBox7);
            pnlDestacados.Controls.Add(label7);
            pnlDestacados.Controls.Add(label6);
            pnlDestacados.Controls.Add(label5);
            pnlDestacados.Controls.Add(label4);
            pnlDestacados.Controls.Add(label3);
            pnlDestacados.Controls.Add(label2);
            pnlDestacados.Controls.Add(pictureBox6);
            pnlDestacados.Controls.Add(pictureBox5);
            pnlDestacados.Controls.Add(pictureBox4);
            pnlDestacados.Controls.Add(pictureBox3);
            pnlDestacados.Controls.Add(pictureBox2);
            pnlDestacados.Controls.Add(pictureBox1);
            pnlDestacados.Location = new Point(0, 142);
            pnlDestacados.Name = "pnlDestacados";
            pnlDestacados.Size = new Size(1029, 508);
            pnlDestacados.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(841, 355);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 15;
            label8.Text = "Galaxie Royal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(852, 166);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 14;
            label1.Text = "Lemon Acid";
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(801, 190);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(186, 152);
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(801, 13);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(186, 146);
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(586, 355);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 11;
            label7.Text = "Une Touche Deau";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 355);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 10;
            label6.Text = "Trotil Doux";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 355);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 9;
            label5.Text = "Coeur Rouge";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(599, 166);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 8;
            label4.Text = "Rockbotton";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 166);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 7;
            label3.Text = "Universe Parfum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 166);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Mel Deux";
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(276, 13);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(200, 139);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(549, 190);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(186, 160);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(276, 188);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(200, 160);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(549, 13);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 146);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(26, 201);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 141);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 14);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 139);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(294, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(362, 64);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido a Lendromede";
            // 
            // FmrDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 250);
            ClientSize = new Size(1323, 653);
            Controls.Add(pnlContenido);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1100, 698);
            Name = "FmrDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lendromede Menu Principal";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlContenido.ResumeLayout(false);
            pnlBanner.ResumeLayout(false);
            pnlDestacados.ResumeLayout(false);
            pnlDestacados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            using var formulario = new FmrCategorias();
            formulario.ShowDialog(this);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            using var formulario = new FmrUsuarios();
            formulario.ShowDialog(this);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            using var formulario = new FmrVentas();
            formulario.ShowDialog(this);
        }

        private void btnVentasDetalle_Click(object sender, EventArgs e)
        {
            using var formulario = new FrmVentasMaestroDetalle();
            formulario.ShowDialog(this);
        }

        private void pctFondo_Click(object sender, EventArgs e)
        {

        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            using var formulario = new FrmProductos();
            formulario.ShowDialog(this);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void picLogoBanner_Click(object sender, EventArgs e)
        {

        }

        private void lblLociones_Click(object sender, EventArgs e)
        {

        }

        private void pnlBanner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            using var formulario = new FrmClientes();
            formulario.ShowDialog(this);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            using var formulario = new FmrReporteVentas();
            formulario.ShowDialog(this);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show(
       "¿Desea cerrar la sesión?",
       "Cerrar sesión",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            Sesion.UsuarioActual = null;    
            Sesion.VolverAlLogin = true;    
            Close();

        }

        private Panel pnlMenu;
        private PictureBox picLogo;
        private Button buttonProductos;
        private Button btnCategorias;
        private Button btnVentas;
        private Button btnUsuarios;
        private Button btnVentasDetalle;
        private Label lblMenu;
        private Panel pnlBanner;
        private Label lblLociones;
        private Panel pnlDestacados;
        private Label lblBienvenida;
        private Button btnClientes;
        private Panel panel3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnReportes;
        private Panel pnlContenido;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCerrar;
        private Label label8;
        private Label label1;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
    }
}
