using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	public static class SceneViewDrawExample
	{
		static GUIStyle style;
		[InitializeOnLoadMethod]
		static void hook()
		{
			SceneView.duringSceneGui += view =>
			{
				Handles.BeginGUI();
				{
					style ??= new GUIStyle("box") {fontSize = 32};
					GUI.color = Color.blue;
					GUILayout.Box("hey dude I'm drawing in the scene view!", style);
				}
				Handles.EndGUI();
			};
		}
	}
}
