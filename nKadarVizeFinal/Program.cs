using System;

namespace nKadarVizeFinal
{
    class Program
    {
        static void Main(string[] args)

        /* Bahar Merdamert n kadar öğrenci için vize,final notları istenerek; içlerinden en büyüğü,en küçüğü ve genel ortalamayı hesaplayan uygulama */
        {
            Console.WriteLine("Lütfen notunu girmek istediğiniz öğrenci adedini belirtiniz...");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            double enb = 0;
            double end = 100;
            double toplam = 0;
            double genelOrtalama = 0;
            for (i=0;i<n;i++)

            {
                Console.WriteLine($"Lütfen {i+1}. öğrencinin vize notunu giriniz...");
                int vize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Lütfen {i + 1}. öğrencinin final notunu giriniz...");
                int final = Convert.ToInt32(Console.ReadLine());

                double ortalama = (vize * 0.4) + (final * 0.6);

                if(ortalama>enb)
                {
                    enb = ortalama;
                }

                if(ortalama<end)
                {
                    end = ortalama;
                }
            
                toplam+= ortalama;
               
            }
            genelOrtalama = toplam / n;

            Console.WriteLine($"En yüksek ortalama = {enb}");
            Console.WriteLine($"En düşük ortalama = {end}");
            Console.WriteLine($"Genel ortalama = {genelOrtalama}");
            Console.ReadKey();
        }
    }
}
