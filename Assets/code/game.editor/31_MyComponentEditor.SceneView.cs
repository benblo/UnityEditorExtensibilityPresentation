using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	public partial class MyComponentEditor
	{
		protected void OnEnable()
		{
			SceneView.duringSceneGui += OnSceneViewGui;
		}
		protected void OnDisable()
		{
			SceneView.duringSceneGui -= OnSceneViewGui;
		}

		new MyComponent target => (MyComponent)base.target;

		void OnSceneViewGui(SceneView view)
		{
			Handles.matrix = target.transform.localToWorldMatrix;
			Handles.color = Color.yellow;

			var gizmoRadius = serializedObject.FindProperty("gizmoRadius");
			gizmoRadius.floatValue = Handles.RadiusHandle(Quaternion.identity, Vector3.zero, gizmoRadius.floatValue);

			serializedObject.ApplyModifiedProperties();
		}
	}
}
