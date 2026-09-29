using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace forms_de_el_proyecto_wwwww.Forms
{
    public partial class FmrCategorias : Form
    {
        private Label lblTitulo;
        private Label lblId;
        private TextBox txtId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btGuardar;
        private Button btNuevo;
        private Button btActualizar;
        private Button btEliminar;
        private Button btBuscar;
        private DataGridView dgvCategorias;

        public FmrCategorias()
        {
            InitializeComponent();
            // Mantener apariencia simple como en el diseñador
            Font = new Font("Segoe UI", 9f);
            Text = "Gestion de categorias";
        }



        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btGuardar = new Button();
            btNuevo = new Button();
            btActualizar = new Button();
            btEliminar = new Button();
            btBuscar = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(220, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(153, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestion de categorias";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 88);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(116, 85);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 2;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 145);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 145);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(147, 246);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(94, 29);
            btGuardar.TabIndex = 5;
            btGuardar.Tag = "";
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += button1_Click;
            // 
            // btNuevo
            // 
            btNuevo.Location = new Point(21, 246);
            btNuevo.Name = "btNuevo";
            btNuevo.Size = new Size(94, 29);
            btNuevo.TabIndex = 6;
            btNuevo.Text = "Nuevo";
            btNuevo.UseVisualStyleBackColor = true;
            // 
            // btActualizar
            // 
            btActualizar.Location = new Point(265, 246);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(94, 29);
            btActualizar.TabIndex = 7;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(389, 246);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(94, 29);
            btEliminar.TabIndex = 8;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += button4_Click;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(506, 246);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 29);
            btBuscar.TabIndex = 9;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(40, 313);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(530, 188);
            dgvCategorias.TabIndex = 10;
            // 
            // FmrCategorias
            // 
            ClientSize = new Size(639, 513);
            Controls.Add(dgvCategorias);
            Controls.Add(btBuscar);
            Controls.Add(btEliminar);
            Controls.Add(btActualizar);
            Controls.Add(btNuevo);
            Controls.Add(btGuardar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(lblTitulo);
            Name = "FmrCategorias";
            Text = "Gestion de categorias";
            Load += FmrCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }



        private void FmrCategorias_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
