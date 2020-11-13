using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class MusicArtist
    {
        private string artistName;
        private string imagePath;
        private string artistBio;
        private string productURL;

        public string ArtistName => artistName;
        public string ImagePath => imagePath;
        public string ArtistBio => artistBio;
        public string ProductURL => productURL;

        public MusicArtist(string artistName, string imagePath, string artistBio, string productURL)
        {
            this.artistName = artistName;
            this.imagePath = imagePath;
            this.artistBio = artistBio;
            this.productURL = productURL;
        }
    }
}
