using System;
using Seido.Utilities.SeedGenerator;

namespace GU1_Zoo
{
	public enum enAnimalKind { Moose, Wolf, Deer, Eagle, Hawk, Aligator, Elephant, Lion, Monkey }
	public enum enAnimalMood { Happy, Sleepy, Hungry, Lazy, Quick, Slow }

	public class csAnimal
	{
		public enAnimalKind Kind {get; set;}
		public enAnimalMood Mood {get; set;}
		public int Age {get; set;}
		string _name;
		public string Name
		{
			get { return _name; }
			set
			{
				if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(Name));

				_name = value;
			}
		}
		public csAnimal(){}
		public csAnimal(csSeedGenerator _seed)
		{
			Kind = _seed.FromEnum<enAnimalKind>();
			Mood = _seed.FromEnum<enAnimalMood>();
			Age = _seed.Next(1, 100);
			Name = _seed.PetName;		
		}
		public csAnimal(enAnimalKind Kind, enAnimalMood Mood, int Age, string Name)
		{
			this.Kind = Kind;
			this.Mood = Mood;
			this.Age = Age;
			this.Name = Name;
		}
		public csAnimal(csAnimal org)
		{
			this.Kind = org.Kind;
			this.Mood = org.Mood;
			this.Age = org.Age;
			this.Name = org.Name;
		}
        public override string ToString()
        {
			return $"{Name} is {Age} and it is {Mood} {Kind}";
        }
    }

}

