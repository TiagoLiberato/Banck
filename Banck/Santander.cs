using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banck
{
    public class Santander
    {
        /* public void deposito(double valor)
         {
             this.Saldo += valor;
         }

         public double ConsultaSaldoDisponivel()
         {
        this.Limite=100;
             return this.Saldo + this.Limite;
         }*/
        public static Conta Retornodosvalores(double saldo, double Limite, int Numero)
        { 
            Conta conta = new Conta();
            conta.Saldo = saldo;
            conta.Numero = Numero;
            conta.Limite = Limite + conta.Saldo;
            return conta;
        }
        //Tarefa implementar o metodo para retornar uma lista
        public static List<Conta> ListCount(double saldo, double Limite, int Numero)
        {

            List<Conta> lista = new List<Conta>();

            //Exemplo
            Conta conta = new Conta();
            conta.Saldo = saldo;
            conta.Numero = Numero;
            conta.Limite = Limite + conta.Saldo;
            lista.Add(conta);
            Conta conta1 = new Conta();
            conta1.Saldo = 89;
            conta1.Numero = 90854;
            conta1.Limite = 100 + conta.Saldo;
            lista.Add(conta1);




            return lista;
        }
    }
    
}
