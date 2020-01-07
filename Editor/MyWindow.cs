using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MyWindow : EditorWindow
{
    
    [MenuItem(("Window/MyWindow"))]
    public static void Make()
    {
        EditorWindow.GetWindow<MyWindow>();
    }
}
