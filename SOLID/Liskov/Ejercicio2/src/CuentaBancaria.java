public abstract class CuentaBancaria {
    protected String numeroCuenta;
    protected double saldo;
    
    public CuentaBancaria(String numeroCuenta, double saldoInicial){
        this.saldo = saldoInicial;
        this.numeroCuenta = numeroCuenta;
    }

    public void depositar(double cantidad){
        validarCantidad(cantidad);
        saldo += cantidad;
    }

    public void retirar(double cantidad){
        validarCantidad(cantidad);
        if(cantidad > saldo){
            throw new IllegalArgumentException("no se puede")
        }
        saldo -= cantidad;
    }

    public double consultarSaldo(){
        return saldo;
    }

    public String getNumeroCuenta(){
        return numeroCuenta;
    }

    public double calcularIntereses(){
        return saldo * 0.05;
    }

    public void pagarDeuda(double cantidad){
        if(cantidad <= 0){
            throw new IllegalArgumentException("la cantidad debe ser mayor a 0")
        }
    }

    protected void validarCantidad(double cantidad){
        if(cantidad < 0){
            throw new IllegalArgumentException("La cantidad no puede ser menor a 0");
        }
    }
}
