using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[CustomEditor(typeof(SoliderGroup))]
public class SoliderGroupEditor : Editor
{
    public override void OnInspectorGUI()
    {
        SoliderGroup sg = target as SoliderGroup;


        if (DrawDefaultInspector())
        {

        }

        //EditorGUILayout.Space();
        if (GUILayout.Button("Generate One Solider"))
        {


            sg.AddMembers(1);

        }


    }
}
