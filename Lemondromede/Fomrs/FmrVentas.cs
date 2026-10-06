using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Lemondromede.Services;
using Lemondromede.Models;

namespace forms_de_el_proyecto_wwwww.Forms
{
    public partial class FmrVentas : Form
    {
        // ----- Controles del encabezado (maestro) -----
        private Label lblTitulo;
        private Label lblCliente;
        private ComboBox cmbCliente;
        private Label lblUsuario;
        private ComboBox cmbUsuario;
        private Label lblTipoVenta;
        private ComboBox cmbTipoVenta;
        private Label lblFecha;
        private Label lblFechaValor;

        // ----- Controles del detalle (líneas) -----
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblCantidad;
        private NumericUpDown numCantidad;
        private Button btAgregarLinea;
        private DataGridView dgvDetalle;

        private Label lblTotalTexto;
        private Label lblTotal;
        private Button btGuardarVenta;
        private Button btNuevaVenta;

        // ----- Listado inferior de ventas ya registradas -----
        private DataGridView dgvVentas;

        private readonly VentaService _service;
        private BindingList<DetalleVenta> _lineasVenta;

        public FmrVentas()
        {
            InitializeComponent();
            Font = new Font("Segoe UI", 9f);
            Text = "Gestion de ventas";

            _service = new VentaService();
            _lineasVenta = new BindingList<DetalleVenta>();

            Load += FmrVentas_Load;
            btAgregarLinea.Click += btAgregarLinea_Click;
            btGuardarVenta.Click += btGuardarVenta_Click;
            btNuevaVenta.Click += btNuevaVenta_Click;
            dgvDetalle.CellFormatting += DgvDetalle_CellFormatting;
            dgvVentas.CellFormatting += DgvVentas_CellFormatting;
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            lblUsuario = new Label();
            cmbUsuario = new ComboBox();
            lblTipoVenta = new Label();
            cmbTipoVenta = new ComboBox();
            lblFecha = new Label();
            lblFechaValor = new Label();

            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblCantidad = new Label();
            numCantidad = new NumericUpDown();
            btAgregarLinea = new Button();
            dgvDetalle = new DataGridView();

            lblTotalTexto = new Label();
            lblTotal = new Label();
            btGuardarVenta = new Button();
            btNuevaVenta = new Button();

            dgvVentas = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(240, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(140, 20);
            lblTitulo.Text = "Gestion de ventas";

            // lblCliente
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(20, 60);
            lblCliente.Name = "lblCliente";
            lblCliente.Text = "Cliente:";

            // cmbCliente
            cmbCliente.Location = new Point(110, 57);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(200, 28);
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblUsuario
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(330, 60);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Text = "Cajero:";

            // cmbUsuario
            cmbUsuario.Location = new Point(400, 57);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(180, 28);
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblTipoVenta
            lblTipoVenta.AutoSize = true;
            lblTipoVenta.Location = new Point(20, 100);
            lblTipoVenta.Name = "lblTipoVenta";
            lblTipoVenta.Text = "Tipo de venta:";

            // cmbTipoVenta
            cmbTipoVenta.Location = new Point(130, 97);
            cmbTipoVenta.Name = "cmbTipoVenta";
            cmbTipoVenta.Size = new Size(150, 28);
            cmbTipoVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVenta.Items.AddRange(new object[] { "Contado", "Credito" });
            cmbTipoVenta.SelectedIndex = 0;

            // lblFecha
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(330, 100);
            lblFecha.Name = "lblFecha";
            lblFecha.Text = "Fecha:";

            // lblFechaValor
            lblFechaValor.AutoSize = true;
            lblFechaValor.Location = new Point(400, 100);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // lblProducto
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(20, 150);
            lblProducto.Name = "lblProducto";
            lblProducto.Text = "Producto:";

            // cmbProducto
            cmbProducto.Location = new Point(110, 147);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(260, 28);
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblCantidad
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(390, 150);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Text = "Cantidad:";

            // numCantidad
            numCantidad.Location = new Point(470, 147);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(70, 27);
            numCantidad.Minimum = 1;
            numCantidad.Maximum = 1000;
            numCantidad.Value = 1;

            // btAgregarLinea
            btAgregarLinea.Location = new Point(560, 146);
            btAgregarLinea.Name = "btAgregarLinea";
            btAgregarLinea.Size = new Size(120, 29);
            btAgregarLinea.Text = "Agregar linea";
            btAgregarLinea.UseVisualStyleBackColor = true;

            // dgvDetalle
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.Location = new Point(20, 190);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(660, 150);

            // Columnas manuales del detalle, para no mostrar
            // propiedades de navegación crudas en la grilla.
            // "Producto" no se liga con DataPropertyName porque DetalleVenta
            // no tiene una propiedad plana con el nombre: Producto es un objeto
            // completo. El texto se resuelve en el evento CellFormatting de abajo.
            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProducto",
                HeaderText = "Producto"
            });
            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad"
            });
            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecio",
                HeaderText = "Precio Unitario",
                DataPropertyName = "PrecioUnitario"
            });
            dgvDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSubtotal",
                HeaderText = "Subtotal",
                DataPropertyName = "Subtotal"
            });

            // lblTotalTexto
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Location = new Point(500, 350);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Text = "Total:";
            lblTotalTexto.Font = new Font("Segoe UI", 10f, FontStyle.Bold);

            // lblTotal
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(560, 350);
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "$0.00";
            lblTotal.Font = new Font("Segoe UI", 10f, FontStyle.Bold);

            // btGuardarVenta
            btGuardarVenta.Location = new Point(20, 390);
            btGuardarVenta.Name = "btGuardarVenta";
            btGuardarVenta.Size = new Size(140, 32);
            btGuardarVenta.Text = "Guardar venta";
            btGuardarVenta.UseVisualStyleBackColor = true;

            // btNuevaVenta
            btNuevaVenta.Location = new Point(170, 390);
            btNuevaVenta.Name = "btNuevaVenta";
            btNuevaVenta.Size = new Size(140, 32);
            btNuevaVenta.Text = "Nueva venta";
            btNuevaVenta.UseVisualStyleBackColor = true;

            // dgvVentas (listado de ventas ya registradas, solo lectura)
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.Location = new Point(20, 440);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(660, 160);

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdVenta",
                HeaderText = "ID",
                DataPropertyName = "IdVenta"
            });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFecha",
                HeaderText = "Fecha",
                DataPropertyName = "Fecha"
            });
            // Cliente y Usuario se resuelven en CellFormatting (son objetos,
            // no texto plano), igual que la columna Producto de arriba.
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colClienteVenta",
                HeaderText = "Cliente"
            });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsuarioVenta",
                HeaderText = "Cajero"
            });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTipoVenta",
                HeaderText = "Tipo",
                DataPropertyName = "TipoVenta"
            });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTotalVenta",
                HeaderText = "Total",
                DataPropertyName = "Total"
            });
            dgvVentas.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colEstadoVenta",
                HeaderText = "Activa",
                DataPropertyName = "Estado"
            });

            // FmrVentas
            ClientSize = new Size(700, 620);
            Controls.Add(lblTitulo);
            Controls.Add(lblCliente);
            Controls.Add(cmbCliente);
            Controls.Add(lblUsuario);
            Controls.Add(cmbUsuario);
            Controls.Add(lblTipoVenta);
            Controls.Add(cmbTipoVenta);
            Controls.Add(lblFecha);
            Controls.Add(lblFechaValor);
            Controls.Add(lblProducto);
            Controls.Add(cmbProducto);
            Controls.Add(lblCantidad);
            Controls.Add(numCantidad);
            Controls.Add(btAgregarLinea);
            Controls.Add(dgvDetalle);
            Controls.Add(lblTotalTexto);
            Controls.Add(lblTotal);
            Controls.Add(btGuardarVenta);
            Controls.Add(btNuevaVenta);
            Controls.Add(dgvVentas);
            Name = "FmrVentas";
            Text = "Gestion de ventas";

            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // ----- Eventos -----

        private void FmrVentas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarVentas();
            dgvDetalle.DataSource = _lineasVenta;
        }

        private void CargarCombos()
        {
            var clientes = _service.ObtenerClientes();
            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "IdCliente";

            var usuarios = _service.ObtenerUsuarios();
            cmbUsuario.DataSource = usuarios;
            cmbUsuario.DisplayMember = "Nombre";
            cmbUsuario.ValueMember = "IdUsuario";

            var productos = _service.ObtenerProductosActivos();
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "IdProducto";
        }

        private void CargarVentas()
        {
            var ventas = _service.ObtenerVentas();
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = ventas;
        }

        private void btAgregarLinea_Click(object? sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is not Producto productoSeleccionado)
            {
                MessageBox.Show("Seleccione un producto.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)numCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantidad > productoSeleccionado.Stock)
            {
                MessageBox.Show($"Stock insuficiente. Disponible: {productoSeleccionado.Stock}", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevaLinea = new DetalleVenta
            {
                IdProducto = productoSeleccionado.IdProducto,
                Producto = productoSeleccionado, // solo para mostrar el nombre en la grilla
                Cantidad = cantidad,
                PrecioUnitario = productoSeleccionado.Precio,
                Subtotal = cantidad * productoSeleccionado.Precio
            };

            _lineasVenta.Add(nuevaLinea);
            ActualizarTotal();
        }

        private void DgvDetalle_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            // Solo interviene en la columna "colProducto"; el resto de
            // columnas sí se resuelven solas porque sus DataPropertyName
            // coinciden con propiedades reales de DetalleVenta.
            if (dgvDetalle.Columns[e.ColumnIndex].Name != "colProducto")
                return;

            if (dgvDetalle.Rows[e.RowIndex].DataBoundItem is DetalleVenta linea)
            {
                e.Value = linea.Producto?.Nombre ?? string.Empty;
                e.FormattingApplied = true;
            }
        }

        private void DgvVentas_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVentas.Rows[e.RowIndex].DataBoundItem is not Venta venta)
                return;

            string nombreColumna = dgvVentas.Columns[e.ColumnIndex].Name;
            if (nombreColumna == "colClienteVenta")
            {
                e.Value = venta.Cliente?.Nombre ?? string.Empty;
                e.FormattingApplied = true;
            }
            else if (nombreColumna == "colUsuarioVenta")
            {
                e.Value = venta.Usuario?.Nombre ?? string.Empty;
                e.FormattingApplied = true;
            }
        }

        private void ActualizarTotal()
        {
            decimal total = _lineasVenta.Sum(d => d.Subtotal);
            lblTotal.Text = total.ToString("C2");
        }

        private void btGuardarVenta_Click(object? sender, EventArgs e)
        {
            if (_lineasVenta.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la venta.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCliente.SelectedItem is not Cliente clienteSeleccionado)
            {
                MessageBox.Show("Seleccione un cliente.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbUsuario.SelectedItem is not Usuario usuarioSeleccionado)
            {
                MessageBox.Show("Seleccione el cajero.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var venta = new Venta
            {
                Fecha = DateTime.Now,
                IdCliente = clienteSeleccionado.IdCliente,
                IdUsuario = usuarioSeleccionado.IdUsuario,
                TipoVenta = cmbTipoVenta.SelectedItem?.ToString() ?? "Contado",
                Estado = true,
                Total = _lineasVenta.Sum(d => d.Subtotal)
            };

            // Se reconstruye cada línea "limpia" (sin el objeto Producto completo)
            // para que el nuevo contexto del servicio no intente re-insertar
            // un Producto que ya existe en la base de datos.
            foreach (var linea in _lineasVenta)
            {
                venta.Dventas.Add(new DetalleVenta
                {
                    IdProducto = linea.IdProducto,
                    Cantidad = linea.Cantidad,
                    PrecioUnitario = linea.PrecioUnitario,
                    Subtotal = linea.Subtotal
                });
            }

            _service.CrearVenta(venta);

            MessageBox.Show("Venta registrada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarVenta();
            CargarCombos(); // refresca stock disponible en el combo de productos
            CargarVentas();
        }

        private void btNuevaVenta_Click(object? sender, EventArgs e)
        {
            LimpiarVenta();
        }

        private void LimpiarVenta()
        {
            _lineasVenta.Clear();
            ActualizarTotal();
            cmbTipoVenta.SelectedIndex = 0;
            numCantidad.Value = 1;
        }
    }
}
