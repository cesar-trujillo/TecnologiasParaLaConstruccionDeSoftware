public class SistemaBancario {
    public static void main(String[] args){
        System.out.println("Sistema Bancario LSP Malo");
        CuentaBancaria ahorro = new CuentaAhorro("CA-001", 1000);
        CuentaBancaria corriente = new CuentaCorriente("CO-002", 5000, 2000);
        CuentaBancaria credito = new CuentaCredito("CR-002", 15000);

        Cliente cliente1 = new Cliente("Alexa", "001", ahorro);
        Cliente cliente2 = new Cliente("Pamela", "002", corriente);
        Cliente cliente3 = new Cliente("Vaneisa", "003", credito);

        System.out.println("Cuentas Ahorro");
        cliente1.mostrarInformacion();
        cliente1.depositar(5000);
        cliente2.retirar(2000);

        System.out.println("Intereses $" + cliente1.calcularIntereses());
        cliente2.mostrarInformacion();
        cliente2.retirar(6000);

        System.out.println("Saldo despues del retiro $" + cliente2.consultarSaldo());
        System.out.println("Intereses por sobregiro: $" + cliente2.calcularIntereses());

        cliente3.mostrarInformacion();
        cliente3.retirar(5000);
        System.out.println("Deuda: $" + ((CuentaCredito) credito).consultarSaldo());
        System.out.println("Intereses: $" + cliente3.calcularIntereses());

        ///LSP
        CuentaBancaria cuenta = new CuentaAhorro("AH-002", 5000);
        try {
            cuenta.pagarDeuda(1000);
        } catch (UnsupportedOperationException e) {
            System.out.println("LSP violado: " + e.getMessage());
        }
    }
}
