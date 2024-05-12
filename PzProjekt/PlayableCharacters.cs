using PzProjekt.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class PlayableCharacters
    {
		private List<Character> characters = new List<Character>();

		public List<Character> Characters
		{
			get { return characters; }
			set { characters = value; }
		}

		public Character this[int index]
		{
			get { return characters[index]; }
			set { characters[index] = value; }
		}

		public void Add (Character character)
		{
			if (characters.Count >= 5) 
			{
				throw new TooManySavedGamesException();
			}
			characters.Add(character);
		}

		public int Count { get { return characters.Count; } }
		



	}
}
