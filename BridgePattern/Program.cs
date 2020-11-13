using System;
using System.Text;
using BridgePattern.Resources;
using BridgePattern.Views;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Feel Good","C:/Books","This is a Good Book","Http://www.feelgood.com");
            MusicArtist musicArtist = new MusicArtist("Dua Lipa","C:/MusicArtist","Great Singer","Http://www.dualipa.com");

            IResource bookResource = new BookResource(book);
            IResource musicArtistResource = new MusicArtistResource(musicArtist);

            View bookLongFormView = new LongFormView(bookResource);
            View musicArtistlongFormView = new LongFormView(musicArtistResource);

            View bookArtistShortFormView = new ShortFormView(bookResource);
            View musicArtistShortFormView = new ShortFormView(musicArtistResource);

            Console.WriteLine(bookLongFormView.Show());
            Console.WriteLine(bookArtistShortFormView.Show());

            Console.WriteLine(musicArtistlongFormView.Show());
            Console.WriteLine(musicArtistShortFormView.Show());

            Console.ReadKey();
        }
    }
}
