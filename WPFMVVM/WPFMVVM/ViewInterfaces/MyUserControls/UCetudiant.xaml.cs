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
using WPFMVVM.ModelsClasses;
using WPFMVVM.ViewInterfaces.DataEntry;


namespace WPFMVVM.ViewInterfaces.MyUserControls
{
    /// <summary>
    /// Logique d'interaction pour UCetudiant.xaml
    /// </summary>
    public partial class UCetudiant : UserControl
    {
        public UCetudiant()
        {                                                               // DATACONTEX envoie toujour un objet
            InitializeComponent();                                      // ShowDialog = afficher la fenetre et est aussi une valeur booleenne alors il peut retourner  une valeur.
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)

        {


            Etudiant etudiant = new Etudiant();

            ViewInterfaces.DataEntry.StudentDataEntry dataEntry = new DataEntry.StudentDataEntry();
            dataEntry.DataContext = etudiant;

            if (dataEntry.ShowDialog() == true)

            {
                ModelViews.UcEtudiantBusiness bs = this.DataContext as ModelViews.UcEtudiantBusiness; //recuperer la liste dans UcEtudiantBusiness
                bs.LstofObject.Add(etudiant); // pourque cela marche il faut utilser observable collection qu'on va mettre dans UcEtudiant Business
            }

            // dataEntry.ShowDialog();

            // ModelViews.UcEtudiantBusiness bs = this.DataContext as ModelViews.UcEtudiantBusiness; //recuperer la liste dans UcEtudiantBusiness
            //bs.LstEtudiants.Add(etudiant); // pourque cela marche il faut utilser observable collection qu'on va mettre dans UcEtudiant Business





        }

        private void BtnEditer_Click(object sender, RoutedEventArgs e)
        {
            ModelViews.UcEtudiantBusiness bs = this.DataContext as ModelViews.UcEtudiantBusiness; //recuperer la liste qui etait dans le bouton ajouter

            if (bs.SelectedStudent != null)
            {
                ViewInterfaces.DataEntry.StudentDataEntry dataEntry = new StudentDataEntry();
                dataEntry.DataContext = bs.SelectedStudent;

                dataEntry.ShowDialog();
            }

            else
            {
                MessageBox.Show("veuillez selectioner un etudiant");

            }


        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            ModelViews.UcEtudiantBusiness bs = this.DataContext as ModelViews.UcEtudiantBusiness; //recuperer la liste qui etait dans le bouton ajouter
            if (bs.SelectedStudent != null)
            {
                bs.LstofObject.Remove(bs.SelectedStudent);




            }
            else
            {
                MessageBox.Show("Selectionnner un Etudiant");

            }
        }
    }
}
//  utiliser Delegate signifie qu'on ne vas pas utiliser  les clicks,pour cela on va mettre tous ces fonctions dans le UCEtudiantBusiness
//il convient qu'on ne vas pas utiler le Click aussi dans le Xaml,alors on vas les enlever en les remplacent par la propriete command qui sera binding avec une autre propriete de UCEtudiantBusiness
