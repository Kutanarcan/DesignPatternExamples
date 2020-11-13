using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class BookParser : IBookParser
    {
        int pages = 0;

        public BookParser(string book)
        {
            pages = book.Length;

            //Some Expensive Parsing Stuff and Performance Issue Along With it.
        }

        public int GetNumPages()
        {
            return pages;
        }
    }
}
