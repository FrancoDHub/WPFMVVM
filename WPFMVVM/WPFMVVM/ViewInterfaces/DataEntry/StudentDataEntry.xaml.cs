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

namespace WPFMVVM.ViewInterfaces.DataEntry
{
    /// <summary>
    /// Logique d'interaction pour StudentDataEntry.xaml
    /// </summary>
    public partial class StudentDataEntry : Window
    {
        public StudentDataEntry()
        {
            InitializeComponent();
        }

        private void BtnEnreg_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();

            this.DialogResult = true; //DialoResult est une propriete de StedenDataEntry de type boolean
            // this c'est l'instance de DataEntry

        }

       

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
           // this.Close();
            this.DialogResult = false;
            // alors je vais aller a UcEtudian.cs pour faire la suite
        }
    }
}
