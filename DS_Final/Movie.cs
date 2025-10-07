using System;
namespace _2333960_DS_Final
{
    public class Movie
    {
        private string title;
        private string genre;
        private int duration;

        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Duration { get => duration; set => duration = value; }

        public Movie(string title, string genre, int duration)
        {
            this.title = title;
            this.genre = genre;
            this.duration = duration;
        }

        public override string ToString()
        {
            return Title + " (" + Genre + ", " + Duration + " minutes)";
        }
    }
}

