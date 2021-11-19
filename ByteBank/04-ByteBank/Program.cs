using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            
            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoDoSaque = contaDoBruno.Sacar(500.0);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoDoSaque);

            contaDoBruno.Depositar(500.0);

            Console.WriteLine(contaDoBruno.saldo);

            resultadoDoSaque = contaDoBruno.Sacar(200.0);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoDoSaque);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            contaDaGabriela.titular = "Gabriela";

            bool resultadoDaTransferencia = contaDoBruno.Transferir(200.0, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine(resultadoDaTransferencia);

            Console.ReadKey(true);
        }
    }
}
