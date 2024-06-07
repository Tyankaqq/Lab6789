using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
    /// Логика взаимодействия для Lab11.xaml
    /// </summary>
    public partial class Lab11 : Page
    {
        public Lab11()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Бинарные файлы(*.dat)|*.dat";

            if (sfd.ShowDialog() == true)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(sfd.FileName, FileMode.Create)))
                {
                   
                       writer.Write(SurName.Text);
                       writer.Write(double.Parse(CountBasePacket.Text));
                       writer.Write(double.Parse(CountSocialPacket.Text));
                       writer.Write(int.Parse(CountMonthPay.Text));
                       writer.Close();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Бинарные файлы(*.dat)|*.dat";

            if (ofd.ShowDialog() == true)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(ofd.FileName, FileMode.Open)))
                {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        string lastName = reader.ReadString();
                        double basicPackageCost = reader.ReadDouble();
                        double socialPackageCost = reader.ReadDouble();
                        int monthsPaid = reader.ReadInt32();

                        double basicTotal = basicPackageCost * monthsPaid;
                        double socialTotal = socialPackageCost * monthsPaid;
                        double difference = Math.Abs(basicTotal - socialTotal);

                        string result = $"Фамилия: {lastName}\nБазовый пакет: {basicPackageCost}\nСоциальный пакет: {socialPackageCost}\nКол-во оплачеваемых месяцев: {monthsPaid}\nРазница в оплате: {difference}";

                        DiffPriceText.Text = result;
                    }
                }
            }
        }
    }
}
