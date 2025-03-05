using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();


            Console.Write("Digite um caráter para substituir: ");
            char c = Console.ReadLine()[0];
            string result = input.Replace(c, 'x');

            Console.WriteLine(result);
        }
    }
}
