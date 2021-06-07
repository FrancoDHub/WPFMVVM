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
using WPFMVVM.ModelViews;
using WPFMVVM.ViewInterfaces.MyUserControls;

namespace WPFMVVM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
                        ModelViews.MainWindowsBusiness windowsBusiness = new ModelViews.MainWindowsBusiness();

                        this.DataContext = windowsBusiness; //le dataconcept c'est une proprite de manwindowXaml mais c'est un objet qui va recevoir l'instance de modelsView
                                                            // ou instance de mainwindowBusiness donc dataconcept = de mainwindowXaml est affecte a Mainwindowbusiness
                                                            // Alors on a dit a Dataconcept que ses donnees sont dans  MainwindowsBusiness
            */
           



        }

        ViewInterfaces.MyUserControls.UCetudiant cetudiant; // je le mets global

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            //ViewInterfaces.MyUserControls.UCetudiant cetudiant = new ViewInterfaces.MyUserControls.UCetudiant(); //UserControl Controls ou creation d'interfaces pour le metier gestion incident
            cetudiant = new ViewInterfaces.MyUserControls.UCetudiant(); // je le estancier pour faire le bouton Absence

            ModelViews.UcEtudiantBusiness etudiantBusiness = new ModelViews.UcEtudiantBusiness();
            cetudiant.DataContext = etudiantBusiness; //quelque soit le controle qui se trouve dans cetudiant il peut utiliser les proprietes qui se trouvent dans etudiantBusiness
                                                       // apres on doit aller dans le UCetudiant.Xaml pour faire le binding pour cela on doit le faire avec la propriete de
                                                       //  UcEtudiantBusiness qui est LstEtudiant
            grcontent.Children.Clear();
            grcontent.Children.Add(cetudiant);

         }

        private void BtnAbsence_Click(object sender, RoutedEventArgs e)//UserControl Controls ou creation d'interfaces pour le metier gestion incident
        {
            cetudiant.DataContext = new UcAbsenceBusiness(); //il est deja instancier'

            //ViewInterfaces.MyUserControls.UCabsence cabsence = new UCabsence();
            //// ModelViews.UcAbsenceBusiness absenceBusiness = new ModelViews.UcAbsenceBusiness();
            //cabsence.DataContext = new UcAbsenceBusiness();


            //grcontent.Children.Clear();
            //grcontent.Children.Add(cabsence);

        }


        /*
        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            //2- maintenant pour afficher dans le Datagrid on a besoin d'une liste
            List<Etudiant> Lstetudiants = new List<Etudiant>();

            // 1- ici l'etudiant est cree
            ModelsClasses.Etudiant etudiant = new ModelsClasses.Etudiant(); // instancer ou donner naissance a un objet etudiant
            etudiant.Nom = "bakara"; //f/definissons les valeurs ou les proprietes
            etudiant.Prenom = "louis";
            etudiant.CIN = "123456";
            etudiant.CNE = "7890";
            //  3 -ajputer l'etudiant a la liste
            Lstetudiants.Add(etudiant);
            // 4 - afficher l'etudiant ou l'affecter au datagrid
            dgEtudiant.ItemsSource = Lstetudiants; // itemsource attend une collection alors je lui donne lstEtudiant

        }
        */

    }
}
