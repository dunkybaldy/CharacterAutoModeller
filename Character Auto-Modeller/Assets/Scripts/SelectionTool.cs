using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityHelpers;

namespace AutoModeller
{
    public class SelectionTool : MonoBehaviour
    {
        public GameObject TargetWithBones;

        private float BoneHighlightDistance = 0.5f;

        // Start is called before the first frame update
        void Start()
        {
            if (TargetWithBones == null)
                print("target with bones not set");
                //throw new GameObjectNullException("GameObject: [TargetWithBones] is null in SelectionTool.cs");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}