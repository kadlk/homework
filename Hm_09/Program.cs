using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace Hm_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();

            song.SetSongData(song);
            song.GetSongData(song);

            Console.ReadKey();
        }
    }

    class Song
    {
        public enum Genre { Rock = 1, Pop = 2, Jazz = 3 }
        public string Name { get; set; }
        public int Minutes { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public dynamic GetSongData(Song song)
        {
            var songAnon = new
            {
                song.Name,
                song.Minutes,
                song.Author,
                song.Year
            };
            Console.WriteLine($"The song is {songAnon.Name} its length {songAnon.Minutes}. Author is {songAnon.Author} and the year is {songAnon.Year}");
            return songAnon;
        }

        public void SetSongData(Song song)
        {
            Console.WriteLine("Name of song");
            song.Name = Console.ReadLine();
            Console.WriteLine("What is length in minutes?");
            song.Minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Who is author?");
            song.Author = Console.ReadLine();
            Console.WriteLine("Type the year of song");
            song.Year = Convert.ToInt32(Console.ReadLine());
        }
    }
}
