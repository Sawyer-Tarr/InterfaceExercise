using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public bool ThirdRowSeating { get; set; }
        public string Engine { get; set; }
        public string Logo { get ; set ; }
        public string Slogan { get ; set ; }
        public string Color { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public int Year { get ; set ; }
    }
}
