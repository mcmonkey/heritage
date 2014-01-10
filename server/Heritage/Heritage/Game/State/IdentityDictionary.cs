using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Heritage.Game.State
{
	[Serializable]
	[DataContract]
	public class IdentityDictionary<T>  where T : IWorldObject, new()
	{
		[DataMember]
		public Dictionary<uint, T> concrete = new Dictionary<uint, T>();

		[DataMember]
		public uint currentId = 1;

		private World m_world;

		public IdentityDictionary(World world)
		{
			m_world = world;
		}

		public T Create()
		{
			T created = new T();
			created.ID = currentId;
			created.World = m_world;
			created.Created();
			concrete.Add(currentId, created);
			m_world.SetDirty();
			return created;
		}
	}
}
