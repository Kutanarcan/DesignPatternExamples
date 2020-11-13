using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Book
    {
        private string bookName;
        private string bookCoverPath;
        private string bookDesc;
        private string productURL;

        public string BookName => bookName;
        public string BookCoverPath => bookCoverPath;
        public string BookDesc => bookDesc;
        public string ProductURL => productURL;

        public Book(string bookName, string bookCoverPath, string bookDesc, string productURL)
        {
            this.bookName = bookName;
            this.bookCoverPath = bookCoverPath;
            this.bookDesc = bookDesc;
            this.productURL = productURL;
        }
    }
}
