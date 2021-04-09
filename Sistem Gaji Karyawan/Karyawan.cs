using System;
namespace Sistem_Gaji_Karyawan
{
    public abstract class Karyawan
    {
     public string nama{get; private set; }
     
     public int waktu{get; private set; }

     public Karyawan(string nama)
     {
         this.nama = nama;
         
     }

    public abstract double Gaji();

      public virtual void display(){
            double a = Gaji();
            Console.WriteLine("Tim Denah\nNama\t: {0}\nJam\t: {1} Hours\nGaji\t: {2}\n",nama,waktu,a);
        }


    }
}