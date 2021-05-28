using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	public partial class MyComponent : MonoBehaviour
	{
		public bool myBool;
		public int myInt;
		public float myFloat;
		[Range(20, 50)]
		public float myFloatWithSlider = 25;

		public enum MyEnum
		{
			A, B, C
		}
		public MyEnum myEnum;

		[Serializable]
		public class MyClass
		{
			public float myFloat;
		}

		public MyClass myClassInstance;


		[Header("Physics")]
		public Vector3 physicsBox = Vector3.one;
	}
}
