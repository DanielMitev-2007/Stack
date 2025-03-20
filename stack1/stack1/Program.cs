using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Въведете число N от интервала [10..100]: ");
            } while (!int.TryParse(Console.ReadLine(), out N) || N < 10 || N > 100);

            List<int> evenNumbers = new List<int>();
            Stack<int> oddNumbers = new Stack<int>();
            List<int> generatedNumbers = new List<int>();

            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                int num = rand.Next(1, 102); 
                generatedNumbers.Add(num); 
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num); 
                }
                else
                {
                    oddNumbers.Push(num);
                }
            }

            Console.WriteLine("Генерирани са: ");
            foreach (var num in generatedNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nСлед промяната: ");

            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }

            while (oddNumbers.Count > 0)
            {
                Console.Write(oddNumbers.Pop() + " ");
            }

            Console.ReadKey();
        }
    }
}
