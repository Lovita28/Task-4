using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Akhir_4_Kalkulator
{
    class Program
    {
        static double Bagi(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            else
                return x / y;
        }
        static int kali(int x, int y)
        {
            return x * y;
        }
        static int tambah(int x, int y)
        {
            return x + y;
        }
        static int kurang(int x, int y)
        {
            return x - y;
        }
        static void info()
        {
            Console.WriteLine("\nTekan \"Esc\" untuk berhenti, atau tekan tombol lain untuk melanjutkan. ");
        }
        static void Main(string[] args)
        {
            info();
            ConsoleKeyInfo cki = Console.ReadKey();
            while (cki.Key != ConsoleKey.Escape)
            {
                try
                {
                    Console.WriteLine("==================================================");
                    Console.WriteLine("==-------------KALKULATOR SEDERHANA-------------==");
                    Console.WriteLine("==================================================");
                    Console.WriteLine("==        Silahkan pilih perhitungan :          ==");
                    Console.WriteLine("==----------------------------------------------==");
                    Console.WriteLine("==            1. Penjumlahan                    ==");
                    Console.WriteLine("==            2. Pengurangan                    ==");
                    Console.WriteLine("==            3. Perkalian                      ==");
                    Console.WriteLine("==            4. Pembagian                      ==");
                    Console.WriteLine("==----------------------------------------------==");
                    Console.Write("== Silahkan masukan pilihan ==");
                    int a = int.Parse(Console.ReadLine());

                    if (a == 1)
                    {
                        Console.WriteLine("1. Penjumlahan");
                        Console.Write(" Masukan Angka Pertama :");
                        int i = int.Parse(Console.ReadLine());
                        Console.Write(" Masukan Angka Kedua :");
                        int j = int.Parse(Console.ReadLine());
                        int jumlah = tambah(i, j);
                        //Console.Write("Jumlah : {0}", i + j);
                        Console.Write("Jumlah : {0}", jumlah);
                    }
                    else if (a == 2)
                    {
                        Console.WriteLine("2. Pengurangan");
                        Console.Write(" Masukan Angka Pertama :");
                        int k = int.Parse(Console.ReadLine());
                        Console.Write(" Masukan Angka Kedua :");
                        int l = int.Parse(Console.ReadLine());
                        double kurangi = kurang(k, l);
                        // Console.WriteLine("Jumlah : {0}", k - l);
                        Console.WriteLine("Jumlah : {0}", kurangi);
                    }
                    else if (a == 3)
                    {
                        Console.WriteLine("3. Perkalian");
                        Console.Write(" Masukan Angka Pertama :");
                        int m = int.Parse(Console.ReadLine());
                        Console.Write(" Masukan Angka Kedua :");
                        int n = int.Parse(Console.ReadLine());
                        int kalian = kali(m, n);
                        //Console.WriteLine("Jumlah : {0}", m * n);
                        Console.WriteLine("Jumlah : {0}", kalian);
                    }
                    else if (a == 4)
                    {
                        Console.WriteLine("4. Pembagian");
                        Console.Write(" Masukan Angka Pertama :");
                        double o = double.Parse(Console.ReadLine());
                        Console.Write(" Masukan Angka Kedua :");
                        double p = double.Parse(Console.ReadLine());
                        double hasil = Bagi(o, p);
                        Console.WriteLine("Jumlah : {0}", hasil);
                    }
                    else
                    {
                        Console.WriteLine("Pilihan tidak ada");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nException message : {0}", ex.Message);
                    Console.WriteLine("Exception stack trace : {0}", ex.StackTrace);
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    info();
                    cki = Console.ReadKey();
                }
            }
        }
    }
}
