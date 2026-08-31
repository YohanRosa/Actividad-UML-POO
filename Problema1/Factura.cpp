#include <iostream>
#include <string>

using namespace std;

class Factura
{
private:
    string numeroPieza;
    string descripcionPieza;
    int cantidad;
    double precioArticulo;

public:
    Factura(string numeroPieza, string descripcionPieza, int cantidad, double precioArticulo)
    {
        this->numeroPieza = numeroPieza;
        this->descripcionPieza = descripcionPieza;

        if (cantidad > 0)
            this->cantidad = cantidad;
        else
            this->cantidad = 0;

        if (precioArticulo > 0)
            this->precioArticulo = precioArticulo;
        else
            this->precioArticulo = 0.0;
    }

    double obtenerMontoFactura()
    {
        return cantidad * precioArticulo;
    }
};

int main()
{
    Factura factura1("A001", "Martillo", 3, 150.0);

    cout << "Monto de la factura: $"
         << factura1.obtenerMontoFactura()
         << endl;

    return 0;
}
