using UnityEngine;
using System.Collections;

namespace BizzyGames.ItemSystem
{
	[System.Serializable]
	public class ISObject : IISObject {
		[SerializeField]Sprite _icon;
		[SerializeField]string _name;
		[SerializeField]int _value;
		[SerializeField]int _encumberance;
		[SerializeField]ISQuality _quality;

		public string Name {
			get {return _name;}
			set {_name = value;}
		}

		public int Value {
			get {return _value;}
			set {_value = value;}
		}

		public Sprite Icon {
			get {return _icon;}
			set {_icon = value;}
		}

		public int Encumberance {
			get {return _encumberance;}
			set {_encumberance = value;}
		}

		public ISQuality Quality {
			get {return _quality;}
			set {_quality = value;}
		}
	}
}