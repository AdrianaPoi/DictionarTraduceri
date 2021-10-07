using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarTraduceiRE
{
  public  class DictionarRomEng:Dictionar, ICloneable
    {
        public string cuvantR;
        public string cuvantE;
        public string explicatie;


        public DictionarRomEng(int idC, string cr, string ce, string expl)
            :base(idC)
        {
            cuvantR = cr;
            cuvantE =ce;
            explicatie = expl;
        }

        public object Clone()
        {
            DictionarRomEng dre = (DictionarRomEng)this.MemberwiseClone();
            return dre;
        }

    }
}
