namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 5, n2 = 18;
            Console.WriteLine("represent of the prefect number");
            for(n1=0; n1<=n2; n1++)
            {
                if(n1<=3 && n1%n1==0 && n1!=1 )
                {
                    Console.WriteLine(u(n1));   
                }
            }

        }
        public static double u (double n)
        {
            return Math.Pow(n, 2)*(Math.Pow(2,n) -Math.Pow(1,1));
        }
    }
}