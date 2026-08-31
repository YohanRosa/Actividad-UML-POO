using System;

class Empleado
{
    private string nombre;
    private string apellidoPaterno;
    private double salarioMensual;

    public Empleado(string nombre, string apellidoPaterno, double salarioMensual)
    {
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;

        if (salarioMensual > 0)
            this.salarioMensual = salarioMensual;
        else
            this.salarioMensual = 0.0;
    }

    public double ObtenerSalarioAnual()
    {
        return salarioMensual * 12;
    }

    public void AumentarSalario()
    {
        salarioMensual = salarioMensual * 1.10;
    }
}

class Program
{
    static void Main()
    {
        Empleado empleado1 = new Empleado("Juan", "Perez", 15000);
        Empleado empleado2 = new Empleado("Ana", "Lopez", 20000);

        Console.WriteLine("Salarios anuales originales:");
        Console.WriteLine("Empleado 1: $" + empleado1.ObtenerSalarioAnual());
        Console.WriteLine("Empleado 2: $" + empleado2.ObtenerSalarioAnual());

        empleado1.AumentarSalario();
        empleado2.AumentarSalario();

        Console.WriteLine("\nSalarios anuales con aumento del 10%:");
        Console.WriteLine("Empleado 1: $" + empleado1.ObtenerSalarioAnual());
        Console.WriteLine("Empleado 2: $" + empleado2.ObtenerSalarioAnual());
    }
}
