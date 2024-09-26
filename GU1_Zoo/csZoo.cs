using System;
using System.Dynamic;
using Seido.Utilities.SeedGenerator;

namespace GU1_Zoo
{
	public class csZoo
	{
		public string ZooName {get; set;}
		public int nrAnimals {get; set;}

		// public csZoo(string ZooName, int nrAnimals)
		// {
		// 	this.ZooName = ZooName;
		// 	this.nrAnimals = nrAnimals;
		// }
        public override string ToString()
        {
            string sRet = "";
			foreach (var animal in AnimalNames)
			{
				sRet += $"\n{animal}";
			}
			return sRet;
        }
		public List<csAnimal> AnimalNames {get; set;} = new List<csAnimal>();
		public csZoo(csSeedGenerator _seeder, int nrAnimals)
		{
			for (int i = 0; i < nrAnimals; i++)
			{
				this.AnimalNames.Add(new csAnimal(_seeder));
			}
		}

		
        public csZoo()
		{
			foreach (enAnimalKind kind in Enum.GetValues(typeof(enAnimalKind)))
			{
				foreach (enAnimalMood mood in Enum.GetValues(typeof(enAnimalMood)))
				{
					AnimalNames.Add(new csAnimal {Kind = kind, Mood = mood});
					System.Console.WriteLine($"{kind}-{mood}");
				}
			}
		}
	
	}
}

