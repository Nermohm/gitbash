namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /************************Variables declarations************************/
            string input;
            int whitespace_index;
            string command;
            string path;

            /****************************Code**************************************/

            Console.WriteLine("\t\t\tWelcome to Tarek's BASH");

            

            /************************Bash function*********************************/

            while (true)
            {
                /************************Taking input**********************************/

                input = Console.ReadLine().Trim();
                whitespace_index = input.IndexOf(' ');
                command = input.Substring(0, whitespace_index);
                path = input.Substring(whitespace_index + 1).Trim();
                if (command == "ls")
                {
                    foreach (var entry in Directory.GetDirectories(path))
                    {
                        Console.WriteLine($"\t[Dir] {entry}");
                    }
                    foreach (var entry in Directory.GetFiles(path))
                    {
                        Console.WriteLine($"\t[File] {entry}");
                    }
                }
                else if(command == "info")
                {
                    if (Directory.Exists(path))
                    {
                        var info = new DirectoryInfo(path);
                        Console.WriteLine("Type : Directory");
                        Console.WriteLine($"Created at : {info.CreationTime}");
                        Console.WriteLine($"Last access time at : {info.LastAccessTime}");
                    }
                    else if (File.Exists(path))
                    {
                        var info = new FileInfo(path);
                        Console.WriteLine("Type : File");
                        Console.WriteLine($"Created at : {info.CreationTime}");
                        Console.WriteLine($"Last access time at : {info.LastAccessTime}");
                    }
                }
                else if(command == "mkdir")
                {
                    Directory.CreateDirectory(path);
                }
                else if(command == "cat")
                {
                    var content = File.ReadAllText(path);
                    Console.WriteLine(content);
                }
                else if(command == "exit")
                {
                    break;
                }
            }
            
                
            
        }
    }
}

