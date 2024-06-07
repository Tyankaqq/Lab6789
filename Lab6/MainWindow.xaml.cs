using System.Collections;
using System.Net.Cache;
using System.Security.Policy;
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

namespace Lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> listLab1;
        private Queue<int> queue;
        private LinkedList<int> listLab3;
        Q rakdavkrutoi = new Q();
        CircularDoublyLinkedList doubleNode = new CircularDoublyLinkedList();
        public MainWindow()
        {
            InitializeComponent();
            listLab1 = new List<int>();
            queue = new Queue<int>();
            listLab3 = new LinkedList<int>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            listLab1.Add(int.Parse(tbElement.Text));
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
            tbElement.Text = "";

            if (listLab1.Contains(33))
            {
                Max_Value.Text = listLab1.Max().ToString();
                return;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int index = lbList.SelectedIndex;
            listLab1.RemoveAt(index);
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
           
        }
        

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            rakdavkrutoi.Enqueue(double.Parse(tbElementQueue.Text));
            lbQueue.ItemsSource = null;
            lbQueue.ItemsSource = rakdavkrutoi.GetQueueValues();
            tbResultQueue.Text = rakdavkrutoi.SumNegativeElements().ToString();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                rakdavkrutoi.Dequeue();
                lbQueue.ItemsSource = null;
                lbQueue.ItemsSource = rakdavkrutoi.GetQueueValues();
                tbResultQueue.Text = rakdavkrutoi.SumNegativeElements().ToString();
            } catch(InvalidOperationException ex)
            {
                MessageBox.Show("Очередь пуста, нечего удалаять.\n\nА еще rakdav крутой!");
            }
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            doubleNode.Add(int.Parse(tbElementAdd.Text));
            lbList3.ItemsSource = null;
            lbList3.ItemsSource = doubleNode.GetValues();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            doubleNode.RemoveLastLessThan15();
            lbList3.ItemsSource = null;
            lbList3.ItemsSource = doubleNode.GetValues();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            listLab3.Clear();
            lbList3.Items.Clear();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Dictionary<string, dynamic> person = new Dictionary<string, dynamic>();
            person.Add("Имя", "Лев");
            person.Add("Возраст", 18);
            person.Add("Пол", "Мужской");

            Results.ItemsSource = person;
        }

    }
}