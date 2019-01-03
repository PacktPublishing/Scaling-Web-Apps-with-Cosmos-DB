
namespace TableStorage
{
    using System;

    public class Program
    {
        

        public static void Main(string[] args)
        {
            Console.WriteLine("Azure Table Storage - Getting Started Samples\n");
            Console.WriteLine();

            BasicSamples basicSamples = new BasicSamples();
            basicSamples.RunSamples().Wait();

            AdvancedSamples advancedSamples = new AdvancedSamples();
            advancedSamples.RunSamples().Wait();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.Read();
        }

                     
    }
}
