using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVM.ViewInterfaces;


namespace WPFMVVM.ModelsClasses
{
    public class Absence
    {
        public int IdAbsence { get; set; }

        public Absence()
        {
                    
        }

        public Absence(int Id)

        {
            this.IdAbsence = Id;


        }
    }
}
