using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wild
{
	[CreateAssetMenu]
	public class PointCloud : ScriptableObject
	{
		public Vector3[] points = new Vector3[1024];
	}
}
