using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Heritage.Game.State
{
	[Serializable]
	[DataContract]
	public class Character : IWorldObject
	{
		[DataMember]
		public uint ID { get; set; }

		public World World { get; set; }

		public void Created()
		{
		}
	}
}
