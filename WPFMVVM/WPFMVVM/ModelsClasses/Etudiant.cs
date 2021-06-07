using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVM.ViewInterfaces;



namespace WPFMVVM.ModelsClasses
{
   public class Etudiant
    {
        #region Propriete
        public string Nom { get; set; } // avec prop c'est plus vite


        public string Prenom { get; set; }

        public string CIN { get; set; }
        public string CNE { get; set; }
        public DateTime DateNaissance { get; set; }
        #endregion

        #region Constructeur
        public Etudiant() // ctor plus facile
        {

        }
        public Etudiant(string nom)
        {
            this.Nom = nom;
        }

        public Etudiant(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }
        #endregion


    }
}
