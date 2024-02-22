using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240215
{
    public class ContaCorrente
    {
        public double saldo { get; set; }
        public string proprietario { get; private set; }
        public string log { get; private set; }


        public ContaCorrente(string proprietario, double saldo)
        {
            this.proprietario = proprietario;
            this.saldo = saldo;
            this.log = $"Extrato de {proprietario}\n";
        }

        public Boolean depositar(double valor_deposito)
        {
            saldo += valor_deposito;
            Console.WriteLine("\nDeposito realizado.\n");
            Log($"\nDeposito no valor de {valor_deposito}");
            return true;
        }

        public Boolean sacar(double valor_saque)
        {
            if(saldo >= valor_saque)
            {
                saldo -= valor_saque;
                Console.WriteLine($"\nSaque realizado.\n");
                Log($"\nSaque no valor de {valor_saque}");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
        }

        public void Log(string dado)
        {
            this.log += dado;
        }
      

    }
}
