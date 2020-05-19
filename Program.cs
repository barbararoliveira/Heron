using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, vamos calcular a área e o semiperímetro de um triângulo. Pressione enter para continuar:");
            Console.ReadKey();

            Console.WriteLine("Infome o valor do primeiro lado:");
            double p = double.Parse (Console.ReadLine());

            Console.WriteLine("Infome o valor do segundo lado:");
            double s = double.Parse (Console.ReadLine());

            Console.WriteLine("Infome o valor do terceiro lado:");
            double t = double.Parse (Console.ReadLine());

            double r = (p + s + t) / 2;
            double result2 = r * ( r-p) * ( r-s )* ( r-t );
            double result3 = Convert.ToSingle (Math.Sqrt(result2));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Área: " + result3);
            Console.WriteLine("Semiperímetro: " + r);
            
        }
    }
}
