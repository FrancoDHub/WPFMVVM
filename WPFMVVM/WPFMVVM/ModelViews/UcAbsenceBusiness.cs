using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVM.ModelsClasses;

namespace WPFMVVM.ModelViews
{
    
    public class UcAbsenceBusiness
    {
        public string Addbutton { get; set; }
        public string Editbutton { get; set; }

        public string Deletebutton { get; set; }



        public string businesslabel { get; set; }

        public List<Absence> LstofObject { get; set; }


        public UcAbsenceBusiness()
        {
            Addbutton = "Ajouter Absence";
            Editbutton = "Editer Absence";
            Deletebutton = " supprimer Absence";


            businesslabel = "Gestion Absence";
            LstofObject = new List<Absence>();

            for (int i = 0; i < 1; i++)

            {
                Absence absence = new Absence();


                LstofObject.Add(absence);
    

            }
            
        }
    }
}
