namespace Library
{
    using System;

    public class Program
    {
        public static void Main(string[] args){
            CuentaBancaria cb1 = new CuentaBancaria("Franco", 10000);
            cb1.Depositar(100);
            Console.WriteLine(cb1.Saldo);
        }
    }

}