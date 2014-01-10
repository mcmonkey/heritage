using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Heritage.Game.State
{
	[Serializable]
	[DataContract]
	public class Terrain
	{
		// km
		[DataMember]
		public double metric_size = 100.0;

		[DataMember]
		public uint width = 0;

		[DataMember]
		public uint height = 0;

		[DataMember]
		public uint[] nodes;

		public Terrain()
		{
			Generate(100, 100, 100.0);
		}

		private void Generate(uint width, uint height, double metric_size)
		{
			this.width = width;
			this.height = height;
			this.metric_size = metric_size;
			nodes = new uint[width * height];
		}
	}
}
