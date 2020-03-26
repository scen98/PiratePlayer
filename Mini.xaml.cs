﻿using System;
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
using System.Windows.Shapes;

namespace PiratePlayer
{
  /// <summary>
  /// Interaction logic for Mini.xaml
  /// </summary>
  public partial class Mini : Window
  {
    public Mini()
    {
      InitializeComponent();
    }

    private void ExitBtn_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }

    private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
    {
      try
      {
        this.DragMove();
      }
      catch
      {
      }
    }
  }
}
