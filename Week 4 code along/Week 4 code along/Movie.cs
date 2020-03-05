﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_4_code_along
{
    class Movie
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }

        public Movie (string myTitle, int myReleaseYear)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
        }

        public void ShowDetails()
        {
            string info = "Title: " + this.Title;
            info += "\nRelease Year: " + this.ReleaseYear;

            MessageBox.Show(info);
        }
    }
}
