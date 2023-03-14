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
        //A static constructor has no access modifier because it doesn't have message passing
        //and is used during domain processing. Static Constructor is used to initializing
        //static data members of the class.

       // When does the static constructor get called?
       //The static constructor is called before you use anything in the class,
       //but exactly when that happens is up to the implementation.
       //It's guaranteed to be called before the first static member is accessed and
       //before the first instance is created.

        static Shelter()
        {
            _programRuns = DateTime.Now;
            MessageBox.Show($"The static Constructor just run at: {_programRuns}");
        }
        //Instanced feild
        public List<Animal> animals = new List<Animal>();
        //Static Method
        //Can a static method use instanced fields?
        //The very commonly used String
        public static string ShelterInformation()
        {
            return $"" +
                $"Shelter Name  - { Shelter.ShelterLocation}\n" +
                $"Shelter Addrese  - { Shelter.Address}\n" +
                $"Shelter City  - { Shelter.City}\n" +
                $"Shelter State  - { Shelter.State}\n";
        }
        //It is not possible to inherit from a static class, they are sealed,
        //Can you inherit from a static class?
        //and static method cannot be virtual.
        //Instanced feild couldn't be called inside the static method.
        public static void DisplayAnimals()
        {

        }
    }
}