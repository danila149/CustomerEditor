using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

[CreateAssetMenu( fileName = "name", menuName =  "So/SO)")]
public class SO : ScriptableObject 
{
    [SerializeField] private List<Audio> audio;
    private int _id;
    private string _text;
    [Serializable]
    public class Audio
    {
        public AudioClip audioClip;
        [Range(0, 1)] public float _voluem;

    }
    [CustomEditor(typeof(SO))]
    public class IdEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            SO so = (SO)target;
            DrowId(so);
            DrowText(so);
        }

        private void DrowId(SO so)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("ID", GUILayout.MaxWidth(100));
            so._id = EditorGUILayout.IntField(so._id);
            EditorGUILayout.EndHorizontal();
        }
        private void DrowText(SO so)
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Text", GUILayout.MaxWidth(50));
            so._text = EditorGUILayout.TextField(so._text, GUILayout.MaxHeight(100));
            EditorGUILayout.EndHorizontal();
        }
    }
}




