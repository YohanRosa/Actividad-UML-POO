class Empleado {

    private String nombre;
    private String apellidoPaterno;
    private double salarioMensual;

    public Empleado(String nombre, String apellidoPaterno, double salarioMensual) {
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;

        if (salarioMensual > 0) {
            this.salarioMensual = salarioMensual;
        } else {
            this.salarioMensual = 0.0;
        }
    }

    public double obtenerSalarioAnual() {
        return salarioMensual * 12;
    }

    public void aumentarSalario() {
        salarioMensual = salarioMensual * 1.10;
    }
}

public class Main {

    public static void main(String[] args) {

        Empleado empleado1 = new Empleado("Juan", "Perez", 15000);
        Empleado empleado2 = new Empleado("Ana", "Lopez", 20000);

        System.out.println("Salarios anuales originales:");
        System.out.println("Empleado 1: $" + empleado1.obtenerSalarioAnual());
        System.out.println("Empleado 2: $" + empleado2.obtenerSalarioAnual());

        empleado1.aumentarSalario();
        empleado2.aumentarSalario();

        System.out.println("\nSalarios anuales con aumento del 10%:");
        System.out.println("Empleado 1: $" + empleado1.obtenerSalarioAnual());
        System.out.println("Empleado 2: $" + empleado2.obtenerSalarioAnual());
    }
}
