using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banck
{
    public class Conta
    {
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public int Numero { get; set; }


        public void deposito(double valor)
        {
            this.Saldo += valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }   
        
    }
}
