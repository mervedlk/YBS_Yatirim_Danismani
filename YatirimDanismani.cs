using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Double dolar1, dolar2, dolar3;
            Console.Write("geçen yılın dolar kurunu giriniz:");
            dolar1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2 yıl önceki dolar kurunu giriniz:");
            dolar2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3 yıl önceki dolar kurunu giriniz:");
            dolar3 = Convert.ToDouble(Console.ReadLine());
            double artisd1 = (dolar1 - dolar2) / dolar2;
            double artisd2 = (dolar2 - dolar3) / dolar3;
            double ortartisd = (artisd1 + artisd2) / 2;
            Console.Write("ortalama dolar artışı:%{0}",ortartisd*100);

            Double euro1, euro2, euro3;
            Console.Write("\n\ngeçen yılın euro kurunu giriniz:");
            euro1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2 yıl önceki euro kurunu giriniz:");
            euro2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3 yıl önceki euro kurunu giriniz:");
            euro3 = Convert.ToDouble(Console.ReadLine());
            double artise1 = (euro1 - euro2) / euro2;
            double artise2 = (euro2 - euro3) / euro3;
            double ortartise = (artise1 + artise2) / 2;
            Console.Write("ortalama euro artışı:%{0}", ortartise * 100);

            Double altin1, altin2, altin3;
            Console.Write("\n\ngeçen yılın altin kurunu giriniz:");
            altin1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2 yıl önceki altin kurunu giriniz:");
            altin2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3 yıl önceki altin kurunu giriniz:");
            altin3 = Convert.ToDouble(Console.ReadLine());
            double artisa1 = (altin1 - altin2) / altin2;
            double artisa2 = (altin2 - altin3) / altin3;
            double ortartisa = (artisa1 + artisa2) / 2;
            Console.Write("ortalama altin artışı:%{0}", ortartisa * 100);

            double dolarTahmin = dolar1;
            double euroTahmin = euro1;
            double altinTahmin = altin1;

            Console.WriteLine("\n\n--- Gelecek 5 Yıllık Yatırım Projeksiyonu ---");
           

            for (int yil = 1; yil <= 5; yil++)
            {
                dolarTahmin = dolarTahmin * (1 + ortartisd);
                euroTahmin = euroTahmin * (1 + ortartise);
                altinTahmin = altinTahmin * (1 + ortartisa);
                Console.WriteLine("{0}. Yıl -> Dolar: {1:N2} TL | Euro: {2:N2} TL | Altın: {3:N2} TL", yil, dolarTahmin, euroTahmin, altinTahmin);
                
            }
            Console.Write("\nLütfen yatırım yapacağınız ana para tutarını (TL) giriniz: ");
            double anaPara = Convert.ToDouble(Console.ReadLine());

            double toplamDolar = (anaPara / dolar1) * dolarTahmin;
            double toplamEuro = (anaPara / euro1) * euroTahmin;
            double toplamAltin = (anaPara / altin1) * altinTahmin;

            Console.WriteLine("\n5 Yıl Sonraki Tahmini Bakiyeleriniz:");
            Console.WriteLine("Dolar ile: {0:N2} TL", toplamDolar);
            Console.WriteLine("Euro ile: {0:N2} TL", toplamEuro);
            Console.WriteLine("Altın ile: {0:N2} TL", toplamAltin);

            Console.WriteLine("\n--- YBS YATIRIM DANIŞMANI ÖNERİSİ ---");
            if (toplamAltin > toplamDolar && toplamAltin > toplamEuro)
            {
                Console.WriteLine("Tavsiye: Geçmiş trendler devam ederse en kârlı yatırım ALTIN gibi duruyor.");
            }
            else if (toplamDolar > toplamEuro)
            {
                Console.WriteLine("Tavsiye: Geçmiş trendler devam ederse en kârlı yatırım DOLAR gibi duruyor.");
            }
            else
            {
                Console.WriteLine("Tavsiye: Geçmiş trendler devam ederse en kârlı yatırım EURO gibi duruyor.");
            }

            Console.ReadKey();
        }
    }
}
