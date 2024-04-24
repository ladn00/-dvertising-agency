using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекламное_агенство
{
    public class Заявка
    {
        public int Id { get; set; }
        private static int Ids;
        public string TypeOfAd { get; set; }
        public string AdvertisingVolume { get; set; }
        public string DesiredPubl { get; set; }
        public string Count { get; set; }
        public string DopInf { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public Заявка(string TypeOfAd, string AdvertisingVolume, string DesiredPubl, string Count, string DopInf, DateTime Date, string Status)
        {
            Id = ++Ids; //автоматическое определение id заявки
            this.TypeOfAd = TypeOfAd;
            this.AdvertisingVolume = AdvertisingVolume;
            this.DesiredPubl = DesiredPubl;
            this.Count = Count;
            this.DopInf = DopInf;
            this.Date = Date;
            this.Status = Status;
        }
        public string Вывод()
        {
            return $"Номер заявки: {Id}\nВид рекламы: {TypeOfAd}\nОбъем рекламы: {AdvertisingVolume}\nЖелаемые издания: {DesiredPubl}\n" +
                $"Кол-во выходов рекламы: {Count}\nДоп. информация: {DopInf}\nДата: {Date:d}\nСтатус: {Status}";
        }

        public override string ToString() => $"{Id}";
    }
}
