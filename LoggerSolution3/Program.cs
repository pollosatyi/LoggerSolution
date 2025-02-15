namespace LoggerSolution3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string path = @"../Test";
            Console.WriteLine(Directory.GetCurrentDirectory());
            Logger logger = new Logger(path);
            
        }
    }
}
