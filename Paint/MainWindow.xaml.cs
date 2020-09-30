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

namespace Paint
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Can.Strokes.Clear();
        }

        private void Color_Click(object sender, RoutedEventArgs e)
        {
            Can.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            Can.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            Can.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {
            Can.DefaultDrawingAttributes.Color = Colors.Black;
        }
        private void Pen_Width_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }
    }
}
