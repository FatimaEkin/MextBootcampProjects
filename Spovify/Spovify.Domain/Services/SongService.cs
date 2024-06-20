namespace Spovify.Domain;

public class SongService
{
    public void AddSong(Song song)
    {
        var data = $"{song.Id},{song.Name},{song.Artist.Id},{song.Artist.Name},{song.Artist.Surname},{song.Artist.Nick},{song.Producer.Id},{song.Producer.Name},{song.Producer.Surname},{song.Producer.Nick},{song.Lyricist.Id},{song.Lyricist.Name},{song.Lyricist.Surname},{song.Lyricist.Nick}\n";

        var path = "/Users/fatimaekin/Desktop/MextBootcampLesson/Spovify/Spovify.Domain/Songs.txt";

        File.AppendAllText(path, data);

        Console.WriteLine("Song added successfully!");
    }

    public List<Song> GetSongs()
    {
        var songs = new List<Song>();

        var path = "/Users/fatimaekin/Desktop/MextBootcampLesson/Spovify/Spovify.Domain/Songs.txt";

        var data = File.ReadAllText(path);

        var lines = data.Split("\n", StringSplitOptions.RemoveEmptyEntries);
    }
}
