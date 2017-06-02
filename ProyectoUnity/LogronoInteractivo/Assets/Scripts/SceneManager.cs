using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vuforia
{

    public class SceneManager : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void VisitarWeb()
        {
            Application.OpenURL(ManagerVariables.URLdestino);
        }
    }
}