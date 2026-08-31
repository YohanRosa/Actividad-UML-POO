class Factura:

    def __init__(self, numero_pieza, descripcion_pieza, cantidad, precio_articulo):
        self.numero_pieza = numero_pieza
        self.descripcion_pieza = descripcion_pieza

        if cantidad > 0:
            self.cantidad = cantidad
        else:
            self.cantidad = 0

        if precio_articulo > 0:
            self.precio_articulo = precio_articulo
        else:
            self.precio_articulo = 0.0

    def obtener_monto_factura(self):
        return self.cantidad * self.precio_articulo


factura1 = Factura("A001", "Martillo", 3, 150.0)

print("Monto de la factura: $", factura1.obtener_monto_factura())
