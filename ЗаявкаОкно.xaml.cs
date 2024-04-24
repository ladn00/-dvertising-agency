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
using System.Windows.Shapes;
using System.IO;
namespace Рекламное_агенство
{
    /// <summary>
    /// Логика взаимодействия для ЗаявкаОкно.xaml
    /// </summary>
    public partial class ЗаявкаОкно : Window
    {
        public ЗаявкаОкно()
        {
            InitializeComponent();

        }
        private void bt_Accept(object sender, RoutedEventArgs e)
        {
            try
            {
                // Запись новых данных в файл Заявки.txt и в коллекцию zayavki
                StreamWriter sw = new StreamWriter("Заявки.txt", true);
                Заявка zayavka = new Заявка(tb_Type.Text, tb_Vol.Text, tb_Editors.Text, tb_Count.Text, tb_Dop.Text, DateTime.Now, "Незавершенная");
                sw.WriteLine($"{zayavka.TypeOfAd}|{zayavka.AdvertisingVolume}|{zayavka.DesiredPubl}|{zayavka.Count}|{zayavka.DopInf}|{zayavka.Date:d}|{zayavka.Status}");
                sw.Close();
                MainWindow.zayavki.Add(zayavka);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_All(object sender, RoutedEventArgs e)
        {
            //Вывести все заявки
            lb1.Items.Clear();
            foreach(var z in MainWindow.zayavki)
            {
                if(z != null)
                    lb1.Items.Add(z.Вывод());

            }
        }

        private void bt_Otch(object sender, RoutedEventArgs e)
        {
            //Создание отчетности по завершенным и незавершенным заявкам
            StreamWriter sr = new StreamWriter("Завершенные.txt");
            sr.WriteLine(String.Format("{0, -20} | {1, -20} | {2, -20} | {3, -25} | {4, -25} | {5, -20}", "Вид рекламы", "Объем рекламы", "Желаемые издания", "Кол-во выходов рекламы", "Дата", "Доп. инф."));
            foreach(Заявка z in MainWindow.zayavki)
            {
                if(z.Status.Trim() == "Завершенная")
                    sr.WriteLine(String.Format("{0, -20} | {1, -20} | {2, -20} | {3, -25} | {4, -25} | {5, -20}", z.TypeOfAd, z.AdvertisingVolume, z.DesiredPubl, z.Count, z.Date.ToString("d"), z.DopInf));

            }
            sr.Close();

            StreamWriter sr1 = new StreamWriter("Незавершенные.txt");
            sr1.WriteLine(String.Format("{0, -20} | {1, -20} | {2, -20} | {3, -25} | {4, -25} | {5, -20}", "Вид рекламы", "Объем рекламы", "Желаемые издания", "Кол-во выходов рекламы", "Дата", "Доп. инф."));
            foreach (Заявка z in MainWindow.zayavki)
            {
                if (z.Status.Trim() == "Незавершенная")
                    sr1.WriteLine(String.Format("{0, -20} | {1, -20} | {2, -20} | {3, -25} | {4, -25} | {5, -20}", z.TypeOfAd, z.AdvertisingVolume, z.DesiredPubl, z.Count, z.Date.ToString("d"), z.DopInf));
            }
            sr1.Close();

            // Открытие двух файлов с отчетами
            System.Diagnostics.Process.Start("Завершенные.txt");
            System.Diagnostics.Process.Start("Незавершенные.txt");
        }

        private void bt_Status(object sender, RoutedEventArgs e)
        {
            //Выполнение заявки
            if (lb1.SelectedItem != null)
            {
                MainWindow.zayavki[lb1.SelectedIndex].Status = "Завершенная";
                string[] lines = File.ReadAllLines("Заявки.txt");
                lines[lb1.SelectedIndex] = lines[lb1.SelectedIndex].Replace(lines[lb1.SelectedIndex].Split('|')[6], "Завершенная");
                File.WriteAllLines("Заявки.txt", lines);
                bt_All(sender, e);
            }
            
        }

        private void bt_Search(object sender, RoutedEventArgs e)
        {
            // Поиск заявок по введенной дате
            try
            {
                if (string.IsNullOrEmpty(tb_Date.Text))
                    throw new Exception("Сначала введите дату");

                lb1.Items.Clear();
                foreach(Заявка z in MainWindow.zayavki)
                {
                    if (z.Date == DateTime.Parse(tb_Date.Text))
                        lb1.Items.Add(z.Вывод());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
