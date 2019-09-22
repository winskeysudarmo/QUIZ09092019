using System;

class BangunRuang
{
    public void Volume_Balok()
    {
        int panjang, tinggi, lebar;

        Console.WriteLine("Menghitung Volume Balok");
        Console.WriteLine("..............................");

        Console.WriteLine("Masukkan Nilai Panjang");
        panjang = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Masukkan Nilai Lebar");
        lebar = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Masukkan Nilai Tinggi");
        tinggi = Convert.ToInt32(Console.ReadLine());

        int volume = panjang * lebar * tinggi;

        Console.WriteLine("Volume Balok Adalah "+volume);
    }
    public void Volume_Kubus()
    {
        int sisi;

        Console.WriteLine("Menghitung Volume Kubus");
        Console.WriteLine("..............................");

        Console.WriteLine("Masukkan Nilai sisi");
        sisi = Convert.ToInt32(Console.ReadLine());

        int volume = sisi * sisi * sisi;

        Console.WriteLine("Volume Kubus Adalah "+volume);





    }
}