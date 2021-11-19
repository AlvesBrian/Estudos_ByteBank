using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            Console.WriteLine(conta.titular);
            // quando não atribuímos valor ao um atributo de um objeto, por adrão o C# assume valores default's para determinados tipos primitvos.
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.agencia);

            Console.ReadKey(true);
        }
    }
}
