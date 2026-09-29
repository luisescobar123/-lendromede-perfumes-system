using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lemondromede.Services;
using Lemondromede.Models;

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

        private readonly CategoriaService _service;

        public FmrCategorias()
        {
            InitializeComponent();
            // Mantener apariencia simple como en el diseñador
            Font = new Font("Segoe UI", 9f);
            Text = "Gestion de categorias";

            _service = new CategoriaService();

            // eventos
            Load += FmrCategorias_Load;
            dgvCategorias.SelectionChanged += DgvCategorias_SelectionChanged;
            btNuevo.Click += btNuevo_Click;
            btActualizar.Click += btActualizar_Click;
            btBuscar.Click += btBuscar_Click;
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
            btNuevo.Click += btNuevo_Click;
            // 
            // btActualizar
            // 
            btActualizar.Location = new Point(265, 246);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(94, 29);
            btActualizar.TabIndex = 7;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
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
            CargarCategorias();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FmrCategorias_Load_Assign(object? sender, EventArgs e)
        {
            dgvCategorias.SelectionChanged -= DgvCategorias_SelectionChanged;
            dgvCategorias.SelectionChanged += DgvCategorias_SelectionChanged;
            CargarCategorias();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarCategoria();
        }

        private void btNuevo_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btActualizar_Click(object? sender, EventArgs e)
        {
            GuardarCategoria();
        }

        private void btBuscar_Click(object? sender, EventArgs e)
        {
            BuscarCategorias();
        }

        // ----- Lógica de negocio simple -----
        private void CargarCategorias()
        {
            var list = _service.ObtenerCategorias();
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = list;
            // ocultar navegación a productos para mantener vista clara
            if (dgvCategorias.Columns.Contains("Productos"))
                dgvCategorias.Columns["Productos"].Visible = false;
        }

        private void DgvCategorias_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow?.DataBoundItem is Categoria cat)
            {
                txtId.Text = cat.IdCategoria.ToString();
                txtNombre.Text = cat.NombreCategoria;
            }
        }

        private void GuardarCategoria()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre para la categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(txtId.Text, out int id) && id > 0)
            {
                var existente = _service.ObtenerCategoria(id);
                if (existente != null)
                {
                    existente.NombreCategoria = txtNombre.Text.Trim();
                    _service.ActualizarCategoria(existente);
                }
            }
            else
            {
                var nueva = new Categoria
                {
                    NombreCategoria = txtNombre.Text.Trim()
                };
                _service.CrearCategoria(nueva);
            }

            CargarCategorias();
            LimpiarCampos();
        }

        private void EliminarCategoria()
        {
            if (int.TryParse(txtId.Text, out int id) && id > 0)
            {
                var confirm = MessageBox.Show("¿Eliminar la categoría seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    _service.EliminarCategoria(id);
                    CargarCategorias();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una categoría para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarCategorias()
        {
            var texto = txtNombre.Text?.Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                CargarCategorias();
                return;
            }

            var todos = _service.ObtenerCategorias();
            var filtrados = todos.FindAll(c => c.NombreCategoria.Contains(texto, StringComparison.OrdinalIgnoreCase));
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = filtrados;
            if (dgvCategorias.Columns.Contains("Productos"))
                dgvCategorias.Columns["Productos"].Visible = false;
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            dgvCategorias.ClearSelection();
        }
    }
}
