using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarTraduceiRE
{
    public class Dictionar
    {
        public int idC;

        public Dictionar()
        {
            idC = 0;
        }

        public Dictionar(int id)
        {
            idC = id;
        }

        public override string ToString()
        {
            return "Id-ul este: " + idC;
        }
    }
}
