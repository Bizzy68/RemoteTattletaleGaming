using UnityEngine;
using System.Collections;

namespace BizzyGames.ItemSystem
{
	public interface IISEquippable 
	{
		ISEquipmentSlot EquipmentSlot { get; }
		bool Equip();
	}
}
