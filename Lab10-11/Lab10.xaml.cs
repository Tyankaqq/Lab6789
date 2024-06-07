using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lab10_11
{
    /// <summary>
    /// Логика взаимодействия для Lab10.xaml
    /// </summary>
    public partial class Lab10 : Page
    {
        private string fileName;
        private int[] numbers;
        public Lab10()
        {
            InitializeComponent();
            fileName = string.Empty;
        }
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt";
            if (ofd.ShowDialog() == true)
            {

                string fileContent = File.ReadAllText(ofd.FileName);
                string[] components = fileContent.Split(new char[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                numbers = components.Select(component => int.Parse(component)).ToArray();
                int evenCount = numbers.Count(number => number % 2 == 0);

                pathText.Text = ofd.FileName;
                FileContentTextBox.Text = fileContent;
                Count.Text = evenCount.ToString();
            }
        }
        //public DataModel ViewModel { get; set; }

        //private void UpdatePathButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ViewModel.Path = "Новый путь";
        //}

       
    }
}
