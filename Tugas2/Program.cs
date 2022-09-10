using System;

namespace Tugas2
{
    class Perkuliahan  //Nama class
    {
        string nama = "Selvianisa"; // variable global
        double IPS,
            Algopro = 3.5,
            Kalkulus = 4.0,
            English = 4.0;
        static void Main(string[] args) //method
        {
            Perkuliahan p = new Perkuliahan();
            Console.WriteLine("Hai, " + p.nama + "!");
            Console.WriteLine("Sistem ini bertujuan untuk menentukan pengambilan jumlah sks berdasarkan capaian Indeks Prestasi Semester (IPS)");
            double a = 4, b = 3, c = 2;
            p.IPS = Math.Round(((p.Algopro * a + p.Kalkulus * b + p.English * c) / 9), 2);
            double i = p.IPS;
            //decision
            if (i > 3.20)
            {
                Console.WriteLine("IPS Anda adalah " + i + ". Maka, maksimal sks yang bisa Anda ambil sebanyak 24 sks");
            }
            else if (i > 2.75 && i <= 3.20)
            {
                Console.WriteLine("IPS Anda adalah " + i + ". Maka, maksimal sks yang bisa Anda ambil sebanyak 23 sks");
            }
            else if (i > 2.25 && i <= 2.75)
            {
                Console.WriteLine("IPS Anda adalah " + i + ". Maka, maksimal sks yang bisa Anda ambil sebanyak 21 sks");
            }
            else
            {
                Console.WriteLine("IPS Anda adalah " + i + ". Maka, maksimal sks yang bisa Anda ambil sebanyak 19 sks");
            }
            p.detail();
            Console.WriteLine("Daftar NIM kelas B : "); p.nim();
        }
        void detail()
        {
            Console.WriteLine("Berikut detail nilai per mata kuliah yang telah Anda tempuh di semester ini : " + "\n" + sks());
        }

        void nim()
        {
            string[] NIM = new string[] { "L200190001", "L200190002", "L200190003", "L200190004", "L200190005" }; //Looping
            for (int i = 3; i < NIM.Length; i++)
            {
                Console.WriteLine(NIM[i]);
            }
        }
        string sks() //method non void
        {
            Perkuliahan p = new Perkuliahan();
            return "Algopro : " + p.Algopro + "\n"
                + "Kalkulus : " + p.Kalkulus + "\n"
                + "English : " + p.English;
        }
    }
}
