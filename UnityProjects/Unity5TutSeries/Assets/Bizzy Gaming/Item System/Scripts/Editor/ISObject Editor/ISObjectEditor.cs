using UnityEditor;
using UnityEngine;
using System.Collections;

namespace BizzyGames.ItemSystem.Editor
{	
	public partial class ISObjectEditor : EditorWindow {
		[MenuItem("BG/Database/Item Editor %#i")]
		public static void Init()
		{
			ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
			window.minSize = new Vector2(800, 600);
			window.title = "Item DB";
			window.Show();
		}


		void OnEnable() {

		}

		void OnGUI() {
			TopTabBar();
			GUILayout.BeginHorizontal();
			ListView();
			ItemDetails();
			GUILayout.EndHorizontal();
			BottomStatusBar();
		}
	}
}