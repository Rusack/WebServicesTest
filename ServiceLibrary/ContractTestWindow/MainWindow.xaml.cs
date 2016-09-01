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

namespace ContractTestWindow
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

        private void canvas_Loaded(object sender, RoutedEventArgs e)
        {
            Line line = new Line();
            line.Stroke = Brushes.Black;

            line.X1 = canvas.ActualWidth / 2;
            line.X2 = canvas.ActualWidth / 2;
            line.Y1 = canvas.ActualHeight / 6;
            line.Y2 = 5 * canvas.ActualHeight / 6;

            line.StrokeThickness = 5;
            

            Line line2 = new Line();
            line2.Stroke = Brushes.Black;

            line2.X1 = canvas.ActualWidth / 6;
            line2.X2 = 5 * canvas.ActualWidth / 6;
            line2.Y1 = canvas.ActualHeight / 2;
            line2.Y2 = canvas.ActualHeight / 2;

            line2.StrokeThickness = 5;

            canvas.Children.Add(line);
            canvas.Children.Add(line2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.CalculationServiceClient client = new
            ServiceReference1.CalculationServiceClient();

            MessageBox.Show("Result : " + client.Addition(int.Parse(tbValue1.Text), int.Parse(tbValue2.Text)).ToString(), 
                "Result", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            canvas.InvalidateVisual();
        }
    }
}
