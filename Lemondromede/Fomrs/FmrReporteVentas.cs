using System.Diagnostics;
using Lemondromede.Dtos;
using Lemondromede.Reportes;
using Lemondromede.Services;
using QuestPDF.Fluent;

namespace Lemondromede.Fomrs
{
    public partial class FmrReporteVentas : Form
    {
        private readonly ReporteServices _servicio = new();
        private List<VentaReportesDto> _ventas = new();

        public FmrReporteVentas()
        {
            InitializeComponent();
        }

        private void FmrReporteVentas_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpHasta.Value = DateTime.Today;
            btnExportar.Enabled = false;
            lblResumen.Text = "Selecciona un rango y presiona Buscar.";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show(
                    "La fecha Desde no puede ser mayor que Hasta.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            _ventas = _servicio.VentasPorRango(dtpDesde.Value, dtpHasta.Value);
            dgvReporte.DataSource = null;
            dgvReporte.DataSource = _ventas;

            if (dgvReporte.Columns.Contains("Id"))
                dgvReporte.Columns["Id"].HeaderText = "N.°";

            if (dgvReporte.Columns.Contains("Fecha"))
                dgvReporte.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            if (dgvReporte.Columns.Contains("Total"))
                dgvReporte.Columns["Total"].DefaultCellStyle.Format = "N2";

            lblResumen.Text = $"Ventas encontradas: {_ventas.Count} | " +
                              $"Total vendido: ${_ventas.Sum(v => v.Total):N2}";
            btnExportar.Enabled = _ventas.Count > 0;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (_ventas.Count == 0)
                return;

            using var dialogo = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                FileName = $"ReporteVentas_{dtpDesde.Value:yyyyMMdd}_{dtpHasta.Value:yyyyMMdd}.pdf"
            };

            if (dialogo.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string usuario = Sesion.UsuarioActual?.Nombre ?? "Sistema";
                var documento = new ReporteVentasDocument(
                    _ventas,
                    dtpDesde.Value,
                    dtpHasta.Value,
                    usuario);

                documento.GeneratePdf(dialogo.FileName);
                Process.Start(new ProcessStartInfo(dialogo.FileName)
                {
                    UseShellExecute = true
                });
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "No se pudo guardar el PDF. Comprueba que no esté abierto.",
                    "Exportación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al generar el PDF:\n{ex.Message}",
                    "Exportación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblDesde_Click(object sender, EventArgs e)
        {
        }

        private void lblHasta_Click(object sender, EventArgs e)
        {
        }
    }
}