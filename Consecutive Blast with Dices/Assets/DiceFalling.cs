using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceFalling : MonoBehaviour
{
    Rigidbody myRigidbody = new Rigidbody();

    private float xVelocity;
    private float yVelocity;
    private float zVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        xVelocity = myRigidbody.velocity.x;
        yVelocity = myRigidbody.velocity.y;
        zVelocity = myRigidbody.velocity.z;
    }

    // Update is called once per frame
    void Update()
    {
        xandzVelocity();
    }

    private void xandzVelocity()
    {
        xVelocity = 0f;
        zVelocity = 0f;
        zVelocity = 0f;
    }
}
