using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cont = new ContaCorrente("Daniel", 10000);

            cont.depositar(1000);
            cont.sacar(6395);
        }
    }
}
