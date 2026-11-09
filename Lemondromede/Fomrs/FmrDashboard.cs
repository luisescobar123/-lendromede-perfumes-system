using FmrCategoriass.Forms;
using Lemondromede.Services;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using FmrVentass.Forms;
using FmrUsuarioss.Forms;

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
            Size = new Size(1000, 650);
            MinimumSize = new Size(700, 500);

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
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrDashboard));
            pnlMenu = new Panel();
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
            pnlDestacados = new Panel();
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
            pnlMenu.BackColor = Color.FromArgb(50, 10, 80);
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
            pnlMenu.Margin = new Padding(4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(375, 816);
            pnlMenu.TabIndex = 5;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.FromArgb(55, 15, 75);
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 10F);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(25, 330);
            btnCategorias.Margin = new Padding(4);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(325, 56);
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
            btnClientes.Location = new Point(25, 462);
            btnClientes.Margin = new Padding(4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(325, 56);
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
            lblMenu.Location = new Point(25, 229);
            lblMenu.Margin = new Padding(4, 0, 4, 0);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(325, 75);
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
            buttonProductos.Location = new Point(25, 399);
            buttonProductos.Margin = new Padding(4);
            buttonProductos.Name = "buttonProductos";
            buttonProductos.Size = new Size(325, 56);
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
            btnVentas.Location = new Point(25, 526);
            btnVentas.Margin = new Padding(4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(325, 56);
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
            btnUsuarios.Location = new Point(25, 654);
            btnUsuarios.Margin = new Padding(4);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(325, 56);
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
            btnVentasDetalle.Location = new Point(25, 590);
            btnVentasDetalle.Margin = new Padding(4);
            btnVentasDetalle.Name = "btnVentasDetalle";
            btnVentasDetalle.Size = new Size(325, 56);
            btnVentasDetalle.TabIndex = 6;
            btnVentasDetalle.Text = "Consulta de ventas";
            btnVentasDetalle.UseVisualStyleBackColor = false;
            btnVentasDetalle.Click += btnVentasDetalle_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(picLogo);
            panel3.Location = new Point(38, 18);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 156);
            panel3.TabIndex = 4;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Enabled = false;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(-38, -64);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(375, 271);
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
            pnlContenido.Margin = new Padding(4);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1352, 816);
            pnlContenido.TabIndex = 0;
            // 
            // pnlBanner
            // 
            pnlBanner.BackColor = Color.FromArgb(50, 10, 80);
            pnlBanner.Controls.Add(lblLociones);
            pnlBanner.Controls.Add(pnlDestacados);
            pnlBanner.Controls.Add(lblBienvenida);
            pnlBanner.Location = new Point(375, 0);
            pnlBanner.Margin = new Padding(4);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(978, 669);
            pnlBanner.TabIndex = 6;
            pnlBanner.Paint += pnlBanner_Paint;
            // 
            // lblLociones
            // 
            lblLociones.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLociones.ForeColor = Color.White;
            lblLociones.Location = new Point(332, 66);
            lblLociones.Margin = new Padding(4, 0, 4, 0);
            lblLociones.Name = "lblLociones";
            lblLociones.Size = new Size(396, 108);
            lblLociones.TabIndex = 0;
            lblLociones.Text = "Lociones Destacadas";
            lblLociones.Click += lblLociones_Click;
            // 
            // pnlDestacados
            // 
            pnlDestacados.BackColor = Color.White;
            pnlDestacados.Controls.Add(pictureBox6);
            pnlDestacados.Controls.Add(pictureBox5);
            pnlDestacados.Controls.Add(pictureBox4);
            pnlDestacados.Controls.Add(pictureBox3);
            pnlDestacados.Controls.Add(pictureBox2);
            pnlDestacados.Controls.Add(pictureBox1);
            pnlDestacados.Location = new Point(0, 178);
            pnlDestacados.Margin = new Padding(4);
            pnlDestacados.Name = "pnlDestacados";
            pnlDestacados.Size = new Size(978, 635);
            pnlDestacados.TabIndex = 2;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(368, 18);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(250, 174);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(686, 237);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(252, 200);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(368, 237);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(250, 200);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(705, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(233, 190);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(33, 251);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 176);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 174);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(279, 11);
            lblBienvenida.Margin = new Padding(4, 0, 4, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(452, 182);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido a Lendromede";
            // 
            // FmrDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 250);
            ClientSize = new Size(1352, 816);
            Controls.Add(pnlContenido);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1370, 861);
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
        private Panel pnlContenido;
    }
}
