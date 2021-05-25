using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	[CustomPropertyDrawer(typeof(bool), true)]
	[CustomPropertyDrawer(typeof(int), true)]
	[CustomPropertyDrawer(typeof(float), true)]
	public class FloatDrawer : PropertyDrawer
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
			GUI.Label(r, property.propertyType.ToString());
			GUI.contentColor = color;

			EditorGUI.PropertyField(position, property, label, true);
		}
	}
}
