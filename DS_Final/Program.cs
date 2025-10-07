using _DS_Final;

class Program
{
    static void Main(string[] args)
    {
        Movie_Playlist playlist = new Movie_Playlist();

        playlist.Add(new Movie("C#", "Action", 97));
        playlist.Add(new Movie("JavaScript", "Horror", 183));
        playlist.Add(new Movie("Python", "Comedy", 132));

        Console.WriteLine("\n=== Display Playlist ===");
        playlist.DisplayPlaylist();

        Console.WriteLine("\n=== Play Next (through the playlist) ===");
        playlist.PlayNext();
        playlist.PlayNext();
        playlist.PlayNext();
        playlist.PlayNext();
        playlist.PlayNext();

        Console.WriteLine("\n=== Play Previous (through the playlist) ===");
        playlist.PlayPrev();
        playlist.PlayPrev();
        playlist.PlayPrev();
        playlist.PlayPrev();
        playlist.PlayPrev();

        Console.WriteLine("\n=== Shuffle Play ===");
        playlist.ShufflePlay();

        Console.WriteLine("\n=== Remove JavaScript ===");
        playlist.Remove("JavaScript");

        Console.WriteLine("\n=== Remove Movie Not In Playlist ===");
        playlist.Remove("Test Remove");

        Console.WriteLine("\n=== Display Final Playlist ===");
        playlist.DisplayPlaylist();
    }
}
