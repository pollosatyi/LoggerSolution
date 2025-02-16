namespace LoggerSolution3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string pathFolder = @"../Test";
            Console.WriteLine(Directory.GetCurrentDirectory());
            DateTime dateTime = DateTime.Now;
            Logger logger = new Logger(pathFolder,dateTime);
            
            Thread thread = new Thread(() =>
            {
                logger.Log();
            });
            thread.Start();
            while (count < 1000)
            {
                Console.WriteLine("Программа работает");
                
                Thread.Sleep(TimeSpan.FromSeconds(30));
            }

        }
    }
}
