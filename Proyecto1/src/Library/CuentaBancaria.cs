namespace Library;

public class CuentaBancaria
{
    public string Titular {get; set;}
    public double Saldo {get; set;}  

    public CuentaBancaria(string eltitular, double elsaldo){

        this.Titular = eltitular;
        this.Saldo = elsaldo;   

    }

    public void Depositar(double monto){
        this.Saldo += monto;
    }

}
