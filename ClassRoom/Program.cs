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

	        klasse.Klasseliste = new List<Studerende>()
	        {
		        new Studerende("Arlind", 4, 24),
		        new Studerende("Benjamin", 6, 18),
		        new Studerende("Zaki", 6, 6)
	        };

			// Write to console
			Console.WriteLine("Klassenavn: " + klasse.KlasseNavn);
			Console.WriteLine("Semesterstart: " + klasse.SemesterStart + "\n\r");
	        foreach (Studerende s in klasse.Klasseliste)
	        {
		        Console.WriteLine(s);
				Console.WriteLine(s.Navn + " har fødseldag til " + s.Årstid() + "\n\r");
	        }

			klasse.countStudentsEfterÅrstider();
			
			Console.WriteLine("\n\rPress any key to end program");
	        Console.ReadKey();
        }
    }
}
