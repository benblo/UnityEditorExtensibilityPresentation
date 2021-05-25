using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	public partial class MyComponent
	{
		[Header("Gizmos")]
		public bool drawGizmos = true;
		public float gizmoRadius = 1;

		protected void OnDrawGizmosSelected()
		{
			if (!drawGizmos)
			{
				return;
			}
			Gizmos.matrix = transform.localToWorldMatrix;
			Gizmos.color = Color.blue;
			Gizmos.DrawWireSphere(Vector3.zero, gizmoRadius);
		}


		[Header("Physics")]
		public Vector3 physicsBox = Vector3.one;
	}
}
