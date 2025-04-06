using EmlakciLib;
using KutuphaneLib1;

namespace emlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Kitap kitap = new Kitap();
            kitap.KitapAdi = "Martin Eden";
            kitap.Yazar = "Jack London";
            kitap.BasimTarihi = new DateTime(2002, 3, 26);
            kitap.StokGirisTarihi=new DateTime(2003, 6, 18);


            //try
            //{
            //    Console.WriteLine("Kitap adini giriniz: ");
            //    kitap.KitapAdi = Console.ReadLine();
            //    Console.WriteLine("Kitabin yazarini giriniz: ");
            //    kitap.Yazar = Console.ReadLine();
            //    Console.WriteLine("Lütfen basim tarihini giriniz (gg/aa/yyyy):");
            //    kitap.BasimTarihi = DateTime.Parse(Console.ReadLine());
            //    Console.WriteLine("Lütfen stok giris tarihini giriniz (gg/aa/yyyy):");
            //    kitap.StokGirisTarihi = DateTime.Parse(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{

            //    {
            //        Console.WriteLine(ex.Message);
            //    }


            //}


            //try
            //{
            //    // Kitap adı alınıyor.
            //    Console.WriteLine("Kitap adini giriniz: ");
            //    kitap.KitapAdi = Console.ReadLine();

            //    // Yazar adı alınıyor.
            //    Console.WriteLine("Kitabin yazarini giriniz: ");
            //    kitap.Yazar = Console.ReadLine();

            //    // Basım tarihi alınıyor ve geçerli formatta olup olmadığı kontrol ediliyor.
            //    Console.WriteLine("Lütfen basim tarihini giriniz (gg/aa/yyyy):");
            //    string basimTarihiInput = Console.ReadLine();
            //    if (!DateTime.TryParse(basimTarihiInput, out DateTime basimTarihi))
            //    {
            //        throw new Exception("Geçersiz basım tarihi formatı.");
            //    }
            //    kitap.BasimTarihi = basimTarihi;

            //    // Stok giriş tarihi alınıyor ve geçerli formatta olup olmadığı kontrol ediliyor.
            //    Console.WriteLine("Lütfen stok giris tarihini giriniz (gg/aa/yyyy):");
            //    string stokGirisTarihiInput = Console.ReadLine();
            //    if (!DateTime.TryParse(stokGirisTarihiInput, out DateTime stokGirisTarihi))
            //    {
            //        throw new Exception("Geçersiz stok giriş tarihi formatı.");
            //    }
            //    kitap.StokGirisTarihi = stokGirisTarihi;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Hata: {ex.Message}");
            //}

            try
            {
                // Kitap adı alınıyor.
                Console.WriteLine("Kitap adini giriniz: ");
                kitap.KitapAdi = Console.ReadLine();

                // Yazar adı alınıyor.
                Console.WriteLine("Kitabin yazarini giriniz: ");
                kitap.Yazar = Console.ReadLine();

                // Basım tarihi alınıyor ve geçerli formatta olup olmadığı kontrol ediliyor.
                Console.WriteLine("Lütfen basim tarihini giriniz (gg/aa/yyyy):");
                string basimTarihiInput = Console.ReadLine();
                DateTime basimTarihi;
                bool isBasimTarihiValid = DateTime.TryParseExact(basimTarihiInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out basimTarihi);
                if (!isBasimTarihiValid)
                {
                    throw new Exception("Geçersiz basım tarihi formatı. Lütfen 'gg/aa/yyyy' formatında girin.");
                }
                kitap.BasimTarihi = basimTarihi;

                // Stok giriş tarihi alınıyor ve geçerli formatta olup olmadığı kontrol ediliyor.
                Console.WriteLine("Lütfen stok giris tarihini giriniz (gg/aa/yyyy):");
                string stokGirisTarihiInput = Console.ReadLine();
                DateTime stokGirisTarihi;
                bool isStokGirisTarihiValid = DateTime.TryParseExact(stokGirisTarihiInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out stokGirisTarihi);
                if (!isStokGirisTarihiValid)
                {
                    throw new Exception("Geçersiz stok giriş tarihi formatı. Lütfen 'gg/aa/yyyy' formatında girin.");
                }

                // Burada stok giriş tarihinin basım tarihinden önce olup olmadığını kontrol ediyoruz
                if (stokGirisTarihi < basimTarihi)
                {
                    throw new Exception("Stok giris tarihi basim tarihinden once olamaz.");
                }

                kitap.StokGirisTarihi = stokGirisTarihi;

                Console.WriteLine("Kitap başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }




            //Ev evim = new Ev();
            //evim.alan = 350;
            //evim.semt = "kizilay";
            //evim.katNo = 12;
            //evim.odaSayisi = 5;
            //Console.WriteLine(evim.EvBilgileri());

            //Ev evim2 = new Ev();
            //evim2.alan = 250;
            //evim2.semt = "kizilay";
            //evim2.katNo = 6;
            //evim2.odaSayisi = 4;
            //Console.WriteLine(evim2.EvBilgileri());

            //var evim3 = new Ev(3,2,200);
            // Console.WriteLine(evim3.EvBilgileri());

            //var evim4 = new Ev(4, 7,300);
            //Console.WriteLine(evim4.EvBilgileri());

            //Ev evim5 = new Ev { katNo = 1, alan = 300, odaSayisi = 6, semt = "gazi" };  //tek satirda nesne turetme


            //Bilgisayar pc = new Bilgisayar();
            //pc.ram = 32;
            //pc.vram = 8;
            //pc.fiyat = 39.000;
            //pc.depolama = 1;
            //pc.islemci = "ryzen 5 5500";
            //pc.ekranKarti = "AMD RADEON GRAPHICS";

            //try
            //{
            //    var evim6 = new Ev();
            //    Console.WriteLine("Oda sayisini giriniz: ");
            //    evim6.SetOdaSayisi(int.Parse(Console.ReadLine()));

            //    //if (evim6.odaSayisi < 0)
            //    //{
            //    //    evim6.odaSayisi=Math.Abs(evim6.odaSayisi);
            //    //}
            //    Console.WriteLine("kat numarasini giriniz: ");
            //    evim6.SetKatNo(int.Parse(Console.ReadLine()));

            //    Console.WriteLine("alan giriniz: ");
            //    evim6.Alan = int.Parse(Console.ReadLine());

            //    Console.WriteLine("semt giriniz: ");
            //    evim6.SetSemt((Console.ReadLine()));

            //    Console.WriteLine(evim6.EvBilgileri());
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine(Ev.Sayac);


            //Console.WriteLine($"oda sayisi:{evim6.GetOdaSayisi()} ");
            //Console.WriteLine($"Buyukluk: {evim6.}");

        }
        
       
        

    }

   
}
// Ev evim = new Ev();  
// Ev class'indan nesne uretildi. evim:referanstir. nesnelerin  bellekteki adresini tutarlar. bellegin STACK bolgesinde tutulur.
// Ev: Class. ayni zamanda bir veri tipidir.
// new: bellekte nesne olusturmaya yarayan keyworddur. 
// Nesne: new anahtar sozcugu ile HEAP bolgesinde olusturulurlar.
// Erisim Belirleyiciler ( Access Modifiers ): 
// private: sadece class icinden erisilebilir uyelerdir.
// public: class icinde tanimlanan uyeye her yerden erisim imkani saglar.
// CONSTRUCTOR: KURUCU METHOD - YSPICI METHOD
// Gorevi: bir classtan nesne turetilirken calisir ve class icindeki fieldlara varsayilan deger atamalarini yapar.
// her classda mutlaka vardir. VArsayilan olarak parametre almazlar. Bu constructorlara default constructor denir.
// Isimleri class adi ile aynidir. farkli isimle tanimlanmazlar, geri donus tipleri yoktur.
// Classlardan nesne turetildiginde calisan ilk metoddur. 
// ctor code snippeti ile default constructor olusturulabilir. ctor + tab
// Bir class icinde static olarak tanimlanan uyelere, class ismi ile erisilir ve bu uyeler program calistigi surece bellekte tutulurlar. Nesnelerden bagimsiz, class'a ait yapilar. 
// kapsulleme (Encapsulation) ilkesi: class icerisinde yapilan islerin, class disindan gizlenmesidir. Orn: odaSayisi field'ina deger atama islemi yapmak icin oncelikle field private yapildi, sonrasinda bu fielda erisebilen public SetOdaSayisi(int odaSayisi) metodu yazildi. bu method icinde gelen degerin mutlak degeri alinarak odasayisi fieldina aktarildi ve bu islemden metodu kullananlarin bilgisi olmadi.