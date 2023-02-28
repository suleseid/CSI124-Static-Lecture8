using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSI124_Static__Lecture8
{

    internal class Shelter
    {
        public static string ShelterLocation = ("Kent pet shelter");
        public static string Address = "1234 Kent way";
        public static string City = "Kent";
        public static string State = "WA";

        public static DateTime _programRuns;
        //Static Construcor can't be made public
        //It's automatically private.

        //static Constructor can't take Parameters
         
        static Shelter()
        {
            _programRuns = DateTime.Now;
            MessageBox.Show($"The static Constructor just run at: {_programRuns}");
        }
        //Instanced feild
        public List<Animal> animals = new List<Animal>();
        //Static Method
        public static string ShelterInformation()
        {
            return $"" +
                $"Shelter Name  - { Shelter.ShelterLocation}\n" +
                $"Shelter Addrese  - { Shelter.Address}\n" +
                $"Shelter City  - { Shelter.City}\n" +
                $"Shelter State  - { Shelter.State}\n";
        }
        //Instanced feild couldn't be called inside the static method.
        public static void DisplayAnimals()
        {

        }
    }
}