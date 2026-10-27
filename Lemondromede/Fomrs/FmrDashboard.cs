using System;
using System.Drawing;
using System.Windows.Forms;
using forms_de_el_proyecto_wwwww.Forms;

namespace Lemondromede.Fomrs
{
    public partial class FmrDashboard : Form
    {
        private Panel pnlMenu;
        private Panel pnlContenido;
        private Button btnCategorias;
        private Button btnUsuarios;
        private Button btnVentas;
        private Label lblMenu;
        private Button buttonProductos;
        private PictureBox pctFondo;

        public FmrDashboard()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.Sizable;
            Size = new Size(1000, 650);
            MinimumSize = new Size(700, 500);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrDashboard));
            pnlMenu = new Panel();
            lblMenu = new Label();
            btnCategorias = new Button();
            btnUsuarios = new Button();
            btnVentas = new Button();
            pnlContenido = new Panel();
            pctFondo = new PictureBox();
            buttonProductos = new Button();
            pnlMenu.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctFondo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.Info;
            pnlMenu.Controls.Add(buttonProductos);
            pnlMenu.Controls.Add(lblMenu);
            pnlMenu.Controls.Add(btnCategorias);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnVentas);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(4, 4, 4, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(312, 812);
            pnlMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = SystemColors.InactiveCaption;
            lblMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMenu.Location = new Point(19, 25);
            lblMenu.Margin = new Padding(4, 0, 4, 0);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(66, 28);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Menu";
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = SystemColors.GradientActiveCaption;
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderColor = Color.Silver;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 10F);
            btnCategorias.ForeColor = Color.Black;
            btnCategorias.Location = new Point(56, 150);
            btnCategorias.Margin = new Padding(4, 4, 4, 4);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(150, 44);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = SystemColors.GradientActiveCaption;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderColor = Color.Silver;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 10F);
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.Location = new Point(56, 225);
            btnUsuarios.Margin = new Padding(4, 4, 4, 4);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(150, 44);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.GradientActiveCaption;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderColor = Color.Silver;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 10F);
            btnVentas.ForeColor = Color.Black;
            btnVentas.Location = new Point(56, 300);
            btnVentas.Margin = new Padding(4, 4, 4, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(150, 44);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.White;
            pnlContenido.Controls.Add(pctFondo);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(312, 0);
            pnlContenido.Margin = new Padding(4, 4, 4, 4);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(938, 812);
            pnlContenido.TabIndex = 0;
            // 
            // pctFondo
            // 
            pctFondo.BackColor = Color.White;
            pctFondo.Dock = DockStyle.Fill;
            pctFondo.Image = (Image)resources.GetObject("pctFondo.Image");
            pctFondo.Location = new Point(0, 0);
            pctFondo.Margin = new Padding(4, 4, 4, 4);
            pctFondo.Name = "pctFondo";
            pctFondo.Size = new Size(938, 812);
            pctFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFondo.TabIndex = 0;
            pctFondo.TabStop = false;
            pctFondo.Click += pctFondo_Click;
            // 
            // buttonProductos
            // 
            buttonProductos.BackColor = SystemColors.GradientActiveCaption;
            buttonProductos.Cursor = Cursors.Hand;
            buttonProductos.FlatAppearance.BorderColor = Color.Silver;
            buttonProductos.FlatStyle = FlatStyle.Flat;
            buttonProductos.Font = new Font("Segoe UI", 10F);
            buttonProductos.ForeColor = Color.Black;
            buttonProductos.Location = new Point(56, 377);
            buttonProductos.Margin = new Padding(4);
            buttonProductos.Name = "buttonProductos";
            buttonProductos.Size = new Size(150, 44);
            buttonProductos.TabIndex = 4;
            buttonProductos.Text = "Productos";
            buttonProductos.UseVisualStyleBackColor = false;
            buttonProductos.Click += buttonProductos_Click;
            // 
            // FmrDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1250, 812);
            Controls.Add(pnlContenido);
            Controls.Add(pnlMenu);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FmrDashboard";
            Text = "Lendromededash";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctFondo).EndInit();
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

        private void pctFondo_Click(object sender, EventArgs e)
        {

        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            FrmProductos formulario = new FrmProductos();
            formulario.Show();
        }
    }
}
