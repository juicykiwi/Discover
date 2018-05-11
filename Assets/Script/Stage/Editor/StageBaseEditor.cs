using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Discover.Stage
{
    [CanEditMultipleObjects()]
    [CustomEditor(typeof(StageBase))]
    public class StageBaseEditor : Editor
    {
        private int _loadStageIndex = 0;

        private StageBase _target = null;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            _target = target as StageBase;

            // Save, Load
            GUILayout.Space(20f);
            GUILayout.BeginHorizontal(GUIStyle.none);
            {
                GUILayout.BeginVertical(GUIStyle.none);
                {
                    GUILayout.Space(25f);
                    _loadStageIndex = EditorGUILayout.IntField("Load target stage index", _loadStageIndex);
                }
                GUILayout.EndVertical();

                GUILayout.BeginVertical(GUIStyle.none);
                {
                    if (GUILayout.Button("Save") == true)
                    {
                        _target.Save();
                        AssetDatabase.Refresh();
                    }

                    if (GUILayout.Button("Load") == true)
                    {
                        _target.Load(_loadStageIndex);
                    }
                }
                GUILayout.EndVertical();
            }
            GUILayout.EndHorizontal();
        }
    }
}