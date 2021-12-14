using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingBehaviour : MonoBehaviour
{
    private float delta;
    private int counter;
    public float maxHeight;
    void Start()
    {
        delta = 0.01f;
        counter = 0;
    }
    
    void Update()
    {
       
        if (counter < maxHeight)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + delta, transform.position.z);
            counter++;
        }
        else
        {
            counter = 0;
            delta *= -1;
        }
    }

}
