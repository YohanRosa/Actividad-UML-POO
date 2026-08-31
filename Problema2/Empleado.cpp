#include <iostream>
#include <string>

using namespace std;

class Empleado
{
private:
    string nombre;
    string apellidoPaterno;
    double salarioMensual;

public:
    Empleado(string nombre, string apellidoPaterno, double salarioMensual)
    {
        this->nombre = nombre;
        this->apellidoPaterno = apellidoPaterno;

        if (salarioMensual > 0)
            this->salarioMensual = salarioMensual;
        else
            this->salarioMensual = 0.0;
    }

    double obtenerSalarioAnual()
    {
        return salarioMensual * 12;
    }

    void aumentarSalario()
    {
        salarioMensual = salarioMensual * 1.10;
    }
};

int main()
{
    Empleado empleado1("Juan", "Perez", 15000);
    Empleado empleado2("Ana", "Lopez", 20000);

    cout << "Salarios anuales originales:" << endl;
    cout << "Empleado 1: $" << empleado1.obtenerSalarioAnual() << endl;
    cout << "Empleado 2: $" << empleado2.obtenerSalarioAnual() << endl;

    empleado1.aumentarSalario();
    empleado2.aumentarSalario();

    cout << "\nSalarios anuales con aumento del 10%:" << endl;
    cout << "Empleado 1: $" << empleado1.obtenerSalarioAnual() << endl;
    cout << "Empleado 2: $" << empleado2.obtenerSalarioAnual() << endl;

    return 0;
}
