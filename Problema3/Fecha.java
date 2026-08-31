class Fecha {

    private int mes;
    private int dia;
    private int anio;

    public Fecha(int mes, int dia, int anio) {
        this.mes = mes;
        this.dia = dia;
        this.anio = anio;
    }

    public void mostrarFecha() {
        System.out.println(mes + "/" + dia + "/" + anio);
    }
}

public class Main {

    public static void main(String[] args) {

        Fecha fecha1 = new Fecha(8, 30, 2026);

        System.out.print("Fecha: ");
        fecha1.mostrarFecha();
    }
}
