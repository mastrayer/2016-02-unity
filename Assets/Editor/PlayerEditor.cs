using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(PlayerScript))]
public class PlayerEditor : Editor {
    void OnSceneGUI()
    {
        PlayerScript player = target as PlayerScript;
/*
        Handles.BeginGUI();
        if (GUI.Button(new Rect(10, 10, 100, 50), "SHOW")) {
            Debug.Log("ASDASDA");
        }
        Handles.EndGUI();*/

        Handles.color = Color.black;
        //Vector3.Ro
        
        Vector3.Angle(player.transform.forward, player.forward);
        Handles.DrawLine(player.transform.position, player.transform.position + player.forward);
        //Handles.ArrowCap(0, player.transform.position, player.transform.rotation, 1.0f);
    }
}
