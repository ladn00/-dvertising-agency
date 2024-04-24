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
using System.IO;

namespace Рекламное_агенство
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        // 2 основные коллекции с завявками и рекламодателями
        public static List<Заявка> zayavki = new List<Заявка>();
        List<Рекламодатель> reklamodateli = new List<Рекламодатель>();

        public MainWindow()
        {
            InitializeComponent();

            //Заполнение данных из файлов Заявки.txt и Рекламодатель.txt при запуске программы
            try
            {
                // Заполнение коллекции со всеми заявками
                StreamReader sr = new StreamReader("Заявки.txt");
                string stroka = sr.ReadLine();
                while (!string.IsNullOrEmpty(stroka))
                {
                    zayavki.Add(new Заявка(stroka.Split('|')[0], stroka.Split('|')[1], stroka.Split('|')[2], stroka.Split('|')[3], stroka.Split('|')[4], Convert.ToDateTime(Convert.ToDateTime(stroka.Split('|')[5]).ToString("D")), stroka.Split('|')[6]));
                    stroka = sr.ReadLine();
                }
                sr.Close();

                cb1.ItemsSource = zayavki;

                // Заполнение коллекции со всеми рекламодателями
                StreamReader sr1 = new StreamReader("Рекламодатель.txt");
                stroka = sr1.ReadLine();
                int index = 0;
                while (!string.IsNullOrEmpty(stroka))
                {
                    reklamodateli.Add(new Рекламодатель(stroka.Split('|')[0], stroka.Split('|')[1], stroka.Split('|')[2], stroka.Split('|')[3], null, double.Parse(stroka.Split('|')[5]), stroka.Split('|')[6], stroka.Split('|')[7]));

                    // Присвоение заявки рекламодателю по номеру (Id) заявки
                    for (int i = 0; i < zayavki.Count; i++)
                    {
                        if (zayavki[i].Id == int.Parse(stroka.Split('|')[4]))
                        {
                            reklamodateli[index].Заявка = zayavki[i];
                        }
                    }
                    index++;
                    stroka = sr1.ReadLine();
                }
                sr1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_All(object sender, RoutedEventArgs e)
        {
            //Вывести всех рекламодателей
            foreach (Рекламодатель r in reklamodateli)
            {
                lb1.Items.Add(r.Вывод());
            }
        }

        private void bt_Accept(object sender, RoutedEventArgs e)
        {
            //Подтвердить регистрацию рекламодателя
            try
            {
                // Номер заявки обязательно должен быть выбран
                if (cb1.SelectedItem == null)
                    throw new Exception("Выберите заявку");

                // Добавление нового рекламодателя, но пока с пустой заявкой
                Рекламодатель rekl = new Рекламодатель(tb_Name.Text, tb_Adress.Text, tb_Supervisor.Text, tb_Telephone.Text, null, double.Parse(tb_Payment.Text), tb_Edition.Text, tb_Place.Text);

                // Присвоение заявки рекламодателю по номеру (Id) заявки
                for (int i = 0; i < zayavki.Count; i++)
                {
                    if (zayavki[i].Id == int.Parse(cb1.SelectedItem.ToString()))
                    {
                        rekl.Заявка = zayavki[i];
                    }
                }
                reklamodateli.Add(rekl);

                StreamWriter sw = new StreamWriter("Рекламодатель.txt", true);
                sw.WriteLine($"{rekl.Name}|{rekl.Adress}|{rekl.Supervisor}|{rekl.Telephone}|{rekl.Заявка.Id}|{rekl.Payment}|{rekl.Edition}|{rekl.Place}");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_add(object sender, RoutedEventArgs e)
        {
            //Открыть окно Заявки
            ЗаявкаОкно w = new ЗаявкаОкно();
            w.Show();
        }

        private void bt_Sparvochnik(object sender, RoutedEventArgs e)
        {
            //Кнопка Справочник для вывода всех изданий, типов рекламы и их цен
            try
            {

                List<Справочник> spr = new List<Справочник>();

                for (int i = 0; i < reklamodateli.Count; i++)
                {
                    // т.к. тип Справочник хранит в себе коллекцию предоставляемых типов реклам и их цены,
                    // то следует создать 2 коллекции для их дальнейшего заполнения
                    List<string> types = new List<string>(); 
                    List<double> prices = new List<double>();

                    for (int j = 0; j < reklamodateli.Count; j++) //Заполнение коллекций с типами реклам и их ценами одного издательства
                    {
                        if (reklamodateli[i].Edition == reklamodateli[j].Edition)
                        {
                            types.Add(reklamodateli[j].Заявка.TypeOfAd);
                            prices.Add(reklamodateli[j].Payment);
                        }
                    }
                    Справочник sp = new Справочник(reklamodateli[i].Edition, types, prices);

                    spr.Add(sp); //Добавление в коллекцию spr издательства

                }
                lb1.Items.Clear();
                foreach (Справочник s in spr)
                {
                    // Вывод всех издательств без повторений
                    if (!lb1.Items.Contains(s.Вывод()))
                        lb1.Items.Add(s.Вывод());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
