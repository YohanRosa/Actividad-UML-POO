using System;

class Factura
{
    private string numeroPieza;
    private string descripcionPieza;
    private int cantidad;
    private double precioArticulo;

    public Factura(string numeroPieza, string descripcionPieza, int cantidad, double precioArticulo)
    {
        this.numeroPieza = numeroPieza;
        this.descripcionPieza = descripcionPieza;

        if (cantidad > 0)
            this.cantidad = cantidad;
        else
            this.cantidad = 0;

        if (precioArticulo > 0)
            this.precioArticulo = precioArticulo;
        else
            this.precioArticulo = 0.0;
    }

    public double ObtenerMontoFactura()
    {
        return cantidad * precioArticulo;
    }
}

class Program
{
    static void Main()
    {
        Factura factura1 = new Factura("A001", "Martillo", 3, 150.0);

        Console.WriteLine("Monto de la factura: $" + factura1.ObtenerMontoFactura());
    }
}
