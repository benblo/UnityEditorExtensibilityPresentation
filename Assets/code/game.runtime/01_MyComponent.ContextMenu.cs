using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	public partial class MyComponent
	{
		[ContextMenu("hello from context menu")]
		void MyContextMenuItem()
		{
			Debug.Log($"hello my name is <{this}>", this);
		}

		[ContextMenu("sub-context menu/hello from sub context menu")]
		void MySubContextMenuItem()
		{
			Debug.Log($"hello my name is <{this}> SUB", this);
		}

#if UNITY_EDITOR
		[UnityEditor.MenuItem("Wild/MyComponent/Hello World")]
#endif
		static void MyMenuItem()
		{
			Debug.Log("hello wild wild world!");
		}
	}
}
