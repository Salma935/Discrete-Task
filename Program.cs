using System.Data;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("represent of the prime Number 5:18");
            for (n1 = 0; n1 <= 18; n1++)
            {
                n2 = 5+2*n1;
                if (18<=n2)
                {
                    continue;
                }
                Console.WriteLine(n2);
            }
        }
    }
} 