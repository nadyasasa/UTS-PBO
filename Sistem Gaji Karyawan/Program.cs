using System.Collections.Generic;
using System;

namespace Sistem_Gaji_Karyawan
{
    class Program
    {
        static void Main(string[] args)
        {
            var Karyawans = new List<Karyawan>
            {
                new TimDenah("Nadya Kohl",12),
                new TimDenah("Ardhito Permadi", 40),
                new Tim3D("Annissa Alert", 5),
                new Tim3D("Widya Jang", 6),
                new TimDED("Sasha Nur Jannah", 101),
                new TimDED("Sekar Scarlet",102)
            };

            foreach(var Karyawan in Karyawans){
                Karyawan.display();
            }
                   
        }
    }
}
