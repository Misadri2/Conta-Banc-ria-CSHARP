using System;

namespace EncapsulamentoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial(S/N)?: ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(num, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(num, titular);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);   //- chama os valores que foram organizados na classe

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);



        }
    }
}
