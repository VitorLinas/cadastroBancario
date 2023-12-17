using System.Globalization;

namespace CadastroBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb;

            Console.WriteLine("Entre o número da conta:");
            int Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta:");
            string Titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre o valor de depósito inicial:");
                double Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                cb = new ContaBancaria(Numero, Titular, Deposito);
            }
            else
            {
                cb = new ContaBancaria(Numero, Titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cb);

            Console.WriteLine();

            Console.WriteLine("Entre um valor para depósito:");
            double qnt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Deposito(qnt);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);

            Console.WriteLine("Entre um valor para saque: :");
            qnt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(qnt);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);

        }
    }
    }
