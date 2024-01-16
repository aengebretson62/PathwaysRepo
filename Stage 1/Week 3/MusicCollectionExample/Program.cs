using System;

namespace musicAPP
{
  class Program
  {
    static void Main(string[] args)
    { 
        // Declare and instantiate a single Restaurant object using the default constructor
           Music aMusic = new Music();

        // Output to show the default constructor values
           Console.WriteLine(aMusic);

        // Declare and instantiate a single Restaurant object using the default constructor
           Music bMusic = new Music("Piano Man", "Billy Joel", "Vinyl");

        // Output to show the default constructor values
           Console.WriteLine(bMusic);
  

        // Declare and instantiate the array of Music objects
           Music[] musicArray=new Music[10];

        // Now, loop through each array element and instantiate a Music object for each.
        // Note that the constructor with no parameters will be used.

        for (int index = 0; index < musicArray.Length; index++)
        {
            musicArray[index] = new Music();
        }

        // // Load in some test data to test both ways to assign values

        musicArray[1].SongTitle = "Stacy's Mom";
        musicArray[1].SongArtist = "Fountains of Wayne";
        musicArray[1].SongMedia = "CD";
        musicArray[4].SongTitle = "OPP";
        musicArray[4].SongArtist = "Naughty by Nature";
        musicArray[4].SongMedia = "Spotify";
        musicArray[6] = bMusic;
        aMusic.SongTitle = "Jingle Bells";
        aMusic.SongArtist = "Santa Clause";
        aMusic.SongMedia = "mp3";
        musicArray[9] = aMusic;




        // print each restaurant to test the property gets and the toString

        for (int index = 0; index < musicArray.Length; index++)
        {
            if (!(((musicArray[index]).SongTitle == null)))
                Console.WriteLine(musicArray[index]);
        }

        

    } // Main
  } // class
} // namespace
