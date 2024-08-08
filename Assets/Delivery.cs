using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float  DestroyDelay = 0.1f;  
    bool hasPackage = false;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.tag == "Package" & hasPackage == false )
        {
            Debug.Log("Packaged picked up");
            Destroy(other.gameObject,DestroyDelay);
            hasPackage = true;
        }

        if(other.tag == "Station" & hasPackage == true )
        {
            Debug.Log("Packaged delivered");
            Destroy(other.gameObject,DestroyDelay);
            hasPackage = false;

        }

    }

}
