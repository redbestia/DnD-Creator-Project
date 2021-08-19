using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{
    public class CollectAllMenuCanvas : MonoBehaviour
    {
        public static GameObject[] ListOfMemuCanvas;

        private void Awake()
        {
            ListOfMemuCanvas = GameObject.FindGameObjectsWithTag(Tagi.MenuCanvasTag);
        }
    }
}