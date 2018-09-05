using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
	class KlasseRum
	{
		public string KlasseNavn { get; set; }
		public List<Studerende> Klasseliste { get; set; }
		public DateTime SemesterStart { get; set; }

		public KlasseRum()
		{
			
		}

		public void countStudentsEfterÅrstider()
		{
			List<int> countStudents = new List<int>();

			var queryStudents = from elev in Klasseliste
								group elev by elev.Årstid();
			
			foreach (var årstid in queryStudents)
			{
				Console.WriteLine("Antal der har fødselsdag til " + årstid.Key + ": " + årstid.Count());
			}
		}
	}
}
