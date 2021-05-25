using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	public static class GizmoExample
	{
		[DrawGizmo(
			GizmoType.Pickable | GizmoType.NotInSelectionHierarchy,
			typeof(MyComponent))]
		static void DrawGizmoForMyComponent(MyComponent target, GizmoType type)
		{
			if (!target.drawGizmos)
			{
				return;
			}
			Gizmos.matrix = target.transform.localToWorldMatrix;
			Gizmos.color = Color.magenta;
			Gizmos.DrawWireSphere(Vector3.zero, target.gizmoRadius);
		}
	}
}
