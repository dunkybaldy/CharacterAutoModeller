using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AutoModeller
{
    public class CharacterGenerator : MonoBehaviour
    {
        private Mesh Model;
        // Start is called before the first frame update
        void Start()
        {
            Model = (Mesh)this.GetComponent("Mesh");
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
