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

namespace ColorMixerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        byte redColorValue;
        private void RedValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                redColorValue = Convert.ToByte(RedValue.Text);
                RedRectangle.Fill = new SolidColorBrush(Color.FromRgb(redColorValue, 0, 0));
                changeBackground();
            }
            catch
            {
                RedValue.Text = "";
            }
            
        }

        byte greenColorValue;
        private void GreenValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                greenColorValue = Convert.ToByte(GreenValue.Text);
                GreenRectangle.Fill = new SolidColorBrush(Color.FromRgb(0, greenColorValue, 0));
                changeBackground();
            }
            catch
            {
                GreenValue.Text = "";
            }
        }

        byte blueColorValue;
        private void BlueValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                blueColorValue = Convert.ToByte(BlueValue.Text);
                BlueRectangle.Fill = new SolidColorBrush(Color.FromRgb(0,0,blueColorValue));
                changeBackground();
            }
            catch
            {
                BlueValue.Text = "";
            }
            
        }

        public void changeBackground()
        {
            MixedRectangle.Background = new SolidColorBrush(Color.FromRgb(redColorValue, blueColorValue, greenColorValue));
            
        }
    }
}
