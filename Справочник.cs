using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекламное_агенство
{
    class Справочник
    {
        public string Name { get; set; }
        public List <string> TypesOfAd { get; set; }
        public List <double> Price { get; set; }

        public Справочник(string Name, List <string> TypesOfAd, List <double> Price)
        {
            this.Name = Name;
            this.TypesOfAd = TypesOfAd;
            this.Price = Price;
        }

        public string Вывод()
        {
            return $"Наименование: {Name}\nВиды реклам: {String.Join(", ", TypesOfAd)}\nСтоимость рекламы: {String.Join(", ", Price)}\n";
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
