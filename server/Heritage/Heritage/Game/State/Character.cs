using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage.Game.State
{
	[Serializable]
	public class Character : IWorldObject
	{
		public uint ID { get; set; }

		public World World { get; set; }

		public void Created()
		{
		}
	}
}
