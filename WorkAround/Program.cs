using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim: "Melike"); //parametre çağırma
            SelamVer(isim: "Kadriye");
            SelamVer(isim: "Ceylan");
            SelamVer();
            int sonuc = Topla();



            //Diziler /Arrays
            string ogrenci1 = "Melike";
            string ogrenci2 = "Kadriye";
            string ogrenci3 = "Ceylan";

            //zor yöntem
            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);


            //string array içerisinde tanımlanan tipte veri tutan yapılardır.
            string[] ogrenciler = new string[3]; //3 elemanlı dizi tanımlaması
            ogrenciler[0] = "Melike";
            ogrenciler[1] = "Kadriye";
            ogrenciler[2] = "Ceylan";
            //ogrenciler[3] = "Ali"; hata verir çünkü eleman sayısı 3 dedik
            ogrenciler = new string[4]; //burada sadece Ali çıktısını verir
            ogrenciler[3] = "Ali";



            //döngüler birbirine benzeyen işleri tekrar tekrar yapmak yerine bir kerede yapma işlemidir.
            for (int i = 0; i < ogrenciler.Length; i++)
            {
               // Console.WriteLine(ogrenciler[i]);
            }


            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);


            Person person1 = new Person();
            person1.FirstName = "Kamil";
            person1.LastName = "Öztekin";
            person1.DateOfBirthYear = 1996;
            person1.NationalIdentity = 11057046408;


            Person person2 = new Person();
            person2.FirstName = "Kadriye";


            foreach (string sehir in sehirler1) //sehir her bir şehri listede gezerken verdiğimiz takma ad
            {
                Console.WriteLine(sehir);
            }

            //generic collection 
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1"};
            yeniSehirler1.Add("Adana 1"); //listeye yeni eklenen veriyi diğerlerini kaybederek değil onlarla beraber çalışmasını sağlar
            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim="noname") 
            //method yöntemi, parantez içindekiler parametre, noname eğer boş gelirse (default parametre)
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1=12, int sayi2=13)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " +sonuc.ToString());
            return sonuc;
        }
    }

    
}
