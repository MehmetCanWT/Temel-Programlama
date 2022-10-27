import java.util.Scanner;

/*import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        int yaricap;
        double daireninalani;
        Scanner a = new Scanner(System.in);
        System.out.println("Dairenin Yarıçapını Giriniz");
        yaricap = a.nextInt();
        daireninalani = Math.PI * yaricap * yaricap;
        System.out.println("Dairenin Alanı: " + daireninalani);
    }
}
*/

/*
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        int kareninkenari;
        double kareninalanı;
        Scanner a = new Scanner(System.in);
        System.out.println("Karenin Kenarını Giriniz");
        kareninkenari = a.nextInt();
        kareninalanı = kareninkenari * kareninkenari;
        System.out.println("Karenin Alanı: " + kareninalanı);
    }
}
*/

/* 
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner a = new Scanner(System.in);
        int uzunkenar, kisakenar;
        double dikdörtgeninalanı;
        System.out.println("Uzun Kenarı Giriniz");
        uzunkenar = a.nextInt();
        System.out.println("Kısa Kenarı Giriniz");
        kisakenar = a.nextInt();
        dikdörtgeninalanı = uzunkenar * kisakenar;
        System.out.println("Dikdörtgenin Alanı = " + dikdörtgeninalanı);
    }
}

*/

/*
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        int kareninkenari;
        double kareninçevresi;
        Scanner a = new Scanner(System.in);
        System.out.println("Karenin Kenarını Giriniz");
        kareninkenari = a.nextInt();
        kareninçevresi = kareninkenari * 4;
        System.out.println("Karenin Kenarı = " + kareninçevresi);
    }
}
*/

/* 
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner a = new Scanner(System.in);
        int uzunkenar, kisakenar;
        double dikdörtgeniçevresi;
        System.out.println("Uzun Kenarı Giriniz");
        uzunkenar = a.nextInt();
        System.out.println("Kısa Kenarı Giriniz");
        kisakenar = a.nextInt();
        dikdörtgeniçevresi = kisakenar * 2 + uzunkenar * 2;
        System.out.println("Dikdörtgenin Çevresi = " + dikdörtgeniçevresi);
    }

}

*/

/* 
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
    int yaricap;
    double cembericevresi;
    Scanner a = new Scanner(System.in);
    System.out.println("Çemberin Yariçapını Giriniz: ");
    yaricap = a.nextInt();
    cembericevresi = Math.PI * yaricap * 2;
    System.out.println("Çemberin çevresi: " + cembericevresi);
   
    }
}
*/

/* 
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
    int kubunkenarı ;
    double kubunhacmi;
    Scanner a = new Scanner(System.in);
    System.out.println("Kübün Kenarıni Giriniz: ");
    kubunkenarı = a.nextInt();
    kubunhacmi = kubunkenarı * kubunkenarı * kubunkenarı ;
    System.out.println("Kübün Hacmi: " + kubunhacmi);
   
    }
}
*/

/*
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
    int c;
    int d;
    double alan;
    Scanner a = new Scanner(System.in);
    Scanner b1 = new Scanner(System.in);
    System.out.println("1.Açıyı Giriniz:\n");
    System.out.println("2.Açıyı Giriniz:\n");
    c = a.nextInt();
    d = b1.nextInt();
    alan = 180 - (d+c);
    System.out.println("3.Açının Değeri:"+alan);
   
    }
}

 */

 /*
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
    int c;
    int d;
    double alan;
    Scanner a = new Scanner(System.in);
    Scanner b1 = new Scanner(System.in);
    System.out.println("1.Açıyı Giriniz:\n");
    System.out.println("2.Açıyı Giriniz:\n");
    c = a.nextInt();
    d = b1.nextInt();
    alan = 180 - (d+c);
    System.out.println("3.Açının Değeri:"+alan);
   
    }
}

 */

 /* 
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
    int c;
    int d;
    double alan;
    Scanner a = new Scanner(System.in);
    Scanner b1 = new Scanner(System.in);
    System.out.println("Kilonuzu Giriniz:\n");
    System.out.println("Boyunuz:\n");
    c = a.nextInt();
    d = b1.nextInt();
    alan = c/(d *0.01*d *0.01);
    System.out.println("Vücut Kitle İndeksi: "+alan);
   
    }
}

*/

/*
public class App {
    public static void main(String[] args) throws Exception {
    int uzunkenar, kisakenar, yükseklik, prizmahacmi;
    Scanner a = new Scanner(System.in);
    System.out.println("Dikdörtgen Prizmasının Uzun Kenarını Giriniz");
    uzunkenar = a.nextInt();
    System.out.println("Dikdörtgenin Kısa Kenarını Giriniz");
    kisakenar = a.nextInt();
    System.out.println("Dikdörtgen Prizmanın Yükseliğini Giriniz");
    yükseklik = a.nextInt();
    prizmahacmi = kisakenar * uzunkenar * yükseklik;
    System.out.println("Prizmanın Hacmi = " + prizmahacmi);  
    }
}
*/


/* 
public class App {
    public static void main(String[] args) throws Exception {
    int kdvsizfiyat, kdvlifiyat;
    Scanner a = new Scanner(System.in);
    System.out.println("Kdv'siz Fiyatı Giriniz");
    kdvsizfiyat = a.nextInt();
    kdvlifiyat = kdvsizfiyat * 18/100 + kdvsizfiyat;
    System.out.println("Kdv'li Fiyat: " + kdvlifiyat);

    }
}
*/

/* 
public class App {
    public static void main(String[] args) throws Exception {
    int fiyat;
    double indirim, indirimlifiyat;
    Scanner a = new Scanner(System.in);
    System.out.println("Fiyatı Giriniz: ");
    fiyat = a.nextInt();
    indirim = fiyat * 0.1;
    indirimlifiyat = fiyat - indirim;
    System.out.println("İndirimli Fiyat: " + indirimlifiyat);

    
    }
}
*/

/* */
public class App {
    public static void main(String[] args) throws Exception {
    Scanner a = new Scanner(System.in);
    int sayi1, sayi2, sayisec;
    System.out.println("İlk Sayıyı Giriniz: ");
    sayi1 = a.nextInt();
    System.out.println("İkinci Sayıyı Giriniz: ");
    sayi2 = a.nextInt();
    System.out.println("\n Yapmak İstediğiniz İşlemi Seçiniz");
    System.out.println("1-Toplama \n2-Çıkarma \n3-Çarpma \n4-Bölme");
    System.out.println("Seçiminiz: ");
    sayisec = a.nextInt();
    if (sayisec == 1)
    {
        System.out.println("Toplam: " + (sayi1 + sayi2));
    }else if (sayisec == 2)
    {
        System.out.println("Çıkarma: " + (sayi1 - sayi2));
    }else if (sayisec == 3)
    {
        System.out.println("Çarpma: " + (sayi1 * sayi2));
    }else if (sayisec == 4)
    {
        if(sayi2 == 0)
        {
            System.out.println("Tanımsız");
        }
        else{
        System.out.println("Bölme: " + (sayi1 / sayi2));
    }
    }
   
    }
}