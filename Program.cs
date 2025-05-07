namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            
            while (true)
            {
                Console.WriteLine("Choose your operation\n");
                string input = Console.ReadLine().Trim();
                var index = input.IndexOf(' ');
                var command = input.Substring(0, index);
                var path = input.Substring(index + 1).Trim();
                if(command == "ls")
                {
                    foreach(var e in Directory.GetDirectories(path))
                    {
                        Console.WriteLine($"[Directory] : {e}");
                    }
                    foreach(var e in Directory.GetFiles(path))
                    {
                        Console.WriteLine($"[File] : {e}");
                    }
                }
                
            }
        }
    }
}
