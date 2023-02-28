using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CSI124_Static__Lecture8
{
    /// <summary>
    /// Interaction logic for Shelter_Information.xaml
    /// </summary>
    public partial class Shelter_Information : Window
    {
        private object TextShelterName;

        public Shelter_Information()
        {
            InitializeComponent();
            DisplayShelterInformation();
            
        }

        private void btnOpenNewWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShelterchengename_Click(object sender, RoutedEventArgs e)
        {
            string newShelterName = TextShelterName.Text;
            Shelter.ShelterLocation = newShelterName;
            DisplayShelterInformation();
        }
        public void DisplayShelterInformation()
        {
            runDisplay.Text = $"" +
             $"Shelter Name  - { Shelter.ShelterLocation}\n" +
             $"Shelter Addrese  - { Shelter.Address}\n" +
             $"Shelter City  - { Shelter.City}\n" +
             $"Shelter State  - { Shelter.State}\n";
        }
    }
}
