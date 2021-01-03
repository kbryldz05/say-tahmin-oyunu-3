using System;

namespace sayı_tahmin_oyunu_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int tutulan = 0;
            int hak = 0;
            int kullanilanHak = 0;

            int ustAralik = 0;
            int altAralik = 1;


            Console.WriteLine("kolay seviye (1-10)-6 hak icin '1'");
            Console.WriteLine("orta seviye (1-25)-4 hak icin'2'");
            Console.WriteLine("zor seviye (1-50)-2 hak icin '3'");
            Console.Write("zorluk seviyesini seçiniz = ");
            int seviye = Convert.ToInt32(Console.ReadLine());

            switch (seviye)
            {
                case 1:
                    //+1 ekleme sebebi max değeri hesaba dahil etmemesi, 1,11 dersek 10 da gelebilir
                    //1,10 dersek en fazla 9 olabilir size kalmış
                    ustAralik = 10;
                    tutulan = rand.Next(1, ustAralik + 1);
                    hak = 6;
                    break;

                case 2:
                    ustAralik = 25;
                    tutulan = rand.Next(1, ustAralik + 1);
                    hak = 4;
                    break;

                case 3:
                    ustAralik = 50;
                    tutulan = rand.Next(1, ustAralik + 1);
                    hak = 2;
                    break;
                default:
                    Console.Write("Geçerli olmayan zorluk seçtiniz");
                    break;

            }

            int sayi = 0;
            while (kullanilanHak < hak)
            {
                Console.Write("{0} - {1} arasında bir sayı giriniz : ", altAralik, ustAralik);
                sayi = int.Parse(Console.ReadLine());
                kullanilanHak++;

                if (sayi == tutulan)
                {
                    //kullanıcının tahmini doğrudur.
                    Console.WriteLine("Tebrikler.{0} hakkınızda bildiniz.", kullanilanHak);
                    break;
                }
                else
                {
                    if (sayi > ustAralik)
                    {
                        Console.WriteLine("Aralıktan büyük bir sayı girdiniz.");
                        break;
                    }
                    else if (sayi < altAralik)
                    {
                        Console.WriteLine("Aralıktan küçük bir sayı girdiniz.");
                        break;
                    }

                    if (sayi > tutulan)
                    {
                        Console.WriteLine("Daha küçük bir değer giriniz.");
                    }
                    else
                    {
                        Console.WriteLine("Daha büyük bir değer giriniz.");
                    }

                }
                Console.WriteLine("{0} hakkınız kaldı .", hak - kullanilanHak);
                {
                    if (hak - kullanilanHak == 0)
                    {
                        Console.WriteLine(" Üzgünüz hakkınız bitti.");
                        Console.WriteLine("tutan sayı :{0}", tutulan);
                        break;
                    }
                }
            }
        }
    }
}
