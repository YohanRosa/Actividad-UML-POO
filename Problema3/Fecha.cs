using System;

class Fecha
{
    private int mes;
    private int dia;
    private int anio;

    public Fecha(int mes, int dia, int anio)
    {
        this.mes = mes;
        this.dia = dia;
        this.anio = anio;
    }

    public void MostrarFecha()
    {
        Console.WriteLine(mes + "/" + dia + "/" + anio);
    }
}

class Program
{
    static void Main()
    {
        Fecha fecha1 = new Fecha(8, 30, 2026);

        Console.Write("Fecha: ");
        fecha1.MostrarFecha();
    }
}
