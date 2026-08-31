#include <iostream>

using namespace std;

class Fecha
{
private:
    int mes;
    int dia;
    int anio;

public:
    Fecha(int mes, int dia, int anio)
    {
        this->mes = mes;
        this->dia = dia;
        this->anio = anio;
    }

    void mostrarFecha()
    {
        cout << mes << "/" << dia << "/" << anio << endl;
    }
};

int main()
{
    Fecha fecha1(8, 30, 2026);

    cout << "Fecha: ";
    fecha1.mostrarFecha();

    return 0;
}
