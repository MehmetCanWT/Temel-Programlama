using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Login 1 Equals
 
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string kullanici_adi, sifre;
                Console.WriteLine("Kullanıcı Adı Giriniz: ");
                kullanici_adi = Console.ReadLine();
                Console.WriteLine("Şifre Giriniz: ");
                sifre = Console.ReadLine();
                if (kullanici_adi.Equals("Mehmet") && sifre.Equals("1597"))
                {
                    Console.WriteLine("Giriş Başarılı");

                }
                else
                {
                    Console.WriteLine("Hatalı Kullanıcı adı Şifre");
                }

                Console.ReadLine();



        }
    }
}

*/

/* Login 2 == 
 

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kullanici_adi, sifre;
            Console.WriteLine("Kullanıcı Adı Giriniz: ");
            kullanici_adi = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz: ");
            sifre = Console.ReadLine();
            if (kullanici_adi == ("Mehmet") && sifre == ("1597"))
            {
                Console.WriteLine("Giriş Başarılı");

            }
            else
            {
                Console.WriteLine("Hatalı Kullanıcı adı Şifre");
            }

            Console.ReadLine();



        }
    }
}

*/

/* Login 3 Kullanıcı Adı Veya Şifre Yanlış
 
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kullanici_adi, sifre;
            Console.WriteLine("Kullanıcı Adı Giriniz: ");
            kullanici_adi = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz: ");
            sifre = Console.ReadLine();
            if (kullanici_adi == ("Mehmet") == false && sifre == ("1597") == false)
            {
                Console.WriteLine("Kullanıcı Adı Ve Şifre Hatalı");

            }
            if (kullanici_adi == ("Mehmet") == false && sifre == ("1597") == true)
            {

                Console.WriteLine("Kullanıcı Adı Veya Şifreniz'den Biri Doğrudur");

            }
            if (kullanici_adi == ("Mehmet") == true && sifre == ("1597") == false)
            {

                Console.WriteLine("Kullanıcı Adı Veya Şifreniz'den Biri Doğrudur");

            }
            if (kullanici_adi == ("Mehmet") == true && sifre == ("1597") == true)
            {
                Console.WriteLine("Kullanıcı Adı Şifre Doğru");
            }

            Console.ReadLine();



        }
    }
}
*/

/* Ohm'dan Kilo Ohm
 
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi, donusum;
            Console.WriteLine("Ohm Değeri Giriniz");
            sayi = Convert.ToDouble(Console.ReadLine());
            donusum = sayi / 1000;
            Console.WriteLine(sayi.ToString() + " Ohm = " + donusum.ToString() + "Kilo Ohm");
            Console.ReadLine();



        }
    }
}
*/

/* Megawatt'tan Kilowatt
 
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            double donusum;
            Console.WriteLine("Megawatt Değeri Giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            donusum = sayi * 1000;
            Console.WriteLine(sayi.ToString() + " Megawatt = " +  donusum.ToString() + " Kilowatt");
            Console.ReadLine();


        }
    }
}
*/

/* Elektronik Kapılar
 
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Hangi kapının doğruluk tablosunu görmek istersiniz " +
                "\n1-Ve Kapısı" +
                "\n2-Veya Kapısı" +
                "\n3-Değil Kapısı" +
                "\n4-Ve Değil Kapısı" +
                "\n5-Veya Değil Kapısı" +
                "\n6-Özel Veya Kapısı" +
                "\n7-Özel Veya Değil Kapısı\n");
            sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Ve Kapısı\nA B F\n0 0 0 \n0 1 0\n1 0 0\n1 1 1\n");
                break;

            
                case 2:
                    Console.WriteLine("Veya Kapısı\nA B F\n0 0 0\n0 1 1\n1 0 1\n1 1 1\n");
                break;
            
            
                case 3:
                    Console.WriteLine("Değil Kapısı\nA F\n0 1\n1 0\n");
                break;
            
            
                case 4:
                    Console.WriteLine("Ve Değil Kapısı\nA B F\n0 0 1\n0 1 1\n1 0 1\n1 1 0\n");
                break;
            
            
                case 5:
                    Console.WriteLine("Veya Değil Kapısı\nA B F\n0 0 1\n0 1 0\n1 0 0\n1 1 0\n");
                break;
            
            
                case 6:
                    Console.WriteLine("Özel Veya Kapısı\nA B F\n0 0 0\n0 1 1\n1 0 1\n1 1 0\n");
                break;
            
            
                case 7:
                    Console.WriteLine("Özel Veya Değil Kapısı\nA B F\n0 0 1\n0 1 0\n1 0 0\n1 1 1\n");
                break;

                default:
                    Console.WriteLine("Yanlış Sayı Girdiniz");
                    break;
            }

            Console.ReadLine();

        }
    }
}
*/

/* Büyükten Küçüğe Sıralama
  
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("a Sayısını Giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b Sayısını Giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c Sayısını Giriniz: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("a > b > c");
                }
                else
                {
                    Console.WriteLine("a > c > b");
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("b > a > c");
                }
                else
                {
                    Console.WriteLine("b > c > a");
                }
            }

            else

            {
                if (a > b)
                {
                    Console.WriteLine("c > a > b");
                }

                else
                {
                    Console.WriteLine("c > b > a");

                }


            }
            Console.ReadLine();

        }

    }

}
*/

/* Sayının Faktöriyel alma
 
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, faktoriyel = 1 ;
            Console.WriteLine("Faktöriyel Alınacak Sayıyı Giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(sayi.ToString() + "! = " + faktoriyel.ToString());
            Console.ReadLine();

        }

    }

}
*/

/* 1'den Girilen Sayıya Kadar Olan Sayıları Toplama
 
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, toplam= 0;
            Console.WriteLine("Bir Sayı Giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }
            Console.WriteLine("1'den Girilen Sayıya Kadar Olan Sayıların Toplamı= " + toplam.ToString());
            Console.ReadLine();

        }

    }

}
*/

/* 1'den Girilen Sayıya Kadar Olan Tek Sayıları Toplama
 
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, toplam = 0;
            Console.WriteLine("Bir Sayı Giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 != 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("1'den Girilen Sayıya Kadar Olan Tek Sayıların Toplamı = " + toplam.ToString());
            Console.ReadLine();

        }

    }

}
*/
 
/* 1'den Girilen Sayıya Kadar Olan Çift Sayıları Toplama
 
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, toplam = 0;
            Console.WriteLine("Bir Sayı Giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("1'den Girilen Sayıya Kadar Olan Çift Sayıların Toplamı = " + toplam.ToString());
            Console.ReadLine();

        }

    }

}
*/

/* 
 
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç Sayı Girmek İstersiniz");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arka Arkaya Girmek İstediğiniz Kadar Sayı Giriniz");
            int maks = 0;
            for (int i = 1; i<= a; i++)
            {
                Console.WriteLine(i + ". Sayıyı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    maks = sayi;
                }
                if (sayi > maks)
                    maks = sayi;

            }
            Console.WriteLine("Girdiğiniz Sayılar İçinden En Büyük Olan :" + maks.ToString());
            Console.ReadLine();


        }

    }

}
*/

/*
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç Sayı Girmek İstersiniz");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arka Arkaya Girmek İstediğiniz Kadar Sayı Giriniz");
            int min = 0;
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i + ". Sayıyı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    min = sayi;
                }
                if (sayi < min)
                    min = sayi;

            }
            Console.WriteLine("Girdiğiniz Sayılar İçinden En Küçük Olan :" + min.ToString());
            Console.ReadLine();


        }

    }

}
*/

/*
namespace Program
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                for (int j = 1; j <= 10; j++)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write(i.ToString() + "*" + j.ToString() + "=" + (i * j).ToString() + "  ");

                    }
                    Console.WriteLine();

                }
                Console.ReadLine();



            }

        }
 }
*/

/*
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            double uzaklik;
            Console.WriteLine("X ve Y Koordinatlarını Verdiğiniz iki Noktanın Arasindaki Uzaklık Hesaplanacaktır. \nDeğerleri Giriniz");
            Console.Write("1.Nokta X Değeri = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("1.Nokta Y Değeri Giriniz = ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Nokta X Değeri = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Nokta Y Değeri Giriniz = ");
            y2 = Convert.ToInt32(Console.ReadLine());
            uzaklik = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));
            Console.WriteLine("2 Nokta Arasındaki Uzaklık = " + uzaklik.ToString());
            Console.ReadLine();

        }

    }
}
*/

/*
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0, r = 0;
            double uzaklik;
            Console.WriteLine("X ve Y Koordinatlarını Verdiğiniz iki Noktanın Arasindaki Uzaklık Hesaplanacaktır. \nDeğerleri Giriniz");
            Console.Write("Daire Merkezinin X Değeri = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Daire Merkezinin Y Değeri Giriniz = ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dairenin Yarıçapını Giriniz = ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Noktanın X Değerini Giriniz = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Noktanın Y Değerini Giriniz = ");
            y2 = Convert.ToInt32(Console.ReadLine());
            uzaklik = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));
            if (uzaklik < r)
            {
                Console.WriteLine("Nokta Dairenin İçindedir");
            }
            if (uzaklik > r)
            {
                Console.WriteLine("Nokta Dairenin Dışındadır");
            }
            Console.ReadLine();

        }

    }
}
*/

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aci;
            double sindegeri, cosdegeri;
            Console.WriteLine("Açı Değerini Giriniz(Derece Cinsinden): ");
            aci = Convert.ToInt32(Console.ReadLine());
            sindegeri = Math.Sin(aci * (Math.PI / 180));
            cosdegeri = Math.Cos(aci * (Math.PI / 180));
            Console.WriteLine("Sin(" + aci.ToString() + ") = " + sindegeri.ToString());
            Console.WriteLine("Cos(" + aci.ToString() + ") = " + cosdegeri.ToString());
            Console.ReadLine();
        }

    }
}