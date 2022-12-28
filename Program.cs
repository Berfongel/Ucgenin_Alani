// See https://aka.ms/new-console-template for more information
double yukseklik, taban_uzunlugu, alan;

Console.WriteLine("Yükseklik değerini giriniz : ");
yukseklik = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Taban uzunluk değerini giriniz : ");
taban_uzunlugu = Convert.ToDouble(Console.ReadLine());
alan = ((taban_uzunlugu*yukseklik)/2);
Console.WriteLine("Üçgenin alanı : " + alan);
