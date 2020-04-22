using System;
using System.Windows;

namespace AnimeList
{
    public class Anime
    {
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
            string infoString = "Title: " + this.Title;
            infoString = "Genre: " + this.Genre;
            infoString = "Creator: " + this.Creator;
            MessageBox.Show(infoString);
        }

        public Anime(string myTitle, string myGenre, string myCreator)
        {
            this.Title = myTitle;
            this.Genre = myGenre;
            this.Creator = myCreator;
        }
    }
}
