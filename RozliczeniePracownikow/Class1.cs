using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozliczeniePracownikow
{
    public class Rozliczenia
    {
        public virtual double kosztPrzejazduSamochod(int kilometry, float spalanie, float cenaLitr, float dodatkowe)
        {
            return Math.Round((kilometry / 100 * spalanie * cenaLitr + dodatkowe), 2);
        }
        public decimal chorobowe(int liczbaDni, float wynagrodzenie, float stawkaChorobowa = 0.8F)
        {
            return Math.Round((decimal)(wynagrodzenie * 12 / 360 * liczbaDni * stawkaChorobowa), 1);
        }
    }
}
