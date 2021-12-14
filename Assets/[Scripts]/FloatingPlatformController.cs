using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPlatformController : MonoBehaviour
{
    private Vector3 platformInitialScale;
    public bool isActive;
    void Start()
    {
        isActive = false;
        platformInitialScale = transform.localScale;
    }
    private void Update()
    {
        if (isActive)
            Shrink();
        else
            BackToNormal();
    }
    private IEnumerator DelayBefore(float sec)
    {
        yield return new WaitForSeconds(sec);
    }
 
 
  
    private void Shrink()
    {
        if (transform.localScale.x > 0.08f)
        {
           
            transform.localScale = new Vector3(transform.localScale.x - 0.01f, transform.localScale.y, transform.localScale.z);
        }
      
      
    }
    private void BackToNormal()
    {
        if (transform.localScale.x != 1)
        {
         
            transform.localScale = new Vector3(transform.localScale.x + 0.01f, transform.localScale.y, transform.localScale.z);
        }
    }
    public void Reset()
    {
    }
    }
