using System;
using System.Runtime.CompilerServices;
using System.Windows;

namespace AnimeList
{
    public class Anime
    {
        private const string V = "Title: ";

        public string Title
        {
            get;
            set;
        }

        public string Genre
        {
            get;
            set;
        }

        public string Creator
        {
            get;
            set;
        }

        public void ShowDetails()
        {
            string infoString1 = V + this.Title;
            infoString1 = "Genre: " + this.Genre;
            infoString1 = "Creator: " + this.Creator;
            MessageBox.Show(infoString1);
        }

        public Anime(string myTitle, string myGenre, string myCreator)
        {
            this.Title = myTitle;
            this.Genre = myGenre;
            this.Creator = myCreator;
        }
    }
}
