// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

{

    SelamVer(isim: "Şevval");
    SelamVer(isim: "Ömer");
    SelamVer(isim: "Kalben");
    SelamVer();

    int sonuc = Topla(6,58);

    //Diziler / Arrays

    //string ogrenci1 = "Şevval";
    //string ogrenci2 = "Ömer";
    //string ogrenci3 = "Kalben";



    //string[] ogrenciler = new string[3];
    //ogrenciler[0] = "Şevval";
    //ogrenciler[1] = "Ömer";
    //ogrenciler[2] = "Kalben";

    //for(int i=0; i< ogrenciler.Length; i++)
    //{

    //}

    string[] sehirler1 = new[] { "Ankara", "İstabul", "İzmir" };
    string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

    sehirler2 = sehirler1;
    sehirler1[0] = "Adana";

    Console.WriteLine(sehirler2[0]);

    Person person1 = new Person();
    person1.FirstName = "Engin";
    person1.LastName = "DEMİROG";
    person1.DateOfBirthYear = 1985;
    person1.NationalIdentity = 123;


    Person person2 =new Person();
    person2.FirstName = "Murat";

    foreach(string sehir in sehirler1)
    {
        Console.WriteLine(sehir);
    }

    //MyList
    List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
    yeniSehirler1.Add(item: "Adana 1");
    foreach (var sehir in yeniSehirler1)
    {
        Console.WriteLine(sehir);
    }

    PttManager pttManager = new PttManager(new PersonManager());
    pttManager.GiveMask(person1);

   


    Console.ReadLine();

    //resharper

    static void SelamVer(string isim="isimsiz")
    {
        Console.WriteLine("Merhaba "+ isim );
    }

    static int Topla(int sayi1 = 5, int sayi2=10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam:"+ sonuc.ToString());
        return sonuc;
    }
}

//    static void Degiskenler()
//    {
//        string mesaj = "Merhaba";
//        double tutar = 100000;//db den gelir
//        int sayi = 100;
//        bool girisYapmisMi = false;

//        string ad = "Şevval";
//        string soyad = "Deniz";
//        int dogumYili = 1997;
//        long tcNo = 12345678910;



//        Console.WriteLine(tutar * 1.18);

//        Console.WriteLine(tutar * 1.18);
//    }
//}

////pascal casing
//public class Vatandas
//{
//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public int DogumYili { get; set; }  
//    public long TcnNo { get; set; } 

//}