using System;
using System.Collections.Generic;
using System.Text;

namespace AlanHesaplama
{
    class Hesapla
    {
        public int UcgenAlani(int taban, int yükseklik)
        {
            return (taban * yükseklik) / 2;
        }
        public int KareAlani(int kenar)
        {
            return kenar * kenar;
        }
        public int DikdortgenAlani(int kenarX, int kenarY)
        {
            return kenarX * kenarY;
        }
        public double DaireAlani(double yaricap)
        {
            double pi = 3.14;
            return pi * yaricap * yaricap;
        }

        
    }
}
