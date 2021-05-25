using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Wild
{
	public static class ContextMenuExample
	{
		[MenuItem("CONTEXT/MyComponent/hello from static context menu")]
		static void StaticContextMenuItem(MenuCommand cmd)
		{
			MyComponent ctx = (MyComponent)cmd.context;
			Debug.Log($"hello my name is <{ctx}>");
		}

		[MenuItem("CONTEXT/Transform/hello from context menu")]
		static void TransformContextMenuItem(MenuCommand cmd)
		{
			Transform ctx = (Transform)cmd.context;
			Debug.Log($"hello my name is <{ctx}>");
		}
	}
}
