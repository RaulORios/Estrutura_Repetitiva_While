using System;

namespace Estrutura_Repetitiva_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //While

            //1-            

            //int senha = int.Parse(Console.ReadLine());

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha Inválida");
            //    senha = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso Permitido");

            //Console.ReadKey();

            //_______________________________________________________//

            //2-

            //string[] vet = Console.ReadLine().Split(' ');
            //int x = int.Parse(vet[0]);
            //int y = int.Parse(vet[1]);


            //while (x != 0 && y != 0)
            //{

            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("Primeiro");
            //    }
            //    else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("Segundo");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("Terceiro");
            //    }
            //    else if (x > 0 && y < 0)
            //    {
            //        Console.WriteLine("Quarto");
            //    }

            //    vet = Console.ReadLine().Split(' ');
            //    x = int.Parse(vet[0]);
            //    y = int.Parse(vet[1]);

            //}

            //Console.ReadKey();

            //_______________________________________________________//

            //3-

            int n = int.Parse(Console.ReadLine());

            int somaG = 0;
            int somaA = 0;
            int somaD = 0;

            while (n != 4)
            {

                if (n == 0 && n > 4)
                {
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    if (n == 1)
                    {
                        somaG++;
                    }
                    else if (n == 2)
                    {
                        somaA++;
                    }
                    else if (n == 3)
                    {
                        somaD++;
                    }

                    n = int.Parse(Console.ReadLine());
                }              

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {somaA}");
            Console.WriteLine($"Gasolina: {somaG}");
            Console.WriteLine($"Diesel: {somaD}");

            Console.ReadKey();

        }
    }
}
