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
  /// Interaction logic for ToolBar.xaml
  /// </summary>
  public partial class ToolBar : UserControl
  {
    public ToolBar()
    {
      InitializeComponent();
    }


    private void Button_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.Windows[0].Close();
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
      Application.Current.Windows[0].WindowState = WindowState.Minimized;
    }

    private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
    {
      try
      {
        Application.Current.Windows[0].DragMove();
      }
      catch
      {
      }
      if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
      {
        ChangeWindowSize();
      }
    }

    private void Button_Click_2(object sender, RoutedEventArgs e)
    {
      ChangeWindowSize();

    }

    private void ChangeWindowSize()
    {
      if (Application.Current.Windows[0].WindowState == System.Windows.WindowState.Maximized)
      {
        Application.Current.Windows[0].WindowState = System.Windows.WindowState.Normal;
      }
      else
      {
        Application.Current.Windows[0].WindowState = System.Windows.WindowState.Maximized;
      }
    }
  }
}
