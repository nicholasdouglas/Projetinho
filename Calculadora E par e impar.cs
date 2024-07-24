/*Código por: 
  
 Nicholas Basso

 Romeu Tamarozi 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOEVER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Dois Numeros");
            int num1;
            int num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual op");
            char op = Convert.ToChar(Console.ReadLine());
            int valF = 0;
            switch (op)
            {
                case '+':
                    valF = num1 + num2;
                    break;
                case '-':
                    valF = num1 - num2;
                    break;
                case '*':
                    valF = num1 * num2;
                    break;
                case '/':
                    valF = num1 / num2;
                    break;
            }


            Console.WriteLine($"O resultado da operação {valF}");

            if (valF % 2 == 0)
                Console.WriteLine("O numero é par");
            else
                Console.WriteLine("O numero é impar");

            Console.ReadKey();
        }
    }
}
