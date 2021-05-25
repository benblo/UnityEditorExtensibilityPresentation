using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	[CustomPropertyDrawer(typeof(MyComponent.MyClass))]
	public class MyClassDrawer : PropertyDrawer
	{
		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			return EditorGUI.GetPropertyHeight(property, label) +
			       EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var color = GUI.contentColor;
			GUI.contentColor = Color.red;

			//position.height = EditorGUIUtility.singleLineHeight;
			//GUI.Label(position, "hello MyClassDrawer");
			GUI.Box(position, "hello MyClassDrawer");

			GUI.contentColor = color;

			position.yMin += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;

			EditorGUI.PropertyField(position, property, label, true);
		}
	}
}
