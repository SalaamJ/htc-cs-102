using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_4_code_along
{
    class Movie
    {
        private string text1;
        private int v;
        private string text2;

        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public double RottenTomatoes { get; set; }

        public Movie (string myTitle, int myReleaseYear, double myRottenTomatoes)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
            this.RottenTomatoes = myRottenTomatoes;
        }

        public Movie()
        {
        }

        public void ShowDetails()
        {
            string info = "Title: " + this.Title;
            info += "\nRelease Year: " + this.ReleaseYear;
            info += "\nRottenTomatoes: " + this.RottenTomatoes;

            MessageBox.Show(info);
        }
    }
}
