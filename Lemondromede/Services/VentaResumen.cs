namespace Lemondromede.Services
{
    // Una fila de la grilla MAESTRO (ventas)
    public record VentaResumen(
        int IdVenta,
        DateTime Fecha,
        string Cliente,
        string Cajero,
        string TipoVenta,
        decimal Total,
        string Estado);

    // Una fila de la grilla DETALLE (productos de una venta)
    public record DetalleResumen(
        string Producto,
        int Cantidad,
        decimal PrecioUnitario,
        decimal Subtotal);
}
