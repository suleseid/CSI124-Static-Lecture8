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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSI124_Static__Lecture8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object textShelterName;
        

        // private Shelter ShelterName;

        public MainWindow()
        {
            //inistance
            InitializeComponent();
            runDisplay.Text = $"" +
                $"Shelter Name  - { Shelter.ShelterLocation}\n" +
                $"Shelter Addrese  - { Shelter.Address}\n" +
                $"Shelter City  - { Shelter.City}\n" +
                $"Shelter State  - { Shelter.State}\n";

        }
        public static void Example()
        {
            Animal animal = new Animal("Mochi", Shelter.ShelterLocation);

            MessageBox.Show(animal.ShelterLocation);

            //How do we access static members?
            //we use the dot operator on type,
            //MessageBox.Show(Animal.Type);
        }

        private void btnOpenNewWindow_Click(object sender, RoutedEventArgs e)
        {
            //To create a new instance use the new keyword
            Shelter_Information shelter_Information = new Shelter_Information();
            //to show our new window, we need to use .show() instant method 
            // on our window instance.
            shelter_Information.Show();

        }

        private void btnRefreshInformation_Click(object sender, RoutedEventArgs e)
        {
            runDisplay.Text = Shelter.ShelterInformation();
     
        }

        private void btnShelterchengename_Click(object sender, RoutedEventArgs e)
        {
            string shelterName = txtBox.Text;
            Shelter.ShelterLocation = shelterName;
        }
    }
}
