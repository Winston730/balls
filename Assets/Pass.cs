using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass : MonoBehaviour
{
    public GameObject rus = GameObject.Find("RUSSIA");
    public GameObject usa;
    public GameObject uk;
   void OnCollisionEnter2D(Collision2D other)
   {
        if(other.gameObject == rus) Destroy(rus);
   }
}
