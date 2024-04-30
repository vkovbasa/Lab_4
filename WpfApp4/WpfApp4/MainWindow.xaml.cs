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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void FormatNumber(double number);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PerformOperations_Click(object sender, RoutedEventArgs e)
        {
            double a = 1.0;
            double b = 3.0;

            List<Func<double, double, double>> opsList = new List<Func<double, double, double>>();
            opsList.Add(Add);
            opsList.Add(Divide);
            opsList.Add(Multiply);

            List<OperationResult> results = new List<OperationResult>();
            foreach (var op in opsList)
            {
                double result = op(a, b);
                results.Add(new OperationResult { Operation = op.Method.Name, Result = result });
            }

            OperationsListView.ItemsSource = results;

            FormatNumber format = FormatNumberAsCurrency;
            format += FormatNumberWithCommas;
            format += FormatNumberWithTwoPlaces;
            format(12345.6789);
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static void FormatNumberAsCurrency(double number)
        {
            (Application.Current.MainWindow as MainWindow).ResultTextBlock.Text += $"A Currency: {number:C}\n";
        }

        static void FormatNumberWithCommas(double number)
        {
            (Application.Current.MainWindow as MainWindow).ResultTextBlock.Text += $"With Commas: {number:N}\n";
        }

        static void FormatNumberWithTwoPlaces(double number)
        {
            (Application.Current.MainWindow as MainWindow).ResultTextBlock.Text += $"With 3 places: {number:.###}\n";
        }
    }

    public class OperationResult
    {
        public string Operation { get; set; }
        public double Result { get; set; }
    }
}
