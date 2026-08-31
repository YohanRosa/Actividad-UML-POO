class Fecha:

    def __init__(self, mes, dia, anio):
        self.mes = mes
        self.dia = dia
        self.anio = anio

    def mostrar_fecha(self):
        print(f"{self.mes}/{self.dia}/{self.anio}")


fecha1 = Fecha(8, 30, 2026)

print("Fecha: ", end="")
fecha1.mostrar_fecha()
