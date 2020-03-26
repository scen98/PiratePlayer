using Models.AudioPlay;
using System;
using System.Collections.Generic;
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

namespace PiratePlayer.UC.Controls
{
    /// <summary>
    /// Interaction logic for SongGrid.xaml
    /// </summary>
    public partial class SongGrid : UserControl
    {
        public SongGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            var selected = grid.SelectedItems;

            List<Song> selectedObjects = selected.OfType<Song>().ToList();

            SelectedSongs = selectedObjects;
        }



        public List<Song> SongList {
            get { return (List<Song>)GetValue(SongListProperty); }
            set { SetValue(SongListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SongList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SongListProperty =
            DependencyProperty.Register("SongList", typeof(List<Song>), typeof(SongGrid), new PropertyMetadata(new List<Song>()));



        public List<Song> SelectedSongs {
            get { return (List<Song>)GetValue(SelectedSongsProperty); }
            set { SetValue(SelectedSongsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedSongs.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedSongsProperty =
            DependencyProperty.Register("SelectedSongs", typeof(List<Song>), typeof(SongGrid), new PropertyMetadata(new List<Song>()));


    }
}
