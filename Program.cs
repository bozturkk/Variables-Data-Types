using System;

namespace Degiskenler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger;
            deger = 5;
            //değişken adları rakamla başlamaz.
            // int 3degisken; gibi bir şey yapamayız yani
            //değişken adları keys sensitive dir.
            string degerler = null;
            String Degisken = null; // keys sensitive olduğu için bu iki değişkeni farklı değişkenler olarak görür.
            //class vs gibi özel isimler verilememektedir.
            // string class; dediğimde hata verecektir.
            //Aynı kod bloğu içerisinde bir değişken birden fazla tanımlanamaz.
            //string a;
            //string a; ikinci oluşturulan değerin altını kırmızı olarak çizecektir zaten.
            //farklı bir kod blogunda ise böyle bir problem yaşanmayacaktır.
            //işlem operatörü içermemelidir.
            // int v+x = 5; gibi bir şey yapamayız. - yi eksi operatörü gördüğü için 
            //eksi de kullanılmamalıdır. ama _kullanılabilir.
            //boşlukta(space) kullanılamaz.

            //*****Değişken tiplerine bakalım.
            string metinselIfade = " "; //buradaki değişken boş değildir içerisinde white space bulunur.
            //white space ler hataya neden olabilecek noktalardır.
            // eğer tanımladığım string ifadenin null olmasını istiyorsam;
            string metinselIfade1 = null; // bu şekilde tanımlamak makbul olandır :)
            byte bit = 5; //değeri 5 olan bir byte, bellekte byte tipindeki değerler 1 byte yer kaplar. 0 255 arası değer alır.
            sbyte sBit = 5; //bu da 1 byte yer kaplar.  -128 127 arasında değer alır
            short sayisalIfade = 10; // bellekte 2 byte yer kaplar. -32 768 , +32 768 tam sayı değerler
            ushort sayisalIfade1 = 10; // bellekte 2 byte yer kaplar. 0 65 365 arası değerler. 
            Int16 sayisalIfade2 = 2; //bellekte 2 byte yer kaplar. 
            int sayisalIfade3 = 2; // bellekte 4 byte yer kaplar.
            Int32 sayisalIfade4 = 4; //5 byte yer kaplar.
            Int64 sayisalIfade5 = 5; //bellekte 8 byte yer kaplar.
            uint sayisalIfade6 = 4; // bellekte 4 byte yer kaplar
            long sayisalIfade7 = 4; // bellekte 8 byte yer kaplar.
            ulong sayisalIfade8 = 4; // bellekte 8 byte yer kaplar.
            float sayisalIfade9 = 4; // bellekte 4 byte yer kaplar.
            double sayisalIfade10 = 4; // bellekte 8 byte yer kaplar.
            decimal sayisalIfade11 = 4; // bellekte 16 byte yer kaplar.

            char karakter ='a'; //string bir char arraydir. 2 byte yer kaplar. String sınırsızdır.
            bool b1 = true; //boolean
            DateTime dt = DateTime.Now; //çalışan anın tarih ve saat karşılığını verir. ay/gün/yıl
            Console.WriteLine(dt);
            Console.WriteLine(karakter);

            Console.WriteLine(deger);
            object o1 = "x";
            object o2 = 'a';
            object o3 = 4;
            object o4 = 4.3; // tüm değişken tipleri birer object'dir ve istenilen veri tipinde değer atanabilir. Object üst türdür.

            // string ifadeler
            string str ="";
            string str1 = null; //yukarıdaki ile aynı anlama gelir.
            string str2 = string.Empty; //üçü de aynı oldu :)
            str1 = "Büşra Öztürk";
            string ad = "Büşra";
            string soyad = "Öztürk";
            string tamisim = ad + " " + soyad;
            
            //integer ifadler
            int s1 = 5;
            int s2 = 3;
            int carp = s1*s2;

            //Boolean
            bool tf = 10<2; // buradan false dönecektir.

            //değişken dönüşümleri
            string str10  = "20";
            int s10 = 22;

            string yeniDeger = str10 + s10.ToString(); // değişken tipi dönüşümüdür. integer değer int yapılmıştır.
            Console.WriteLine("iki string ifade toplandığında {0}", yeniDeger);

            int yeniDeger1 = s10 + Convert.ToInt32(str10); // string bir değer integer e dönüştürüldü. int.Parse de kullanılabilirdi.
            Console.WriteLine("iki int ifade toplandığında {0}",yeniDeger1);

            //string datetime hour

            string gunZaman = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(gunZaman);

            string gunZaman2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(gunZaman2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
            
        }
    }
}