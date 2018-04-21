using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication19.Models
{
    public class AHU     // Dane dotyczące cech bez względu na osprzęt
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Breadth { get; set; }
        public int Height { get; set; }
        public int Lenght { get; set; }
        public int Diameter { get; set; }
        public int Weight { get; set; }
        public int NomOut { get; set; }
        public int ExtPres { get; set;}
        public int FanPow { get; set; }
        public int HePower { get; set; }
        public int WoPower { get; set; }
        public string SupVolHe { get; set; }
        public string SupVol { get; set; }
        public int TotPowCons { get; set; }
        public double Efficiency { get; set; }
        public int SoundLevel { get; set; }
        public string PowClass { get; set; }
     
    }
}