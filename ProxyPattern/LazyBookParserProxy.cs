using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class LazyBookParserProxy : IBookParser
    {
        private BookParser bookParser = null;
        private string book;

        public LazyBookParserProxy(string book)
        {
            this.book = book;
        }

        public int GetNumPages()
        {
            if (bookParser == null)
                bookParser = new BookParser(book);

            return bookParser.GetNumPages();
        }
    }
}
