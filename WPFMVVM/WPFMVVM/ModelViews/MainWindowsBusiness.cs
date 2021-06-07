using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVM.ModelsClasses;


namespace WPFMVVM.ViewInterfaces
{
    public class MainWindowsBusiness
    {
       

        //ModelViews.MainWindowsBusiness windowsBusiness = new MainWindowsBusiness();

        public string TitleOfMainwindows { get; set; }

        public List<ModelsClasses.Etudiant> ListOfStudents { get; set; }

        // dans DAtagrid XAML jenvais lier ces deux proprietes..alors je dis a itemsource qu'il est lie a ListofStudents
        /* </StackPanel>
       <DataGrid x:Name="dgEtudiant"
                 ItemsSource="{Binding ListOfStudents}"
        alprs ModelsView c'est le Data, le metier les Fonctionnalites
        */

        public MainWindowsBusiness()
        {
            TitleOfMainwindows = " Hello from the other side";

            ListOfStudents = new List<Etudiant>(); // en finale on doit l'instancer

            //alors maintenant  je vais creer 5 etudiants pour cela on applique For,,,car on connait le nombre dans le cas contraire se serait ForEach
            for (int i = 0; i < 4; i++)
            {
                Etudiant etudiant = new Etudiant();

               

                etudiant.CIN = "123446";
                etudiant.CIN = "02468";
                etudiant.Nom = "fred" + i.ToString(); //ici je converti le i qui est un entier en chaine de caractwere
                etudiant.Prenom = "bakara" + i.ToString(); //ici je converti le i qui est un entier en chaine de caractwere

                ListOfStudents.Add(etudiant); //ajouter a la liste


            }


        }
    }
}
