using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	[CustomPropertyDrawer(typeof(Enum), true)]
	public class EnumDrawer : PropertyDrawer
	{
		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			return EditorGUI.GetPropertyHeight(property, label);
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			Rect r = position;
			position.xMax -= 50;
			r.xMin = position.xMax;
			var color = GUI.contentColor;
			GUI.contentColor = Color.red;
			GUI.Label(r, "ENUM");
			GUI.contentColor = color;

			EditorGUI.PropertyField(position, property, label, true);
		}
	}
}
