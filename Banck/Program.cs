using System;
using Banck;

namespace Banck
{
    class program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("============Projeto Bancário===============");
            Conta conta = new Conta();
            conta.deposito(1500);
           double Saldo = conta.ConsultaSaldoDisponivel();
            Console.WriteLine("Seu saldo é :" + Saldo); 
           
            
        }
    }
}