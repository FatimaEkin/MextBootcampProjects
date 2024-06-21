﻿namespace Spovify.Domain;

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
         foreach (var line in lines)
        {
            // if (string.IsNullOrEmpty(line))
            // {
            //     continue;
            // }
            
            var values = line.Split(",");

            var artist = new Person()
            {
                Id = Guid.Parse(values[2]),
                Name = values[3],
                Surname = values[4],
                Nick = values[5],
            };

            var producer = new Person()
            {
                Id = Guid.Parse(values[6]),
                Name = values[7],
                Surname = values[8],
                Nick = values[9],

            };

    }
}
