using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackOverflowSceneView : MonoBehaviour
{
       public bool KeepSceneViewActive = true;

        void Start()
        {
            if (this.KeepSceneViewActive && Application.isEditor)
            {
                UnityEditor.SceneView.FocusWindowIfItsOpen(typeof(UnityEditor.SceneView));
            }
        }
    }
