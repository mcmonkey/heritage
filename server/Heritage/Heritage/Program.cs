using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
namespace Heritage
{
	using Game.State;
	using System.IO;
	class Program
	{
		static string storage = @"./urmom.wbin";

		static void Main(string[] args)
		{
			World w = new World();
			w.players.Create();
			w.players.concrete[1].Name = "lol";
			BinaryFormatter b = new BinaryFormatter();
			FileStream f = new FileStream(storage, FileMode.OpenOrCreate);
			b.Serialize(f, w);
		}
	}
}
