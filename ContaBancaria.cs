using System;

namespace EncapsulamentoCsharp
{
    public class ContaBancaria
    {
        public int Num{ get; private set; }
        public string Titular { get; set; }
        public double DepInicial { get; private set; }

       // Construtores conta bancária com dois e três argumentos
        public ContaBancaria(int num, string titular) {
            Num = num;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double depInicial) : this(numero, titular) {
            DepInicial = depInicial;
        }

            public void Deposito(double quantia) {
            DepInicial += quantia;
        }

        public void Saque(double quantia) {
            DepInicial -= quantia + 5.0;
        }

        // Para imprimir os dados no arquivo programa
        public override string ToString()
        {
            return "Conta "
            + Num
            + ", Titular "
            + Titular
            + ", Saldo $ "
            + DepInicial.ToString("F2");
        }


    }
}