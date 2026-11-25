using System;
using System.Collections.Generic;
using UnityEngine;

    public class EntityObject : MonoBehaviour
    {
        public int mode;
        
        public void ShowHilight(bool show)
        {
            gameObject.GetComponent<Collider>().enabled = show;
            gameObject.GetComponent<Outline>().enabled = show;
        }
    }
