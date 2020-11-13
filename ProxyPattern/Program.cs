using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LazyBookParserProxy lazyBookParser = new LazyBookParserProxy("Book Text");

            int pages = lazyBookParser.GetNumPages();

            Console.WriteLine(pages);

            Console.ReadKey();
        }
    }
}
