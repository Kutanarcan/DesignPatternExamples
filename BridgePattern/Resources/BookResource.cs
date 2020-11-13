using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Resources
{
    public class BookResource : IResource
    {
        private Book book;

        public BookResource(Book book)
        {
            this.book = book;
        }

        public string Image()
        {
            return book.BookCoverPath;
        }

        public string Snippet()
        {
            return book.BookDesc;
        }

        public string Title()
        {
            return book.BookName;
        }

        public string URL()
        {
            return book.ProductURL;
        }
    }
}
