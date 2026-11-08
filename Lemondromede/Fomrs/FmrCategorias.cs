using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lemondromede.Services;
using Lemondromede.Models;

namespace FmrCategoriass.Forms
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
        private FlowLayoutPanel pnlCategoria;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private GroupBox grpCategoria;
        private Label label2;
        private readonly CategoriaService _service;

        public FmrCategorias()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            // Mantener apariencia simple como en el diseñador
            Font = new Font("Segoe UI", 9f);
            Text = "Gestion de categorias";

            _service = new CategoriaService();

            // eventos
            
            dgvCategorias.SelectionChanged += DgvCategorias_SelectionChanged;
            
            btBuscar.Click += btBuscar_Click;
        }



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrCategorias));
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
            pnlCategoria = new FlowLayoutPanel();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            grpCategoria = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(50, 10, 80);
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Control;
            lblTitulo.Location = new Point(267, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(217, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestion de categorias";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(32, 110);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(127, 107);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            lblId.Visible = false;
            txtId.Visible = false;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 2;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 154);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 154);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = Color.Purple;
            btGuardar.ForeColor = SystemColors.ButtonHighlight;
            btGuardar.Location = new Point(148, 226);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(94, 29);
            btGuardar.TabIndex = 5;
            btGuardar.Tag = "";
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += button1_Click;
            // 
            // btNuevo
            // 
            btNuevo.BackColor = Color.Purple;
            btNuevo.ForeColor = SystemColors.ButtonHighlight;
            btNuevo.Location = new Point(22, 226);
            btNuevo.Name = "btNuevo";
            btNuevo.Size = new Size(94, 29);
            btNuevo.TabIndex = 6;
            btNuevo.Text = "Nuevo";
            btNuevo.UseVisualStyleBackColor = false;
            btNuevo.Click += btNuevo_Click;
            // 
            // btActualizar
            // 
            btActualizar.BackColor = Color.Purple;
            btActualizar.Enabled = false;
            btActualizar.ForeColor = SystemColors.ButtonHighlight;
            btActualizar.Location = new Point(266, 226);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(94, 29);
            btActualizar.TabIndex = 7;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = Color.Purple;
            btEliminar.Enabled = false;
            btEliminar.ForeColor = SystemColors.ButtonHighlight;
            btEliminar.Location = new Point(390, 226);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(94, 29);
            btEliminar.TabIndex = 8;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            btEliminar.Click += button4_Click;
            // 
            // btBuscar
            // 
            btBuscar.BackColor = Color.Purple;
            btBuscar.ForeColor = SystemColors.ButtonHighlight;
            btBuscar.Location = new Point(507, 226);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 29);
            btBuscar.TabIndex = 9;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(21, 298);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(579, 203);
            dgvCategorias.TabIndex = 10;
            // 
            // pnlCategoria
            // 
            pnlCategoria.BackColor = Color.FromArgb(50, 10, 80);
            pnlCategoria.Location = new Point(0, 0);
            pnlCategoria.Name = "pnlCategoria";
            pnlCategoria.Size = new Size(640, 79);
            pnlCategoria.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(399, 111);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(159, 70);
            txtDescripcion.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(303, 114);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripcion:";
            lblDescripcion.Click += label1_Click;
            // 
            // grpCategoria
            // 
            grpCategoria.BackColor = SystemColors.ButtonFace;
            grpCategoria.Location = new Point(12, 85);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Size = new Size(588, 125);
            grpCategoria.TabIndex = 14;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "Nueva Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(23, 267);
            label2.Name = "label2";
            label2.Size = new Size(198, 23);
            label2.TabIndex = 15;
            label2.Text = "Categorias Registradas:";
            // 
            // FmrCategorias
            // 
            ClientSize = new Size(639, 513);
            Controls.Add(label2);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
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
            Controls.Add(pnlCategoria);
            Controls.Add(grpCategoria);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            bool haySeleccion = txtId.Text.Length > 0;
            btActualizar.Enabled = haySeleccion;
            btEliminar.Enabled = haySeleccion;
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
            if (dgvCategorias.Columns.Contains(nameof(Categoria.IdCategoria)))
                dgvCategorias.Columns[nameof(Categoria.IdCategoria)].Visible = false;
            // ocultar navegación a productos para mantener vista clara
            if (dgvCategorias.Columns.Contains("Productos"))
                dgvCategorias.Columns["Productos"].Visible = false;
        }

        private void DgvCategorias_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow?.DataBoundItem is Categoria cat && dgvCategorias.CurrentRow.Selected)
            {
                txtId.Text = cat.IdCategoria.ToString();
                txtNombre.Text = cat.NombreCategoria;
                txtDescripcion.Text = cat.Descripcion ?? string.Empty;
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
                    existente.Descripcion = txtDescripcion.Text.Trim();
                    _service.ActualizarCategoria(existente);
                }
            }
            else
            {
                var nueva = new Categoria
                {
                    NombreCategoria = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };
                _service.CrearCategoria(nueva);
            }

            CargarCategorias();
            LimpiarCampos();
        }
        private void FmrCategorias_Shown(object? sender, EventArgs e)
        {
            LimpiarCampos();   // quita la selección automática de la primera fila
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
            if (dgvCategorias.Columns.Contains(nameof(Categoria.IdCategoria)))
                dgvCategorias.Columns[nameof(Categoria.IdCategoria)].Visible = false;
            if (dgvCategorias.Columns.Contains("Productos"))
                dgvCategorias.Columns["Productos"].Visible = false;
        }

        private void LimpiarCampos()
        {
            txtId.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            dgvCategorias.ClearSelection();
            dgvCategorias.CurrentCell = null;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
