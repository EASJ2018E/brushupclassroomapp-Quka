using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
			KlasseRum klasse = new KlasseRum();
	        klasse.KlasseNavn = "3B";
			klasse.SemesterStart = new DateTime(2018, 9, 3);

	        klasse.Klasseliste.Add(new Studerende("Arlind", 4, 24));
	        klasse.Klasseliste.Add(new Studerende("Benjamin", 6, 18));
	        klasse.Klasseliste.Add(new Studerende("Zaki", 6, 6));
		}
    }
}
