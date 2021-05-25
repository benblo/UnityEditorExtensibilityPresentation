using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.EditorTools;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	[EditorTool(label, typeof(MyComponent))]
	class SceneViewToolExample : EditorTool
	{
		const string label = "SceneViewToolExample";

		#region toolbarIcon

		[SerializeField] Texture2D _toolbarIconImage; // Serialize this value to set a default value in the Inspector.
		GUIContent _toolbarIcon;
		public override GUIContent toolbarIcon => _toolbarIcon ??= new GUIContent(label, _toolbarIconImage, label);

		#endregion


		new MyComponent target => (MyComponent)base.target;
		SerializedObject serializedObject;

		public override void OnActivated()
		{
			base.OnActivated();

			serializedObject = new SerializedObject(target);
		}

		public override void OnWillBeDeactivated()
		{
			base.OnWillBeDeactivated();

			serializedObject = null;
		}


		static readonly Vector3[] axes =
		{
			new Vector3(1, 0, 0),
			new Vector3(0, 1, 0),
			new Vector3(0, 0, 1),
		};

		public override void OnToolGUI(EditorWindow window)
		{
			Handles.matrix = target.transform.localToWorldMatrix;
			Handles.color = Color.green;

			var physicsBox = serializedObject.FindProperty("physicsBox");
			var box = physicsBox.vector3Value;
			Handles.DrawWireCube(Vector3.zero, box);

			for (int i = 0; i < axes.Length; i++)
			{
				var axis = axes[i];
				for (int sign = -1; sign <= 1; sign += 2)
				{
					var pos = axis * box[i] * 0.5f * sign;
					pos = Handles.FreeMoveHandle(
						pos, Quaternion.identity, 
						HandleUtility.GetHandleSize(pos) * 0.1f,
						Vector3.zero, Handles.SphereHandleCap);
					box[i] = pos[i] * 2 * sign;
				}
			}

			physicsBox.vector3Value = box;
			serializedObject.ApplyModifiedProperties();
		}
	}
}
