using System.Collections;

namespace Patika_Dev_Odev_2.Patika_Dev_Odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.Negatif ve numeric olmayan girişleri engelleyin. Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde sıralayın. Her iki dizinin eleman sayısınını ve ortalamasını ekrana yazdırın.
            
            // int n = 5;
            // ArrayList asalSayilistesi = new ArrayList();
            // ArrayList asalolmayanListesi = new ArrayList();
            // int kontrol = 0;  

            // for (int i = 0; i < n; i++)
            // {
            //     Console.WriteLine("{0}. sayıyı giriniz: ", i + 1);
            //     int sayi = int.Parse(Console.ReadLine());
            //     for (int j = 2; j < sayi; j++)
            //     {
            //         if (sayi % j == 0)
            //         {
            //             kontrol ++;
            //         }    
            //     }
            //     if (kontrol == 0)
            //     {
            //         asalSayilistesi.Add(sayi);
            //     }
            //     else
            //     {
            //         asalolmayanListesi.Add(sayi);
            //     }
                
            //     asalSayilistesi.Sort();
            //     asalolmayanListesi.Sort();
            //     foreach (var asal in asalSayilistesi)
            //     {
            //         Console.WriteLine(asal);
            //     }
            
            // }


            Console.WriteLine("******* Soru-2 *******");
            // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.

            // int[] sayilar = new int[20];
            // int[] kücükSayılar= new int[3];
            // int[] büyükSayılar = new int[3];

            // Console.WriteLine("20 adet sayı giriniz.");
            // for (int i = 0; i < 20; i++)
            // {
            //     Console.Write("{0}. sayıyı giriniz: ", i + 1);
            //     int sayi = int.Parse(Console.ReadLine());
            //     sayilar[i] = sayi;
            // }
            //     Array.Sort(sayilar);
            //     double büyüksayıOrtalama = 0;
            //     double kücüksayıortalama = 0;
            //     int büyüksayıtoplam = 0;
            //     int kücüksayıtoplam = 0;
            //     double ortalamaToplam = 0;

            //     for (int j = 0; j < 3; j++)
            //     {
            //         kücükSayılar[j] = sayilar[j];
            //         kücüksayıtoplam += kücükSayılar[j];
            //     }
            //         kücüksayıortalama = kücüksayıtoplam / 3;
            //         Console.WriteLine("Küçük sayıların ortalaması: "+ kücüksayıortalama);

            //     Array.Reverse(sayilar);
            //     for (int j = 0; j < 3; j++)
            //     {
            //         büyükSayılar[j] = sayilar[j];
            //         büyüksayıtoplam += büyükSayılar[j];
            //     }
            //         büyüksayıOrtalama = büyüksayıtoplam / 3;
            //         Console.WriteLine("Büyük sayıların ortalaması: "+ büyüksayıOrtalama);

            //         ortalamaToplam = büyüksayıOrtalama + kücüksayıortalama;
            //         Console.WriteLine("Büyük sayı ortalaması + Küçük sayı ortalaması= "+ ortalamaToplam);

                Console.WriteLine("****** Soru-3 *******");
                // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

                Console.Write("Bir cümle giriniz: ");
                string cümle = Console.ReadLine();
                cümle.ToLower();
                ArrayList sesliharfler = new ArrayList();

                    foreach (var harf in cümle)
                {
                    if (harf== 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'u' || harf == 'ü' || harf == 'o' || harf == 'ö' )
                    {
                        sesliharfler.Add(harf);
                    }
                }

                Console.WriteLine("Cümlede kullanılan sesli harfler:");
                foreach (var item in sesliharfler)
                {
                    Console.Write(item +",");
                }


        }




                

            


                 



        

    }
}