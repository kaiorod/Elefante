using System;
using System.Linq;


namespace Elefante
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdelefante,c;
            string incomoda;
            
            Console.Beep();
            Console.Clear();
            inicio:
            Console.Write("Quantos elefantes? : ");
            qtdelefante = int.Parse(Console.ReadLine());

            c = 1;
           if(qtdelefante % 2 == 0 && qtdelefante > 2)
           {
            while(c <= qtdelefante)
                {   
                    if(c == 1)
                    {
                        Console.WriteLine($"{c} elefante incomoda muita gente ");   
                        incomoda = string.Concat(Enumerable.Repeat("incomodam ", c + 1));
                        Console.WriteLine($"{c+1} elefantes {incomoda}muito mais");
                    }
                    else
                    {
                        Console.WriteLine($"{c} elefantes incomodam muita gente "); 
                        incomoda = string.Concat(Enumerable.Repeat("incomodam ", c + 1));
                        Console.WriteLine($"{c+1} elefantes {incomoda}muito mais");
                    }
                    c = c + 2;
                }
           }
           else
           {
               Console.ForegroundColor = ConsoleColor.DarkRed;
               Console.WriteLine("Digite um numero par de elefantes, maior que 2");
               Console.ResetColor();
               goto inicio;
            }
        }
    }
}
