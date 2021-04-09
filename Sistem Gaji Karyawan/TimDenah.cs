using System;
namespace Sistem_Gaji_Karyawan
{
    public class TimDenah : Karyawan
    {
        private double Fee = 150000; //Fee per jam
        private double hours; // jam kerja dalam seminggu

        public TimDenah(string nama, double jamKerja) : base (nama)
        {
            Hours = jamKerja;
        }
        public double Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value >= 0 && value <= 168)
                hours = value;
                else throw  new ArgumentOutOfRangeException("Jam", value, "Jam harus >=0 dan <= 168");
            }
        }
        public override double Gaji()
        {
            if (hours <= 24)
                return Fee*Hours;
            else
                return (Fee * Hours + ((Hours - 24)*Fee*0.1));
        }
        public override void display(){
            double a = Gaji();
            Console.WriteLine("Tim Denah\nNama\t: {0}\nJam\t: {1} Hours\nGaji\t: Rp{2}\n",nama,Hours,a);
        }
    
    }
}