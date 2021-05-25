using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Wild
{
	public static class MenuItemExample
	{
		[MenuItem("Wild/Hello World")]
		static void MyMenuItem()
		{
			Debug.Log("hello wild wild world!");
		}

		[MenuItem("Wild/sub-menu/Hello from sub-menu")]
		static void MySubMenuItem()
		{
			Debug.Log("hello wild wild world from sub-menu!");
		}
	}
}
