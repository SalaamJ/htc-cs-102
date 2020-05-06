using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimeList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Anime> AnimeList;

        public MainWindow()
        {
            InitializeComponent();

            AnimeList = new ObservableCollection<Anime>();
            LvAnimes.ItemsSource = AnimeList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Anime animeToAdd = new Anime(titleInput.Text, genreInput.Text, creatorInput.Text);

            AnimeList.Add(animeToAdd);

            titleInput.Clear();
            genreInput.Clear();
            creatorInput.Clear();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Anime m in AnimeList)
            {
                m.ShowDetails();
            }
        }

        private void LvAnimes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Anime selectedAnime = LvAnimes.SelectedItem as Anime;
            if (selectedAnime != null)
            {
                selectedAnime.ShowDetails();
            }
        }
    }
}