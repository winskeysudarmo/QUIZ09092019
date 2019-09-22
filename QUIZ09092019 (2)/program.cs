using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar obj = new BangunDatar();
            obj.Luas_Persegi();
            obj.Luas_Segitiga();
            obj.Luas_Lingkaran();

            BangunRuang obj2 = new BangunRuang();
            obj2.Volume_Balok();
            obj2.Volume_Kubus();
        }
    }
}
