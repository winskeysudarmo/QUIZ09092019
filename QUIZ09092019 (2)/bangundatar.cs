using System;

class BangunDatar
{
    public void Luas_Persegi()
    {
        int sisi;
        Console.WriteLine("Menghitung Luas Persegi");
        Console.WriteLine("..............................");

        Console.WriteLine("Masukkan Nilai Sisi");
        sisi = Convert.ToInt32(Console.ReadLine());

        int luas = sisi * sisi;

        Console.WriteLine("Nilai Luas Persegi adalah "+luas);
    }
    public void Luas_Segitiga()

    {
        int alas, tinggi;
        
        Console.WriteLine("Menghitung LuasSegitiga");
        Console.WriteLine("..............................");

        Console.WriteLine("Masukan Nilai Alas");
        alas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Masukan Nilai Tinggi");
        tinggi = Convert.ToInt32(Console.ReadLine());

        int luas = alas * tinggi / 2 ;

        Console.WriteLine("Nilai Luas Segitiga Adalah "+luas);
    }
    public void Luas_Lingkaran()
    {
        int jari_jari;

        Console.WriteLine("Menghitung Luas Lingkaran");
        Console.WriteLine("..............................");

        Console.WriteLine("Masukan Nilai jari-jari");
        jari_jari = Convert.ToInt32(Console.ReadLine());

        double luas = 3.14 * jari_jari * jari_jari;

        Console.WriteLine("Luas Lingkarang Adalah "+luas);

    }
}