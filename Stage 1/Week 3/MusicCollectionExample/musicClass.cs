using System;

namespace musicAPP
{
  class Music
    {        
        public string SongTitle  // property
            { get; set; }
        public string SongArtist  // property
            { get; set; }
        public string SongMedia  // property
            { get; set; }
        

        // This is the default constructor when no values are being passed.
        public Music ()
        {
            SongTitle = null;
            SongArtist = null;
            SongMedia = null;
        }

        // This is the constructor when three values are passed.
        public Music (string newSongTitle, string newSongArtist, string newSongMedia)
        {
            SongTitle = newSongTitle;
            SongArtist = newSongArtist;
            SongMedia = newSongMedia;
        }
        
        // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
            return "Title: " + SongTitle + ":  Artist: " + SongArtist + ":  Media: " + SongMedia ;
        }

    }// class Music
}// namespace musicAPP 