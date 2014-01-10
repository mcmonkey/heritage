using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Heritage.Game.State
{
	public interface IWorldObject
	{
		uint ID { get; set; }

		World World { get; set; }

		void Created();
	}
}
