using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string türü değişken gibi kullanılsa da aslında dizidir.

            //int[] sayilar = { 3, 5, 12, -45, 7 };
            //sayilar[1] = 123;
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine("Eleman sayısı = " + sayilar.Length);

            //string isim = "Samet Kapar";
            ////isim[4] = "c";
            //isim += " Mühendis Bey";
            //Console.WriteLine("Karakter sayısı = " + isim.Length);
            //Console.WriteLine(isim[3]);
            //Console.WriteLine(isim);


            #endregion

            #region Konsoldan alınan yazı kaç karaterlidir.

            //Console.WriteLine("Lütfen adınızı giriniz: ");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Adınız = "+ isim.Length + " karakterlidir");

            #endregion

            #region Konsoldan alınan yazının baındaki boşlukları silme

            // Console.Beep(1000, 100);

            //Console.WriteLine("Lütfen yazı giriniz : ");
            //string metin = Console.ReadLine();

            //string bosluksuz = "";
            //int baslangic = 0; 
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] != ' ')
            //    {
            //        baslangic = i;
            //        break;
            //    }

            //}
            //for (int i = baslangic; i < metin.Length; i++)
            //{
            //    bosluksuz += metin[i];
            //}
            //Console.WriteLine(bosluksuz);
            #endregion

            #region Karakter Index'i Bulma

            ////Yazı alınacak
            ////aranan karakter alınacak
            ////aranan karakter hangi indexlerde
            //Console.WriteLine("Lütfen bir yazı giriniz: ");
            //string yazi = Console.ReadLine();
            //Console.WriteLine("aranacak karakteri giriniz: ");
            //char karakter = Convert.ToChar(Console.ReadLine());

            //for (int i = 0; i < yazi.Length; i++)
            //{
            //    if (yazi[i] == karakter)
            //    {
            //        Console.WriteLine(i + ". indexte");
            //    }
            //}
            #endregion

            #region Konsoldan alınan  karakter büyük mü küçük mü?

            //65 - 90 Büyük karakterler
            //97 - 122 Küçük karakterler

            //Console.WriteLine("Biri karakter giriniz: ");
            //char karakter = Convert.ToChar(Console.ReadLine());
            //int sayisal = (int)karakter;

            //if (sayisal >= 65 && sayisal <= 90)
            //{
            //    Console.WriteLine("Karakter Büyük");
            //}
            //else if (sayisal >= 97 && sayisal <= 122)
            //{
            //    Console.WriteLine("Karakter Küçük");
            //}
            //else
            //{
            //    Console.WriteLine("Sembol Girdiniz");
            //}

            #endregion

            #region Konsoldan alınan karakter büyük ise küçük küçük ise büyük halini yazdırınız.

            //Console.WriteLine("Biri karakter giriniz: ");
            //char karakter = Convert.ToChar(Console.ReadLine());
            //int sayisal = (int)karakter;

            //if (sayisal >= 65 && sayisal <= 90)
            //{
            //    sayisal += 32;
            //    Console.WriteLine((char)sayisal);
            //}
            //else if (sayisal >= 97 && sayisal <= 122)
            //{
            //    sayisal -= 32;
            //    Console.WriteLine((char)sayisal);
            //}
            //else
            //{
            //    Console.WriteLine("Sembol Girdiniz");
            //}

            #endregion

            #region metin içindeki tüm küçük karakterli büyütün

            //// Samet Kapar
            //Console.WriteLine("Metin Giriniz");
            //string metin = Console.ReadLine();
            //string buyuk = "";
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    int sayisal = (int)metin[i];
            //    if (sayisal >= 97 && sayisal <= 122)
            //    {
            //        int buyuksayisal = sayisal - 32;
            //        buyuk += (char)buyuksayisal;
            //    }
            //    else
            //    {
            //        buyuk += metin[i];
            //    }
            //} 


            #endregion

            #region büyükleri küçültün

            //Console.WriteLine("Metin Giriniz");
            //string metin = Console.ReadLine();
            //string kucuk = "";
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    int sayisal = (int)metin[i];
            //    if (sayisal >= 65 && sayisal <= 90)
            //    {
            //        int kucuksayisal = sayisal + 32;
            //        kucuk += (char)kucuksayisal;
            //    }
            //    else
            //    {
            //        kucuk += metin[i];
            //    }
            //}
            //Console.WriteLine(kucuk);
            #endregion

            #region ilk karakter index'i bulma

            //Console.WriteLine("Bir Metin giriniz");
            //string metin = Console.ReadLine();
            //Console.WriteLine("Aranacak karakteri giriniz");
            //char aranacak = Convert.ToChar(Console.ReadLine());

            //int index = -1;
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] == aranacak)
            //    {
            //        index = i;
            //        Console.WriteLine(i + ". indexte");
            //        break;
            //    }
            //}
            //if (index == -1)
            //{
            //    Console.WriteLine("Karakter Bulunamadı");
            //}
            #endregion

            #region metin içinde metin bulma

            //alp sasarikisla
            //sar
            //Console.WriteLine("Metin giriniz: ");
            //string metin = Console.ReadLine();
            //Console.WriteLine("Aranacak giriniz: ");
            //string aranacak = Console.ReadLine();

            //for (int i = 0; i < metin.Length; i++) 
            //{
            //    bool buldukmu = true;
            //    for (int j = 0; j < aranacak.Length; j++)
            //    {
            //        if (metin[i+j] != aranacak[j])
            //        {
            //            buldukmu = false;
            //            break;
            //        }
            //    }
            //    if(buldukmu == true)
            //    {
            //        Console.WriteLine("aranacak"+ i + " indexte başlıyor");
            //        break;
            //    }
            //}


            #endregion

            #region Konsoldan alınan cümle polindron mudur?(terstende düzdende okunuş)

            #endregion

            #region 1234-binikiyüzotuzdört olarak yaz

            #endregion


        }
    }
}
