﻿using UnityEngine;
using System.Collections;

namespace BizzyGames.ItemSystem.Editor
{	
	public partial class ISObjectEditor 
	{

		void ItemDetails() {
			GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
			GUILayout.Label("Detail View");
			GUILayout.EndHorizontal();
		}
	}
}