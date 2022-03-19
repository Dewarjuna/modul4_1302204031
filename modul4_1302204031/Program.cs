using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204031
{
    class Program
    {
        static void Main(string[] args)
        {//nim 1302204031
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>(13, 02, 20));


        }
    }

    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
        {
            dynamic a = input1;
            dynamic b = input2;
            dynamic c = input3;

            return a + b + c;
        }
    }


}