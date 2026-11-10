using Lemondromede.Dtos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Lemondromede.Reportes;

internal class ReporteVentasDocument : IDocument
{
    private readonly List<VentaReportesDto> _ventas;
    private readonly DateTime _desde;
    private readonly DateTime _hasta;
    private readonly string _usuario;

    public ReporteVentasDocument(
        List<VentaReportesDto> ventas,
        DateTime desde,
        DateTime hasta,
        string usuario)
    {
        _ventas = ventas;
        _desde = desde;
        _hasta = hasta;
        _usuario = usuario;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Size(PageSizes.Letter);
            page.Margin(30);
            page.DefaultTextStyle(style => style.FontSize(10).FontFamily(Fonts.Lato));

            page.Header().Element(ComponerEncabezado);
            page.Content().Element(ComponerContenido);
            page.Footer().Element(ComponerPie);
        });
    }

    private void ComponerEncabezado(IContainer container)
    {
        container.Column(column =>
        {
            column.Item().Text("LENDROMEDE")
                .FontSize(20)
                .Bold()
                .FontColor(Colors.Purple.Darken2);

            column.Item().Text("Reporte de ventas")
                .FontSize(15)
                .SemiBold();

            column.Item().PaddingTop(4).Text(
                $"Periodo: {_desde:dd/MM/yyyy} - {_hasta:dd/MM/yyyy}");

            if (!string.IsNullOrWhiteSpace(_usuario))
            {
                column.Item().Text($"Generado por: {_usuario}");
            }

            column.Item().PaddingTop(8).LineHorizontal(1).LineColor(Colors.Grey.Medium);
        });
    }

    private void ComponerContenido(IContainer container)
    {
        container.PaddingVertical(10).Column(column =>
        {
            if (_ventas.Count == 0)
            {
                column.Item().AlignCenter().Text("No hay ventas en el periodo seleccionado.");
                return;
            }

            column.Item().Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(45);
                    columns.ConstantColumn(95);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn(2);
                    columns.ConstantColumn(60);
                    columns.ConstantColumn(80);
                });

                table.Header(header =>
                {
                    header.Cell().Element(CeldaTitulo).Text("N.°");
                    header.Cell().Element(CeldaTitulo).Text("Fecha");
                    header.Cell().Element(CeldaTitulo).Text("Cliente");
                    header.Cell().Element(CeldaTitulo).Text("Vendedor");
                    header.Cell().Element(CeldaTitulo).AlignRight().Text("Productos");
                    header.Cell().Element(CeldaTitulo).AlignRight().Text("Total ($)");
                });

                for (int i = 0; i < _ventas.Count; i++)
                {
                    VentaReportesDto venta = _ventas[i];
                    string fondo = i % 2 == 0 ? "#FFFFFF" : "#EEF5FC";

                    IContainer Celda() => table.Cell().Element(c => CeldaDato(c, fondo));

                    Celda().Text(venta.Id.ToString());
                    Celda().Text(venta.Fecha.ToString("dd/MM/yyyy HH:mm"));
                    Celda().Text(venta.Cliente);
                    Celda().Text(venta.Vendedor);
                    Celda().AlignRight().Text(venta.Productos.ToString());
                    Celda().AlignRight().Text(venta.Total.ToString("N2"));
                }
            });

            decimal totalGeneral = _ventas.Sum(venta => venta.Total);
            column.Item().PaddingTop(10).AlignRight()
                .Text($"Ventas: {_ventas.Count}    Total vendido: ${totalGeneral:N2}")
                .FontSize(12)
                .Bold()
                .FontColor("#1B3A5C");
        });
    }

    private static IContainer CeldaTitulo(IContainer container) =>
        container.Background("#1B3A5C")
            .Padding(5)
            .DefaultTextStyle(style => style.FontColor(Colors.White).Bold());

    private static IContainer CeldaDato(IContainer container, string fondo) =>
        container.Background(fondo)
            .BorderBottom(0.5f)
            .BorderColor("#D0D0D0")
            .Padding(4);

    private static void ComponerPie(IContainer container)
    {
        container.AlignCenter().Text(text =>
        {
            text.Span("Página ");
            text.CurrentPageNumber();
            text.Span(" de ");
            text.TotalPages();
        });

    }
}
