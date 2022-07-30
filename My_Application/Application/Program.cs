namespace Application
{
    public static class Program
    {
        static Program()
        {
        }

        public static void Main()
        {

            Logger.Interfaces.ILogger 
                logger = new Logger.Logger();

            Logger.SomeClass someClass = new Logger.SomeClass(logger: logger);

            string fullName = "Senior Martian";
                someClass.DoSomething(fullName: fullName);
            
            Console.WriteLine("Press [Enter] To Exit ...");
            Console.ReadLine();
            
        }
    }
}