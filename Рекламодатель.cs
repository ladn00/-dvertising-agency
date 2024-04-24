using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекламное_агенство
{
    public class Рекламодатель
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Supervisor { get; set; }
        public string Telephone { get; set; }
        public Заявка Заявка { get; set; }
        public double Payment { get; set; }
        public string Edition { get; set; }
        public string Place { get; set; }

        public Рекламодатель(string Name, string Adress, string Supervisor, string Telephone, Заявка Заявка, double Payment, string Edition, string Place)
        {
            this.Name = Name;
            this.Adress = Adress;
            this.Supervisor = Supervisor;
            this.Telephone = Telephone;
            this.Заявка = Заявка;
            this.Payment = Payment;
            this.Edition = Edition;
            this.Place = Place;
        }

        public string Вывод()
        {
            return $"Наименование: {Name}\nРуководитель: {Supervisor}\nТелефон: {Telephone}\nЗаявка: {Заявка.Вывод()}\nОплата: {Payment} руб.\n" +
                $"Издание: {Edition}\nМесто размещения рекламы: {Edition}\n";
        }
    }
}
