using System;
using Banck;

namespace Banck
{
    class program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("============Projeto Bancário===============");
            Conta conta1 = new Conta();
            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;

            Conta conta2= new Conta();
            conta2.Saldo = 2000;
            conta2.Limite = 600;
            conta2.Numero = 456;
            
            Console.WriteLine("Ola Cliente seu saldo em Conta é :" + conta1.Saldo);
            Console.WriteLine("limite de saque é :" + conta1.Limite);
            Console.WriteLine("O Numero da Conta é :" + conta1.Numero);

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Ola Cliente seu saldo em Conta é :" + conta2.Saldo);
            Console.WriteLine("limite de saque é :" + conta2.Limite);
            Console.WriteLine("O Numero da Conta é :" + conta2.Numero);
            
        }
    }
}