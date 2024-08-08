using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    const float INVERT  = -1;
    [SerializeField] float steerSpeed = 0.05f;
    [SerializeField] float moveSpeed = 0.005f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * INVERT * Time.deltaTime; // Invert or -1 was added to reverse the steering. 
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // deltatime makes movements frame independent
        transform.Rotate(0,0,steerAmount);
        transform.Translate(0,moveAmount,0);
        
    }
}
