using System;
namespace Sistem_Gaji_Karyawan
{
    public class TimDED : Karyawan
    {
        private double Fee = 750000; // gaji tiap gambar luas 100m2
        private double luas; 

        public TimDED(string nama, double luasBangunan) : base (nama)
        {
            luas = luasBangunan;
        }
        public override double Gaji()
        {
            if (luas%100 == 0) return Fee;
            else 
                return (((luas%100)*7500)+Fee);
        }
            public override void display(){
            double a = Gaji();
            Console.WriteLine("Tim DED\nNama\t: {0}\nLuas\t: {1} m2\nGaji\t: Rp{2}\n",nama,luas,a);
            }
    }
}