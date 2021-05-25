using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	[CustomEditor(typeof(MyComponent))]
	public partial class MyComponentEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			var color = GUI.contentColor;
			GUI.contentColor = Color.red;
			GUILayout.Label("hello MyComponentEditor");
			GUI.contentColor = color;

			base.OnInspectorGUI();
		}
	}
}
