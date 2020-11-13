using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Resources
{
    public class MusicArtistResource : IResource
    {
        MusicArtist musicArtist;

        public MusicArtistResource(MusicArtist musicArtist)
        {
            this.musicArtist = musicArtist;
        }

        public string Image()
        {
            return musicArtist.ImagePath;
        }

        public string Snippet()
        {
            return musicArtist.ArtistBio;
        }

        public string Title()
        {
            return musicArtist.ArtistName;
        }

        public string URL()
        {
            return musicArtist.ProductURL;
        }
    }
}
