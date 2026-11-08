using Lemondromede.Services;

namespace Lemondromede.Fomrs
{
    public class FrmVentasMaestroDetalle : Form
    {
        private readonly VentaService _service = new();

        private readonly SplitContainer split = new();
        private readonly Label lblMaestro = new();
        private readonly Label lblDetalle = new();
        private readonly Label lblTotal = new();
        private readonly DataGridView dgvVentas = new();   // MAESTRO
        private readonly DataGridView dgvDetalle = new();  // DETALLE

        public FrmVentasMaestroDetalle()
        {
            Text = "Consulta de ventas (maestro - detalle)";
            ClientSize = new Size(820, 580);
            StartPosition = FormStartPosition.CenterParent;
            Font = new Font("Segoe UI", 9f);

            // Divide la pantalla en dos: arriba maestro, abajo detalle
            split.Dock = DockStyle.Fill;
            split.Orientation = Orientation.Horizontal;
            split.SplitterDistance = 270;

            // ----- MAESTRO -----
            ConfigurarGrilla(dgvVentas);
            AgregarColumna(dgvVentas, "Fecha", "Fecha", "dd/MM/yyyy HH:mm");
            AgregarColumna(dgvVentas, "Cliente", "Cliente");
            AgregarColumna(dgvVentas, "Cajero", "Cajero");
            AgregarColumna(dgvVentas, "TipoVenta", "Tipo");
            AgregarColumna(dgvVentas, "Total", "Total", "C2");
            AgregarColumna(dgvVentas, "Estado", "Estado");

            lblMaestro.Text = "Ventas registradas (seleccione una)";
            lblMaestro.Dock = DockStyle.Top;
            lblMaestro.Height = 28;
            lblMaestro.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            lblMaestro.TextAlign = ContentAlignment.MiddleLeft;

            split.Panel1.Controls.Add(dgvVentas);
            split.Panel1.Controls.Add(lblMaestro);

            // ----- DETALLE -----
            ConfigurarGrilla(dgvDetalle);
            AgregarColumna(dgvDetalle, "Producto", "Producto");
            AgregarColumna(dgvDetalle, "Cantidad", "Cantidad");
            AgregarColumna(dgvDetalle, "PrecioUnitario", "Precio unit.", "C2");
            AgregarColumna(dgvDetalle, "Subtotal", "Subtotal", "C2");

            lblDetalle.Text = "Detalle de la venta";
            lblDetalle.Dock = DockStyle.Top;
            lblDetalle.Height = 28;
            lblDetalle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            lblDetalle.TextAlign = ContentAlignment.MiddleLeft;

            lblTotal.Dock = DockStyle.Bottom;
            lblTotal.Height = 30;
            lblTotal.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            lblTotal.TextAlign = ContentAlignment.MiddleRight;

            split.Panel2.Controls.Add(dgvDetalle);
            split.Panel2.Controls.Add(lblTotal);
            split.Panel2.Controls.Add(lblDetalle);

            Controls.Add(split);

            // Cuando cambia la fila seleccionada del maestro, se recarga el detalle
            dgvVentas.SelectionChanged += dgvVentas_SelectionChanged;
            Load += (s, e) => CargarVentas();
        }

        private void CargarVentas()
        {
            dgvVentas.DataSource = _service.ObtenerResumenVentas();
            // Al asignar los datos, la primera fila queda seleccionada
            // y dispara SelectionChanged, que carga su detalle.
        }

        private void dgvVentas_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow?.DataBoundItem is not VentaResumen venta)
            {
                dgvDetalle.DataSource = null;
                lblDetalle.Text = "Detalle de la venta";
                lblTotal.Text = string.Empty;
                return;
            }

            var lineas = _service.ObtenerDetalleDeVenta(venta.IdVenta);
            dgvDetalle.DataSource = lineas;

            lblDetalle.Text = $"Detalle de la venta - {venta.Cliente}";
            lblTotal.Text = "Total: " + lineas.Sum(l => l.Subtotal).ToString("C2");
        }

        // ----- Ayudas para no repetir código -----

        private static void ConfigurarGrilla(DataGridView dgv)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
        }

        private static void AgregarColumna(DataGridView dgv, string propiedad,
                                           string titulo, string? formato = null)
        {
            var col = new DataGridViewTextBoxColumn
            {
                DataPropertyName = propiedad,   // nombre de la propiedad del record
                HeaderText = titulo,
                Name = "col" + propiedad
            };
            if (formato != null)
                col.DefaultCellStyle.Format = formato;
            dgv.Columns.Add(col);
        }
    }
}