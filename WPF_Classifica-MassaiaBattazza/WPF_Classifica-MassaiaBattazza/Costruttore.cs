using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Classifica_MassaiaBattazza
{
    internal class Costruttore
    {
        internal string NomeCostruttore { get; set; }
        internal int PunteggioCostruttore { get; set;}
        internal int[] PilotiSelezionati { get; set; }

        //costruttore 
        public Costruttore(string nomeCostruttore, int punteggioCostruttore, int[] pilotiSelezionati)
        {
            NomeCostruttore = nomeCostruttore;
            PunteggioCostruttore = punteggioCostruttore;
            PilotiSelezionati = pilotiSelezionati;
        }

        

    }
}
