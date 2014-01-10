using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage.Game.State
{
	[Serializable]
	public class World
	{
		public IdentityDictionary<Player> players;

		public IdentityDictionary<Character> characters;

		private bool m_isDirty = false;

		public World()
		{
			characters = new IdentityDictionary<Character>(this);
			players = new IdentityDictionary<Player>(this);
		}

		public void SetDirty()
		{
			m_isDirty = true;
		}


	}
}
