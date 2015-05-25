using UnityEngine;
using System.Collections;

namespace BizzyGames.ItemSystem{

	public interface IISDestructable
	{
		int Durability { get; }
		int maxDurability { get; }
		void TakeDamage( int amount);
		void Repair();
		void Break();
	}
}
