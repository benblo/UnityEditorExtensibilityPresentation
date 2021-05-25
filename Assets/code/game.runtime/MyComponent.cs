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
	}
}
