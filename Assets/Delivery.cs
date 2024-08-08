using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float  DestroyDelay = 0.1f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackagecolor = new Color32(1,1,1,1); 
    bool hasPackage = false;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        
        if(other.tag == "Package" & hasPackage == false )
        {
            Debug.Log("Packaged picked up");
            Destroy(other.gameObject,DestroyDelay);
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            
        }

        if(other.tag == "Station" & hasPackage == true )
        {
            Debug.Log("Packaged delivered");
            Destroy(other.gameObject,DestroyDelay);
            hasPackage = false;
            spriteRenderer.color = noPackagecolor;

        }

    }

}
