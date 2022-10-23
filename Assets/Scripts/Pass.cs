using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pass : MonoBehaviour
{
    public int amountOfCountry;
    private int counter = 0;

    void OnCollisionEnter2D(Collision2D other)
    {
        counter++;
        if(counter <= amountOfCountry - 1) 
        {   
            if(counter == amountOfCountry - 1) 
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            }
            Destroy(other.gameObject);
        } 
    }
}
