using System;
using System.Collections.Generic;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı ve soyadınızı giriniz: ");
            string adSoyad = Console.ReadLine();            
            Console.Write("Kaç kere alışveriş yapacaksınız(sayı ile giriniz): ");          
            int islem = Convert.ToInt32(Console.ReadLine());
            if (islem < 5)
            {                
                Console.WriteLine("Sanal kartınızdan en az 5 işlem yapabilirsiniz!!");                
                Console.Write("Kaç kere alışveriş yapacaksınız(sayı ile giriniz): ");
                islem = Convert.ToInt32(Console.ReadLine());                
                if (islem >=5)
                {
                    Console.WriteLine("Ulaşımı seçiyorsanız 1'e tıklayın.");
                    Console.WriteLine("Eğlenceyi seçiyorsanız 2'ye tıklayın.");
                    Console.WriteLine("Yemeği seçiyorsanız 3'e tıklayın.");
                    Console.WriteLine("Giyimi seçiyorsanız 4'e tıklayın.");
                    Console.WriteLine("Diğer yapılacak harcamalar için 5'e tıklayın.");
                    Console.Write("Lütfen karttan yapmak istediğiniz işlemi yukarıda size sunulan seçeneklere göre seçiniz: ");
                    int secim = Convert.ToInt32(Console.ReadLine());                    
                    AnaKart anaK = new AnaKart();
                    anaK.bilgiler();                    
                    UlasimKarti ulasK = new UlasimKarti();
                    EglenceKarti eglenK = new EglenceKarti();
                    YemekKarti ymkK = new YemekKarti();
                    GiyimKarti gymK = new GiyimKarti();
                    DigerIslemler dIslem = new DigerIslemler();
                    if (secim == 1)
                    {
                        for (int i = 1; i <= islem; i++)
                        {
                            ulasK.bilgiler();
                        }
                        ulasK.bilgiGoster();
                    }
                    if (secim == 2)
                    {                        
                        for (int k = 1; k <= islem; k++)
                        {
                            eglenK.bilgiler();
                        }
                        eglenK.bilgiGoster();
                    }
                    if (secim == 3)
                    {
                        for (int j = 1; j <= islem; j++)
                        {
                            ymkK.bilgiler();
                        }
                        ymkK.bilgiGoster();
                    }
                    if (secim == 4)
                    {
                        for (int m = 1; m <= islem; m++)
                        {
                            gymK.bilgiler();
                        }
                        gymK.bilgiGoster();
                    }
                    if (secim == 5)
                    {
                        for (int i = 1; i <= islem; i++)
                        {
                            dIslem.bilgiler();
                        }
                        dIslem.bilgiGoster();
                    }
                }
            }
            else
            {                
                Console.WriteLine("Ulaşımı seçiyorsanız 1'e tıklayın.");
                Console.WriteLine("Eğlenceyi seçiyorsanız 2'ye tıklayın.");
                Console.WriteLine("Yemeği seçiyorsanız 3'e tıklayın.");
                Console.WriteLine("Giyimi seçiyorsanız 4'e tıklayın.");
                Console.WriteLine("Diğer yapılacak harcamalar için 5'e tıklayın.");
                Console.Write("Lütfen karttan yapmak istediğiniz işlemi yukarıda size sunulan seçeneklere göre seçiniz:  ");
                int secim = Convert.ToInt32(Console.ReadLine());                
                AnaKart anaK = new AnaKart();
                anaK.bilgiler();
                UlasimKarti ulasK = new UlasimKarti();
                EglenceKarti eglenK = new EglenceKarti();
                YemekKarti ymkK = new YemekKarti();
                GiyimKarti gymK = new GiyimKarti();
                DigerIslemler dIslem = new DigerIslemler();
                if (secim == 1)
                {
                    for (int i = 1; i <= islem; i++)
                    {
                        ulasK.bilgiler();
                    }
                    ulasK.bilgiGoster();
                }
                if (secim == 2)
                {
                    for (int i = 1; i <= islem; i++)
                    {
                        eglenK.bilgiler();
                    }
                    eglenK.bilgiGoster();
                }
                if (secim == 3)
                {
                    for (int j = 1; j <= islem; j++)
                    {
                        ymkK.bilgiler();
                    }
                    ymkK.bilgiGoster();
                }
                if (secim == 4)
                {
                    for (int i = 1; i <= islem; i++)
                    {
                        gymK.bilgiler();
                    }
                    gymK.bilgiGoster();
                }
                if (secim == 5)
                {
                    for (int i = 1; i <= islem; i++)
                    {
                        dIslem.bilgiler();
                    }
                    dIslem.bilgiGoster();
                }
            }
        }
    }
    public class AnaKart
    {
        public string ulasim;
        public string eglence;
        public string yemek;
        public string giyim;
        public string adSoyad;
        public int secim;
        public int islem;
        public int yenIslem;
        public int kalan;
        public int harcama;
        public int Limits = 3500;
        public int anaKartLimit = 20000;
        public int toplamKalan;   
        public int totalHarcama;
        public void bilgiGoster()
        {
            Console.WriteLine("AŞAĞIDA HESAP HAREKETLERİNİZ GÖSTERİLECEKTİR");
            Console.WriteLine("Sayın " + adSoyad + " kart ana limitiniz: 20000 TL'dir. Alt sanal kartlarınızın limiti 3500 TL olarak tanımlanmıştır." +
                                " bu kartınızın bir aylık ekstresi gösterilecektir: " + this.totalHarcama + " bu kartınızda kalan bakiyeniz: " + this.Limits +
                                " ana kartınızda kalan toplam bakiyeniz: " + toplamKalan + " ve kartınızla yaptığınz alışveriş sayınız 5 den büyüktür.");
        }
        public virtual void bilgiler()
        {
        }
    }
    public class UlasimKarti : AnaKart
    {
        public override void bilgiler()
        {
            if (anaKartLimit>0)
            {
                Console.Write("Harcama yaptığınız tutarı giriniz: ");
                int harcama = Convert.ToInt32(Console.ReadLine());
                if (harcama < 800)
                {
                    Limits = Limits - harcama;
                    Console.WriteLine("Kalan limitiniz: " + Limits);
                    toplamKalan = anaKartLimit - harcama;
                    Console.WriteLine("Kart toplam kalan: " + toplamKalan);
                    this.totalHarcama += harcama;
                    this.Limits = 3500 - totalHarcama;
                }
                else if (harcama > 800 && harcama <= 3500)
                {
                    if (anaKartLimit != 0)
                    {
                        Console.WriteLine("800 TL aşımı gerçekleştiği için anakart kontrol edildi ve bakiyeniz olduğu için çekim sağlandı.");
                        Limits -= harcama;
                        Console.WriteLine("Kalan limitiniz: " + Limits);
                        toplamKalan = anaKartLimit - harcama;
                        Console.WriteLine("Kart toplam kalan: " + toplamKalan);
                        this.totalHarcama += harcama;
                        this.Limits = 3500 - totalHarcama;
                    }
                }
                else
                {
                    int fark1 = harcama - 3500;
                    Limits -= 3500;
                    anaKartLimit -= fark1;
                    Console.WriteLine("Kalan limitiniz: " + (anaKartLimit - harcama));
                    this.totalHarcama += harcama;
                    this.Limits = 3500 - totalHarcama;
                }
            }
            else
            {
                Console.WriteLine("ANA KART BAKİYENİZ YETERSİZ OLDUĞU İÇİN İŞLEMLERİNİZ GERÇEKLEŞTİRİLEMEMİŞTİR.");
            }                       
        }
    }
    public class EglenceKarti : AnaKart
    {        
        public override void bilgiler()
        {
            if (anaKartLimit>0)
            {
                Console.WriteLine("Harcama yaptığınız tutarı giriniz: ");
                int harcama = Convert.ToInt32(Console.ReadLine());
                if (harcama < 800)
                {
                    Limits -= harcama;
                    Console.WriteLine("Kalan limitiniz: " + Limits);
                    toplamKalan = anaKartLimit - harcama;
                    Console.WriteLine("Kart toplam kalan: " + toplamKalan);
                    this.totalHarcama += harcama;
                    this.Limits = 3500 - totalHarcama;
                }
                else if (harcama > 800 && harcama <= 3500)
                {
                    if (anaKartLimit != 0)
                    {
                        Console.WriteLine("800 TL aşımı gerçekleştiği için anakart kontrol edildi ve bakiyeniz olduğu için çekim sağlandı.");
                        Limits -= harcama;
                        Console.WriteLine("Kalan limitiniz: " + Limits);
                        toplamKalan = anaKartLimit - harcama;
                        Console.WriteLine("Kart toplam kalan: " + toplamKalan);
                        this.totalHarcama += harcama;
                        this.Limits = 3500 - totalHarcama;
                    }
                }
                else
                {
                    int fark2 = harcama - 3500;
                    Limits -= 3500;
                    anaKartLimit -= fark2; ;
                    Console.WriteLine("Kalan limitiniz: " + (anaKartLimit - harcama));
                    this.totalHarcama += harcama;
                    this.Limits = 3500 - totalHarcama;
                }
            }
            else
            {
                Console.WriteLine("ANA KART BAKİYENİZ YETERSİZ OLDUĞU İÇİN İŞLEMLERİNİZ GERÇEKLEŞTİRİLEMEMİŞTİR.");
            }
        }
    }
    public class YemekKarti : AnaKart
    {
        public override void bilgiler()
        {
            if (anaKartLimit>0)
            {
                Console.WriteLine("Harcama yaptığınız tutarı giriniz: ");
                int harcama = Convert.ToInt32(Console.ReadLine());
                if (harcama < 800)
                {
                    Limits -= harcama;
                    Console.WriteLine("Kalan limitiniz: " + Limits);
                    toplamKalan = anaKartLimit - harcama;
                    Console.WriteLine("Kart toplam kalan: " + toplamKalan);
                    this.totalHarcama += harcama;
                    this.Limits = 3500 - totalHarcama;
                }
                else if (harcama > 800 && harcama <= 3500)
                {
                    if (anaKartLimit != 0)
                    {
                        Console.WriteLine("800 TL aşımı gerçekleştiği için anakart kontrol edildi ve bakiyeniz olduğu için çekim sağlandı.");
                        Limits -= harcama;
                        Console.WriteLine("Kalan limitiniz: " + Limits);
                        toplamKalan = anaKartLimit - harcama;
                        Console.WriteLine("Kart toplam kalan: " + toplamKalan);
                        this.totalHarcama += harcama;
                        this.Limits = 3500 - totalHarcama;
                    }
                }
                else
                {
                    int fark3 = harcama - 3500;
                    Limits -= 3500;
                    anaKartLimit -= fark3; ;
                    Console.WriteLine("Kalan limitiniz: " + (anaKartLimit - harcama));
                    this.totalHarcama += harcama;
                    this.Limits = 3500 - totalHarcama;
                }
            }
            else
            {
                Console.WriteLine("ANA KART BAKİYENİZ YETERSİZ OLDUĞU İÇİN İŞLEMLERİNİZ GERÇEKLEŞTİRİLEMEMİŞTİR.");
            }
        }
    }
    public class GiyimKarti : AnaKart
    {        
        public override void bilgiler()
        {
            if (anaKartLimit>0)
            {
                Console.WriteLine("Harcama yaptığınız tutarı giriniz: ");
                int harcama = Convert.ToInt32(Console.ReadLine());
                if (harcama < 800)
                {
                    Limits -= harcama;
                    Console.WriteLine("Kalan limitiniz: " + Limits);
                    toplamKalan = anaKartLimit - harcama;
                    Console.WriteLine("Kart toplam kalan: " + toplamKalan);
                    this.totalHarcama += harcama;
                    this.Limits = 3500 - totalHarcama;
                }
                else if (harcama > 800 && harcama <= 3500)
                {
                    if (anaKartLimit != 0)
                    {
                        Console.WriteLine("800 TL aşımı gerçekleştiği için anakart kontrol edildi ve bakiyeniz olduğu için çekim sağlandı.");
                        Limits -= harcama;
                        Console.WriteLine("Kalan limitiniz: " + Limits);
                        toplamKalan = anaKartLimit - harcama;
                        Console.WriteLine("Kart toplam kalan: " + toplamKalan);
                        this.totalHarcama += harcama;
                        this.Limits = 3500 - totalHarcama;
                    }
                }
                else
                {
                    int fark4 = harcama - 3500;
                    Limits -= 3500;
                    anaKartLimit -= fark4; ;
                    Console.WriteLine("Kalan limitiniz: " + (anaKartLimit - harcama));
                    this.totalHarcama += harcama;
                    this.Limits = 3500 - totalHarcama;
                }
            }
            else
            {
                Console.WriteLine("ANA KART BAKİYENİZ YETERSİZ OLDUĞU İÇİN İŞLEMLERİNİZ GERÇEKLEŞTİRİLEMEMİŞTİR.");
            }
        }
    }
    public class DigerIslemler : AnaKart
    {
        public override void bilgiler()
        {
            Console.WriteLine("Yapacağınız harcama türü diğer harcamalardır ve ana kart bakiyesinden kesinti olacaktır.");            
            Console.WriteLine("Harcama yaptığınız tutarı giriniz: ");            
            int harcama = Convert.ToInt32(Console.ReadLine());
            if (anaKartLimit !=0)
            {
                anaKartLimit -= harcama;
                toplamKalan = anaKartLimit - harcama;
                Console.WriteLine("Kart toplam kalan: " + toplamKalan);                
                this.totalHarcama += harcama;
                this.Limits = anaKartLimit - totalHarcama;
            }
        }
    }
}
