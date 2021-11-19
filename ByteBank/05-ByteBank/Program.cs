using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "434.562.878-20";
            */

            ContaCorrente conta = new ContaCorrente();

            // contaDaGabriela.titular = gabriela;

             conta.titular = new Cliente(); // instânciamos e o resultado disso é um referência.
            
            // conta.titular.nome = "Gabriela";
            // conta.titular.cpf = "333.333.333-33";
            // conta.titular.profissao = "Dev C#";

            if (conta.titular == null)
            {
                Console.WriteLine("Ops, a referência de conta.titular é NULL...");
            }

            conta.saldo = 500.0;
            conta.agencia = 563;
            conta.numero = 5634527;

            // contaDaGabriela.titular.nome = "Teste";

            // Console.WriteLine(gabriela.nome);
            // Console.WriteLine(conta.titular.nome);

            Console.ReadKey(true);
        }
    }
}
