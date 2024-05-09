using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class PlayableCharacters
    {
		private List<Character> characters;

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



	}
}
