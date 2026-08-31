class Empleado:

    def __init__(self, nombre, apellido_paterno, salario_mensual):
        self.nombre = nombre
        self.apellido_paterno = apellido_paterno

        if salario_mensual > 0:
            self.salario_mensual = salario_mensual
        else:
            self.salario_mensual = 0.0

    def obtener_salario_anual(self):
        return self.salario_mensual * 12

    def aumentar_salario(self):
        self.salario_mensual = self.salario_mensual * 1.10


empleado1 = Empleado("Juan", "Perez", 15000)
empleado2 = Empleado("Ana", "Lopez", 20000)

print("Salarios anuales originales:")
print("Empleado 1: $", empleado1.obtener_salario_anual())
print("Empleado 2: $", empleado2.obtener_salario_anual())

empleado1.aumentar_salario()
empleado2.aumentar_salario()

print("\nSalarios anuales con aumento del 10%:")
print("Empleado 1: $", empleado1.obtener_salario_anual())
print("Empleado 2: $", empleado2.obtener_salario_anual())
