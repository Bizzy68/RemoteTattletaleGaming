using UnityEditor;
using UnityEngine;
using System.Collections;


namespace BizzyGames.ItemSystem.Editor
{
	public partial class ISQualityDatabaseEditor
	{	
		private void ListView() {
			_scrollPos = EditorGUILayout.BeginScrollView(_scrollPos, GUILayout.ExpandHeight(true));
			DisplayQualities();
			EditorGUILayout.EndScrollView();
		}

		void DisplayQualities() {
			for(int cnt = 0;cnt < qualityDatabase.Count; cnt++)
			{
				GUILayout.BeginHorizontal("Box");
				//sprite
				if(qualityDatabase.Get(cnt).Icon)
					selectedTexture = qualityDatabase.Get(cnt).Icon.texture;
				else selectedTexture = null;

				if(GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
				{
					int controllerID = EditorGUIUtility.GetControlID(FocusType.Passive);
					EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controllerID);
					selectedIndex = cnt;
				}
				
				string commandName = Event.current.commandName;
				if(commandName == "ObjectSelectorUpdated")
				{
					if(selectedIndex != -1)
						qualityDatabase.Get(selectedIndex).Icon =(Sprite) EditorGUIUtility.GetObjectPickerObject();
						selectedIndex = -1;
				}
				Repaint ();

				GUILayout.BeginVertical();
				//name
				qualityDatabase.Get(cnt).Name = GUILayout.TextField(qualityDatabase.Get (cnt).Name);
				//delete button
				if(GUILayout.Button("Delete", GUILayout.Width(60),GUILayout.Height(20)))
				{
					if(EditorUtility.DisplayDialog("Delete Quality",
					                               "Are you sure you want to delete '" + qualityDatabase.Get(cnt).Name + "' quality from the database?",
					                               "Yes",
					                               "Cancel"))
						qualityDatabase.Remove(cnt);
				}

				GUILayout.EndVertical();
				GUILayout.EndHorizontal();
			}

		}
	}
}
