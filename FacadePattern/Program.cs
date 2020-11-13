using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataHandlerFacade dataHandlerFacade = new DataHandlerFacade();

            dataHandlerFacade.Save(new SomeData { dataName = "SomeName", dataPath = "C:/SomeData" });
            Console.WriteLine();            
            dataHandlerFacade.Load("C:/SomeData");

            Console.ReadKey();
        }
    }
}
