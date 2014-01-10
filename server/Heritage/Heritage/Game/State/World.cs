using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Heritage.Game.State
{
	[Serializable]
	[DataContract]
	public class World
	{
		[DataMember]
		public IdentityDictionary<Player> players;

		[DataMember]
		public IdentityDictionary<Character> characters;

		private bool m_isDirty = false;

		// Seconds
		[DataMember]
		public uint time;

		[DataMember]
		public Terrain terrain = new Terrain();

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
