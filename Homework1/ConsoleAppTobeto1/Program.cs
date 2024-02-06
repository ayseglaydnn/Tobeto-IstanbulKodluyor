/*
Console.WriteLine("Lütfen bir sayı giriniz.");
int orderNo = Int32.Parse(Console.ReadLine());
switch (orderNo)
{
    case 1:
        Console.WriteLine("Sipariş edilen ürün: Kola");
        break;


    case 2:
        Console.WriteLine("Sipariş edilen ürün: Ayran");
        break;


    case 3:
        Console.WriteLine("Sipariş edilen ürün: Kahve");
        break;


    case 4:
        Console.WriteLine("Sipariş edilen ürün: Su");
        break;

    default:
        Console.WriteLine("Lütfen bir sayı giriniz.");
        break;

}*/

/*
//2 - kullanıcıdan kaç ürün almak istediğini soran, her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)
Console.WriteLine("How many product do you want to buy?");
int productNum = Convert.ToInt32(Console.ReadLine());
double totalPrice = 0;

for(int i= 0; i < productNum; i++)
{
    Console.WriteLine($"Enter the price of {i + 1}. product: ");
    double productPrice = Convert.ToDouble(Console.ReadLine());
    totalPrice += productPrice;
}

Console.WriteLine($"Total price is: {totalPrice}");*/

/*
//3 - Do - While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

//do-while
string condition = "";
do
{
    Console.Write("Kaç adet ürün almak istersiniz:");
    int piece = Convert.ToInt32(Console.ReadLine());
    double totalPrice = 0;
    double productPrice = 0;

    for (int i = 0; i < piece; i++)
    {
        Console.Write(i + 1 + ".ürünün fiyatını girin:");
        productPrice = Convert.ToDouble(Console.ReadLine());
        totalPrice += productPrice;
    }
    Console.WriteLine("Ödemeniz gereken toplam tutar:" + totalPrice.ToString());
    Console.WriteLine("");
    Console.Write("devam etmek istiyor musunuz?(E/H)");
    condition = Console.ReadLine().ToString().ToUpper();
    Console.WriteLine("");

} while (condition == "E");


//while
Console.WriteLine("Enter the number you want to get factorial.");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
int factorial = 1;

while (num >= i)
{
    factorial *= i;
    i++;
}
Console.WriteLine($"Factorial of {num} is {factorial}");
*/

/*
//4- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

static bool MukemmelSayiMi(int sayi)
{
    int toplam = 0;
    for (int i = 1; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            toplam += i;
        }
    }
    return toplam == sayi;
}

Console.Write("Bir sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());

if (MukemmelSayiMi(sayi))
{
    Console.WriteLine(sayi + " mükemmel bir sayıdır.");
}
else
{
    Console.WriteLine(sayi + " mükemmel bir sayı değildir.");
}
*/

/*
//5- String metotlarını araştırınız. Her bir metot için örnek yapınız.

//1. Length: Bir metnin karakter sayısını döndürür.

string lngth = "Merhaba dünya!";
int length = lngth.Length;
Console.WriteLine(length);
//2.ToUpper(): Bir metnin tüm karakterlerini büyük harfe çevirir.
string uppr = "Merhaba dünya!";
string upper = uppr.ToUpper();
Console.WriteLine(upper);
////3.ToLower(): Bir metnin tüm karakterlerini küçük harfe çevirir.
string lwr = "MERHABA DÜNYA!";
string lower = lwr.ToLower();
Console.WriteLine(lower);
////4. Substring(): Bir metnin belirli bir kısmını döndürür.
string sbt = "Merhaba dünya!";
string substring = sbt.Substring(7);
Console.WriteLine(substring);
////5.IndexOf(): Bir metnin içinde belirli bir karakterin veya dizenin ilk bulunduğu konumu döndürür.
string ınof = "Merhaba dünya!";
int index = ınof.IndexOf('a');
Console.WriteLine(index);
////6.Contains(): Bir metnin belirli bir karakteri veya diziyi içerip içermediğini kontrol eder.
string cnt = "Merhaba dünya!";
bool contains = cnt.Contains("dünya");
Console.WriteLine(contains);
////7.Replace(): Bir metnin içinde belirli bir karakteri veya diziyi başka bir karakter veya diziyle değiştirir.
string rpl = "Merhaba dünya!";
string replaced = rpl.Replace("dünya", "evren");
Console.WriteLine(replaced);
////8.Split(): Bir metni belirli bir karaktere veya diziye göre parçalara ayırır.
string spl = "Merhaba, dünya!";
string[] splitted = spl.Split(',');
foreach (string s in splitted)
{
    Console.WriteLine(s);
}
////9. Trim(): Bir metnin başındaki ve sonundaki boşlukları kaldırır.
string trm = "   Merhaba dünya!   ";
string trimmed = trm.Trim();
Console.WriteLine(trimmed);
//10.ToCharArray(): Bir metni karakter dizisine dönüştürür.
string str = "Merhaba dünya!";
char[] chars = str.ToCharArray();

foreach (char c in chars)
{
    Console.WriteLine(c);
}

*/

/*
//6- Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır. ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.

Console.WriteLine("Enter the price of product:");

double productPrice = Convert.ToDouble(Console.ReadLine());

double cargoPrice = productPrice >= 300 ? 0 : 50;

Console.WriteLine($"Amount you need to pay is {productPrice + cargoPrice}");
*/

/*
//7- iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.

using System.ComponentModel.Design;

Console.WriteLine("Enter the price of first product:");

double firstProductPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the price of second product:");

double secondProductPrice = Convert.ToDouble(Console.ReadLine());

Double totalPrice = firstProductPrice + secondProductPrice;

if(totalPrice > 500)
{
    secondProductPrice = secondProductPrice*0.6;
    totalPrice = firstProductPrice + secondProductPrice;
}

Console.WriteLine($"Total price is {totalPrice}");
*/

/*
//8- 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.

int counter = 0;

Console.WriteLine("Number divisible by 3 or 5 :");

for(int i =0; i < 200; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        counter++;
        Console.Write(i + ",");
    }

}
Console.WriteLine($"\nCounter: {counter}");

*/
