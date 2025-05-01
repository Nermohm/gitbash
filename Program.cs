namespace ConsoleApp13
{
    internal class Program
    {

        static int Num()
        {
            
                Random n = new Random();
                int u = n.Next(1000, 9999);

                Console.Write(u);
                
            
            return u;
        }
        static void chart()
        {
            string lol = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+";
            for (int i = 1;i < 16; i++)
            {
                Random n = new Random();
                int u = n.Next(0, 65);
                Console.Write(lol[u]);

            }
            
        }
        static void Main(string[] args)
        {
            
            Num();
            Console.WriteLine();
            chart();
        }
    }
}
