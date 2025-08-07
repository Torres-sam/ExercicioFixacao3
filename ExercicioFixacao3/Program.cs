using System;
using System.Globalization;
namespace MyApp
{
    internal class ExercicioFixacao3
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota do primeiro semestre: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a nota do segundo semestre: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = nota1 + nota2;

            if (resultado < 60.00) 
            {
                Console.WriteLine("Nota Final " + resultado.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Reprovado");
            }
            else 
            {
                Console.WriteLine("Nota Final " + resultado.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aprovado");
            }

        }
    }
}