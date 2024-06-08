using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab5
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(SideA.Text);
                double b = double.Parse(SideB.Text);
                double? result = SolveLinearEquation(a, b);

                if (result == null)
                {
                    Result.Text = "Уравнение имеет бесконечное количество решений.";
                }
                else
                {
                    Result.Text = $"x = {result}";
                }
            }
            catch (FormatException)
            {
                Result.Text = "Введите корректные числовые значения для a и b.";
            }
            catch (ArgumentException ex)
            {
                Result.Text = ex.Message;
            }
        }

        private double? SolveLinearEquation(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return null; // Для обозначения бесконечного количества решений возвращаем null
                }
                else
                {
                    throw new ArgumentException("Уравнение не имеет решения.");
                }
            }

            return -b / a;
        }
    }
}