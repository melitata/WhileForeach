﻿using System;
namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            // 1 den başlayarak console dan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp console a yazdıran program
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);
            // a'dan z'ye kadar tüm harfleri yazdır
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);//yan yana yazdırmak için Write kullanılır
                character++;
            }

            // Foreach
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }







        }
    }
}
