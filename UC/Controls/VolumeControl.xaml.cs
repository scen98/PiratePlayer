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
    /// Interaction logic for VolumeControl.xaml
    /// </summary>
    public partial class VolumeControl : UserControl
    {
        public VolumeControl()
        {
            InitializeComponent();
            LayoutRoot.DataContext = this;
        }



        public double Value {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(VolumeControl), new PropertyMetadata(0.0));

        private void Slider_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            
        }



    public string SliderVisibility
    {
      get { return (string)GetValue(SliderVisibilityProperty); }
      set { SetValue(SliderVisibilityProperty, value); }
    }

    // Using a DependencyProperty as the backing store for SliderVisibility.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty SliderVisibilityProperty =
        DependencyProperty.Register("SliderVisibility", typeof(string), typeof(VolumeControl), new PropertyMetadata("Visible"));



    private void LayoutRoot_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0) //up
            {
                if (Value < 1)
                {
                    Value += 0.1;
                }
            }
            else if (e.Delta < 0) //down
            {
                if (Value > 0)
                {
                    Value -= 0.1;
                }
            }
        }
    }
}
