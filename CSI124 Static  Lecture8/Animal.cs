using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI124_Static__Lecture8
{
    internal class Animal
    {
        //static

        //feild
        string _name;
        string _shelterLocation;
        //Add a static feild
        public static string Type="Cat";
        public static int NumberOfAnimal = 0;
        
        //constructor
        public Animal(string name, string shelterLocation)
        {
            Name = name;
            ShelterLocation = shelterLocation;
            NumberOfAnimal++;
        }
        //property
        public string Name { get => _name; set => _name = value; }
        public string ShelterLocation { get => _shelterLocation; set => _shelterLocation = value; }
        
    }
}
