//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab10_11
//{
//    class Program
//    {
//    static void Main()
//    {
//        List<Client> clients = new List<Client>
//    {
//        new Client("Ivanov", 100, 50, 12),
//        new Client("Petrov", 120, 60, 10),
//        new Client("Sidorov", 110, 55, 15)
//    };

//        string filePath = "clients.txt";

//        // Запись клиентов в бинарный файл
//        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
//        {
//            foreach (var client in clients)
//            {
//                writer.Write(client.LastName);
//                writer.Write(client.BasicPackageCost);
//                writer.Write(client.SocialPackageCost);
//                writer.Write(client.MonthsPaid);
//            }
//        }

//        // Чтение клиентов из бинарного файла и вычисление разницы в оплате
//using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
//{
//    while (reader.BaseStream.Position != reader.BaseStream.Length)
//    {
//        string lastName = reader.ReadString();
//        decimal basicPackageCost = reader.ReadDecimal();
//        decimal socialPackageCost = reader.ReadDecimal();
//        int monthsPaid = reader.ReadInt32();

//        decimal basicTotal = basicPackageCost * monthsPaid;
//        decimal socialTotal = socialPackageCost * monthsPaid;
//        decimal difference = basicTotal - socialTotal;

    //                Console.WriteLine($"Клиент: {lastName}");
    //                Console.WriteLine($"Базовый пакет: {basicTotal:C}");
    //                Console.WriteLine($"Социальный пакет: {socialTotal:C}");
    //                Console.WriteLine($"Разница: {difference:C}");
    //                Console.WriteLine();
    //            }
    //        }
    //    }
    //}
    //}
