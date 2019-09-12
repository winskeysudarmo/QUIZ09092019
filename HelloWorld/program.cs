 using System;

namespace HelloWorld
{
   class program
    {
static void Main(string[] args)
{
    bangundatar obj = new bangundatar();
    bangunruang obj2 = new bangunruang();
    Console.WriteLine("menghitung luas persegi ");
        Console.WriteLine("-----------------------");

       int s;
    Console.Write("masukkan nilai sisi :");
    s = Convert.ToInt32(Console.ReadLine());

    obj.luas_persegi(s);
   
    int a1, a2, a3;

        Console.WriteLine("-----------------------");
        Console.WriteLine("menghitung luas Segitiga ");
        Console.WriteLine("-----------------------");


    Console.Write("masukkan alas : ");
    a1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Masukkan tinggi : ");
    a2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("luas segitiga adalah "+obj.luas_segitiga(a1,a2));

     Console.WriteLine("-----------------------");
        Console.WriteLine("menghitung luas lingkaran ");
        Console.WriteLine("-----------------------");

           int r;
    Console.Write("masukkan panjang jari-jari :");
    r = Convert.ToInt32(Console.ReadLine());

    obj.luas_lingkaran(r);


     Console.WriteLine("-----------------------");
        Console.WriteLine("menghitung Volume balok ");
        Console.WriteLine("-----------------------");


    Console.Write("masukkan panjang : ");
     a1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Masukkan lebar : ");
    a2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Masukkan tinggi : ");
    a3 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Volume balok adalah "+obj2.Volume_balok(a1,a2,a3));

   

         Console.WriteLine("-----------------------");
        Console.WriteLine("menghitung Volume kubus ");
        Console.WriteLine("-----------------------");

    int sisi;

    Console.Write("Masukkan sisi : ");
    sisi = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Volume kubus adalah "+obj2.Volume_kubus(sisi));
            }
         }
    }