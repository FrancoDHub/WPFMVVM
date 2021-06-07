using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVM.ModelsClasses;

namespace WPFMVVM.ModelViews
{
   public  class UcEtudiantBusiness // cette classe va contenir tous les metiers tous les donnees que le user Controle va utiliser
                                    // et maintenant on vas sentir l'isolation de l'interface
    {
        //avant de faire la delegate IReadOnlyCollection vas d'abord telecharger une framework du nom de prism,il y aencore d'autres telsque  MEF,(sylverligt qui n'existe plus)
        //mais on vas utiliser Prism au lieu de MEF



        // public List<Etudiant> LstEtudiants { get; set; }// cette propriete est encore nulle pour l'utiliser il faut le instancier dans le Constructeur

        public string Addbutton { get; set; }
        public string Editbutton { get; set; }

        public string Deletebutton { get; set; }

        public string businesslabel { get; set; }
        public Etudiant SelectedStudent { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<Etudiant> LstofObject { get; set; } // remplace list par observableCollection

        public UcEtudiantBusiness()

            
            //pour instancier la classe on doit appeler le constructeur et pour instancier la liste Etudiant on doit faire une boucle
        {
            Addbutton = "Ajouter Etudiant";
            Editbutton = "Editer Etudiant";
            Deletebutton = " supprimer Etudiant";
            businesslabel = "  Gestion Etudiant";

            LstofObject = new ObservableCollection<Etudiant>(); //stanciation de la propriete

            for (int i = 0; i < 4 ; i++)
            {
                Etudiant etudiant = new Etudiant();
                                                                        //pour faire le bouton absence j'ai du remplacer listofOjets a la place de lstetudiants et lstabsence patout
                {
                   etudiant. Nom = "franco :" + i.ToString();
                    etudiant.Prenom = "bakara : " + i.ToString();

                } // Creation Etudiant

                LstofObject.Add(etudiant); //a chaque fois je cree un etudiant je l'ajoute

            } 

        }
    }
}
