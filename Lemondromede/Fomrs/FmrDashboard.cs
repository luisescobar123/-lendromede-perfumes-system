using FmrCategoriass.Forms;
using Lemondromede.Services;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using FmrVentass.Forms;
using FmrUsuarioss.Forms;

namespace Lemondromede.Fomrs
{
    public partial class FmrDashboard : Form
    {

        public FmrDashboard()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.Sizable;
            Size = new Size(1000, 650);
            MinimumSize = new Size(700, 500);

            bool esAdmin = Sesion.EsAdministrador;
            btnUsuarios.Visible = esAdmin;
            btnCategorias.Visible = esAdmin;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrDashboard));
            pnlMenu = new Panel();
            picLogo = new PictureBox();
            lblMenu = new Label();
            buttonProductos = new Button();
            btnCategorias = new Button();
            btnVentas = new Button();
            btnUsuarios = new Button();
            btnVentasDetalle = new Button();
            pnlContenido = new Panel();
            pnlBanner = new Panel();
            lblLociones = new Label();
            lblBienvenida = new Label();
            pnlDestacados = new Panel();
            pnlLocion1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblLocion1 = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlContenido.SuspendLayout();
            pnlBanner.SuspendLayout();
            pnlDestacados.SuspendLayout();
            pnlLocion1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(30, 0, 45);
            pnlMenu.Controls.Add(picLogo);
            pnlMenu.Controls.Add(lblMenu);
            pnlMenu.Controls.Add(buttonProductos);
            pnlMenu.Controls.Add(btnCategorias);
            pnlMenu.Controls.Add(btnVentas);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnVentasDetalle);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(300, 653);
            pnlMenu.TabIndex = 5;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Enabled = false;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(3, -35);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(297, 282);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // lblMenu
            // 
            lblMenu.BackColor = Color.FromArgb(55, 15, 75);
            lblMenu.Cursor = Cursors.Hand;
            lblMenu.FlatStyle = FlatStyle.Flat;
            lblMenu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = SystemColors.ButtonFace;
            lblMenu.Location = new Point(20, 250);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(260, 60);
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
            buttonProductos.Location = new Point(20, 372);
            buttonProductos.Name = "buttonProductos";
            buttonProductos.Size = new Size(260, 45);
            buttonProductos.TabIndex = 4;
            buttonProductos.Text = "Productos";
            buttonProductos.UseVisualStyleBackColor = false;
            buttonProductos.Click += buttonProductos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.FromArgb(55, 15, 75);
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 10F);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(20, 320);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(260, 45);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(55, 15, 75);
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 120);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10F);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(20, 476);
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
            btnUsuarios.Location = new Point(20, 424);
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
            btnVentasDetalle.Location = new Point(20, 528);
            btnVentasDetalle.Name = "btnVentasDetalle";
            btnVentasDetalle.Size = new Size(260, 45);
            btnVentasDetalle.TabIndex = 6;
            btnVentasDetalle.Text = "Consulta de ventas";
            btnVentasDetalle.UseVisualStyleBackColor = false;
            btnVentasDetalle.Click += btnVentasDetalle_Click;
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
            pnlContenido.Size = new Size(1082, 653);
            pnlContenido.TabIndex = 0;
            // 
            // pnlBanner
            // 
            pnlBanner.BackColor = Color.FromArgb(55, 10, 80);
            pnlBanner.Controls.Add(pnlDestacados);
            pnlBanner.Controls.Add(lblBienvenida);
            pnlBanner.Controls.Add(lblLociones);
            pnlBanner.Dock = DockStyle.Top;
            pnlBanner.Location = new Point(300, 0);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(782, 535);
            pnlBanner.TabIndex = 6;
            pnlBanner.Paint += pnlBanner_Paint;
            // 
            // lblLociones
            // 
            lblLociones.Font = new Font("Segoe UI", 12F);
            lblLociones.ForeColor = Color.White;
            lblLociones.Location = new Point(25, 80);
            lblLociones.Name = "lblLociones";
            lblLociones.Size = new Size(317, 86);
            lblLociones.TabIndex = 0;
            lblLociones.Text = "Lociones Destacadas";
            lblLociones.Click += lblLociones_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Font = new Font("Segoe UI", 16F);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(223, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(362, 146);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido a Lendromede";
            // 
            // pnlDestacados
            // 
            pnlDestacados.BackColor = Color.White;
            pnlDestacados.Controls.Add(panel2);
            pnlDestacados.Controls.Add(panel1);
            pnlDestacados.Controls.Add(label1);
            pnlDestacados.Controls.Add(pnlLocion1);
            pnlDestacados.Location = new Point(0, 142);
            pnlDestacados.Name = "pnlDestacados";
            pnlDestacados.Size = new Size(782, 508);
            pnlDestacados.TabIndex = 2;
            // 
            // pnlLocion1
            // 
            pnlLocion1.Controls.Add(lblPrecio);
            pnlLocion1.Controls.Add(lblDescripcion);
            pnlLocion1.Controls.Add(lblLocion1);
            pnlLocion1.Controls.Add(pictureBox1);
            pnlLocion1.Location = new Point(10, 70);
            pnlLocion1.Name = "pnlLocion1";
            pnlLocion1.Size = new Size(250, 347);
            pnlLocion1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(55, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 134);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // lblLocion1
            // 
            lblLocion1.AutoSize = true;
            lblLocion1.Location = new Point(94, 167);
            lblLocion1.Name = "lblLocion1";
            lblLocion1.Size = new Size(50, 20);
            lblLocion1.TabIndex = 1;
            lblLocion1.Text = "label2";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(94, 207);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(50, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "label2";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(94, 242);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(266, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 347);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 242);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 207);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 167);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 1;
            label4.Text = "label2";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(55, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 134);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(529, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 347);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 242);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 3;
            label5.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 207);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 2;
            label6.Text = "label2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 167);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 1;
            label7.Text = "label2";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(55, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 134);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // FmrDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 250);
            ClientSize = new Size(1082, 653);
            Controls.Add(pnlContenido);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1100, 700);
            Name = "FmrDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lendromede Menu Principal";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlContenido.ResumeLayout(false);
            pnlBanner.ResumeLayout(false);
            pnlDestacados.ResumeLayout(false);
            pnlDestacados.PerformLayout();
            pnlLocion1.ResumeLayout(false);
            pnlLocion1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel pnlLocion1;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Label lblLocion1;
        private PictureBox pictureBox1;
        private Panel pnlContenido;
    }
}
