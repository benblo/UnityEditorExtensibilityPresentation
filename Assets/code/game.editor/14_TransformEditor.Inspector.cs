using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	[CustomEditor(typeof(Transform), true)]
	[CanEditMultipleObjects]
	public class TransformEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			var color = GUI.contentColor;
			GUI.contentColor = Color.red;
			GUILayout.Label("all your Transformz are belong to us!");
			GUI.contentColor = color;

			base.OnInspectorGUI();
		}
	}
}
