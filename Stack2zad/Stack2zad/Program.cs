using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack2zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете N (естествено число от интервала [5..55]): ");
            int N = int.Parse(Console.ReadLine());

            if (N < 5 || N > 55)
            {
                Console.WriteLine("Числото трябва да бъде в интервала [5..55].");
                return;
            }

            Stack<int> fibStack = new Stack<int>();

            int a = 1, b = 1;

            fibStack.Push(a);
            fibStack.Push(b);

            for (int i = 3; i <= N; i++)
            {
                int next = a + b;
                fibStack.Push(next);
                a = b;
                b = next;
            }

            Console.WriteLine("Числата на Фибоначи до N: ");

            List<int> fibList = new List<int>(fibStack);
            fibList.Reverse(); 

            Console.WriteLine(string.Join("; ", fibList));

            Console.ReadKey();
        }
    }
}
