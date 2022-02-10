using System;
using Banck;

namespace Banck
{
    class program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("============Projeto Bancário===============");


            Conta conta = Santander.Retornodosvalores(350,750,123696) ;
            Console.WriteLine("Seu saldo é :" + conta.Saldo);
            Console.WriteLine("Seu limite é :" + conta.Limite);
            Console.WriteLine("Numero Conta :" + conta.Numero);

            Console.WriteLine("============TAREFA LISTAR ELEMENTOS DA LISTA===============");
            List<Conta> lista = Santander.ListCount(350, 750, 123696);

            Console.WriteLine("Elementos total da lista :" + lista.Count);

            lista.ForEach(c => {
                Console.WriteLine("Minha lista :" + c.Limite);

            });

            



        }
    }
}