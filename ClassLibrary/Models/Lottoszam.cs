using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Lottoszam
    {
        public int Id { get; set; }
        public int Szam1 { get; set; }
        public int Szam2 { get; set; }
        public int Szam3 { get; set; }
        public int Szam4 { get; set; }
        public int Szam5 { get; set; }

        public Lottoszam()
        {
        }

        public Lottoszam(int szam1, int szam2, int szam3, int szam4, int szam5)
        {
            Szam1 = szam1;
            Szam2 = szam2;
            Szam3 = szam3;
            Szam4 = szam4;
            Szam5 = szam5;
        }
    }
}
