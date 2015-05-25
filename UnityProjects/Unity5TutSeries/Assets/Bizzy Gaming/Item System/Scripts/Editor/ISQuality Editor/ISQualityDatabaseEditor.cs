using UnityEditor;
using UnityEngine;
using System.Collections;


namespace BizzyGames.ItemSystem.Editor
{
	public partial class ISQualityDatabaseEditor : EditorWindow {
		ISQualityDatabase qualityDatabase;
		int selectedIndex = -1;
		Texture2D selectedTexture;
		Vector2 _scrollPos;									//scoll the position for the ListView

		const int SPRITE_BUTTON_SIZE = 46;
		const string DATABASE_NAME = @"BGQualityDatabase.asset";
		const string DATABASE_PATH = @"Database";
		const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;

		[MenuItem("BG/Database/Quality Editor %#w")]
		public static void Init()
		{
			ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
			window.minSize = new Vector2(400, 300);
			window.title = "Quality DB";
			window.Show();
		}

		void OnEnable()
		{
			qualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase>();
			qualityDatabase = qualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
       }


		void OnGUI()
		{
			if(qualityDatabase == null)
			{
				Debug.LogWarning("qualityDatabase not loaded");
				return;
			}
			ListView();

			GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
			BottomBar();
			GUILayout.EndHorizontal();
		}

		void BottomBar(){
			//count
			GUILayout.Label("Qualities : " + qualityDatabase.Count);
			//addbutton
			if(GUILayout.Button("Add"))
			{
				qualityDatabase.Add(new ISQuality());
			}
		}
	}
}

