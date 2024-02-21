using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240215
{
    public class ContaCorrente
    {
        private double saldo { get; set; }
        private string proprietario { get; set; }
        private string log { get; set; }

        public ContaCorrente(string proprietario, double saldo)
        {
            this.saldo = saldo;
            this.proprietario = proprietario;
        }

        public Boolean depositar(double valor_deposito)
        {
            saldo += valor_deposito;
            Console.WriteLine("\nDeposito realizado.\n");
            return true;
        }

        public Boolean sacar(double valor_saque)
        {
            if(saldo >= valor_saque)
            {
                saldo -= valor_saque;
                Console.WriteLine("\nDeposito realizado.\n");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
        }

    }
}
