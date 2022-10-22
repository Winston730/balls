using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass : MonoBehaviour
{
    public GameObject pass; 
    void OnCollisionEnter2D(Collision2D other)
    {
        if(pass != other.gameObject)
        {
            Destroy(other.gameObject);
        }
       
    }
}
