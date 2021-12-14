/*
 *                    Final Test - Mobile Game Programming
 *                    Author: Negar Saeidi
 *                    Student number : 101261396
 *                    Date last modified: 12/14/2021
 *                    File Name: FloatingPlatformController
 *                    Rivision history: 1st version :  Upon platform's activation, the platform shrinks gradually over time. When platform gets deactivated, the length of it backs to normal.
 *                 
 *                    
 *                    
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPlatformController : MonoBehaviour
{
    private Vector3 platformInitialScale;
    public bool isActive;
    public AudioSource[] platformEffectsAudio;
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
            if (!platformEffectsAudio[0].isPlaying)
            {
                platformEffectsAudio[0].Play();
            }
            transform.localScale = new Vector3(transform.localScale.x - 0.01f, transform.localScale.y, transform.localScale.z);
        }
      
      
    }
    private void BackToNormal()
    {
        if (transform.localScale.x != 1)
        {
            if (!platformEffectsAudio[1].isPlaying && !platformEffectsAudio[0].isPlaying)
            {
                platformEffectsAudio[1].Play();
             
            }
            transform.localScale = new Vector3(transform.localScale.x + 0.01f, transform.localScale.y, transform.localScale.z);
        }
    }
    public void Reset()
    {
    }
    }
