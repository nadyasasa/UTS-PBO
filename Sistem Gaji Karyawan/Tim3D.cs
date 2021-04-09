using System.Globalization;
using System;
namespace Sistem_Gaji_Karyawan
{
    public class Tim3D : Karyawan
    {
        private int nProject; //banyak project yang dikerjakan
        private double Fee = 150000; //upah tiap satu project

        public Tim3D(string nama, int banyakProject) : base(nama)
        {
            nProject = banyakProject;
        }

        public override double Gaji()
        {
            if(nProject<=10)
                return nProject*Fee;  
            else
                return (Fee * nProject + ((Fee - 24)*Fee*0.1));
        }

        public override void display(){
            double a = Gaji();
            Console.WriteLine("Tim 3D\nNama\t: {0}\nProject\t: {1} Projects\nGaji\t: Rp{2}\n",nama,nProject,a);
        }
        
    }
}