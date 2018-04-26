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

namespace _0419
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HeightClearBtn_Click(object sender, RoutedEventArgs e)
        {
            HeightBox.Text = " ";
            HeightBox.Background = Brushes.LightYellow;
        }

        private void CaculateBtn_Click(object sender, RoutedEventArgs e)
        {
            double height = double.Parse(HeightBox.Text) / 100;
            double Re = (double.Parse(WeightBox.Text) / (height * height));
            ResultBox.Text = Re.ToString();
        }

        private void WeightClearBtn_Click(object sender, RoutedEventArgs e)
        {
            WeightBox.Text = " ";
            WeightBox.Background = Brushes.LightYellow;
        }
    }
}
