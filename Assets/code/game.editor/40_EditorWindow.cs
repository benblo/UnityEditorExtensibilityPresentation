using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Wild
{
	public class MyWindow : EditorWindow
	{
		[MenuItem("Wild/My Window")]
		static void Open()
		{
			GetWindow<MyWindow>().titleContent = new GUIContent("My Window");
		}

		protected void OnGUI()
		{
			GUILayout.Label("wow that's fascinating...");
		}
	}
}
