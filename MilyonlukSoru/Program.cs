using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilyonlukSoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****KİM MİLYONER OLMAK İSTER 1 MİLYONLUK SORUNUN CEVABI******
            //SORU: "Türkiye'deki 81 ilin adında bu dört harften hangisi diğer üçünden daha az bulunur?" a) Ş   b) V    c) G    d) H
            string metin = "Adana, Adıyaman, Afyonkarahisar, Ağrı, Aksaray, Amasya, Ankara, Antalya, Ardahan, Artvin, Aydın, Balıkesir, Bartın, Batman, Bayburt, Bilecik, " +
            "Bingöl, Bitlis, Bolu, Burdur, Bursa, Çanakkale, Çankırı, Çorum, Denizli, Diyarbakır, Düzce, Edirne, Elazığ, Erzincan, Erzurum, Eskişehir, Gaziantep, Giresun, " +
            "Gümüşhane, Hakkâri, Hatay, Iğdır, Isparta, İstanbul, İzmir, Kahramanmaraş, Karabük, Karaman, Kars, Kastamonu, Kayseri, Kilis, Kırıkkale, Kırklareli, Kırşehir, " +
            "Kocaeli, Konya, Kütahya, Malatya, Manisa, Mardin, Mersin, Muğla, Muş, Nevşehir, Niğde, Ordu, Osmaniye, Rize, Sakarya, Samsun, Şanlıurfa, Siirt, Sinop, Sivas, Şırnak, " +
            "Tekirdağ, Tokat, Trabzon, Tunceli, Uşak, Van, Yalova, Yozgat, Zonguldak";

            int gHarfiSayaci = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == 'g' || metin[i] == 'G')
                {
                    gHarfiSayaci++;
                }
            }
            Console.WriteLine("Metin içindeki 'g' harfi sayısı: " + gHarfiSayaci);

            int vHarfiSayaci = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == 'V' || metin[i] == 'v')
                {
                    vHarfiSayaci++;
                }
            }
            Console.WriteLine("Metin içindeki 'v' harfi sayısı: " + vHarfiSayaci);

            int sHarfiSayaci = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == 'Ş' || metin[i] == 'ş')
                {
                    sHarfiSayaci++;
                }
            }
            Console.WriteLine("Metin içindeki 'ş' harfi sayısı: " + sHarfiSayaci);

            int hHarfiSayaci = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == 'H' || metin[i] == 'h')
                {
                    hHarfiSayaci++;
                }
            }
            Console.WriteLine("Metin içindeki 'h' harfi sayısı: " + hHarfiSayaci);
            Console.ReadLine();
        }
    }
}
