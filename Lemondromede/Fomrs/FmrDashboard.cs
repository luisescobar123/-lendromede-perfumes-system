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
            pnlMenu.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctFondo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.Info;
            pnlMenu.Controls.Add(lblMenu);
            pnlMenu.Controls.Add(btnCategorias);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnVentas);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 650);
            pnlMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = SystemColors.InactiveCaption;
            lblMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMenu.Location = new Point(15, 20);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(55, 23);
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
            btnCategorias.Location = new Point(45, 120);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(120, 35);
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
            btnUsuarios.Location = new Point(45, 180);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(120, 35);
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
            btnVentas.Location = new Point(45, 240);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(120, 35);
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
            pnlContenido.Location = new Point(250, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(750, 650);
            pnlContenido.TabIndex = 0;
            // 
            // pctFondo
            // 
            pctFondo.BackColor = Color.White;
            pctFondo.Dock = DockStyle.Fill;
            pctFondo.Image = (Image)resources.GetObject("pctFondo.Image");
            pctFondo.Location = new Point(0, 0);
            pctFondo.Name = "pctFondo";
            pctFondo.Size = new Size(750, 650);
            pctFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFondo.TabIndex = 0;
            pctFondo.TabStop = false;
            pctFondo.Click += pctFondo_Click;
            // 
            // FmrDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1000, 650);
            Controls.Add(pnlContenido);
            Controls.Add(pnlMenu);
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
    }
}
