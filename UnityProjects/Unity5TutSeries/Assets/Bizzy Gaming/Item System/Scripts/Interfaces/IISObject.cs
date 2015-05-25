using UnityEngine;
using System.Collections;

namespace BizzyGames.ItemSystem{
	public interface IISObject {


		string Name {get; set;}
		int Value {get;set;}
		Sprite Icon{get;set;}
		int Encumberance {get;set;}
		ISQuality Quality {get;set;}

		//   these go to other item interfaces
		//equip
		//questItem flag
	}
}
