using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called after Update, making sure the match of placing the camera gets done smoothly. 
    
    void LateUpdate()
    {
        // need to pull back the camera on the z axis to look at the 2D surface from above
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-1); 
    }
}
