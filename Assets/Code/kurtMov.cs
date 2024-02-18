using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kurtMov : MonoBehaviour
{
    public TrapMaker trapMaker;
    public Trap2Maker trap2Maker;
    public Trap3Maker trap3Maker;
    public Animator animation;
    public  AudioSource audioSource;
    public AudioClip clip;
    public bool trap;
    public bool hang;
    public bool fall;
    bool isOn = false;

    private void Update()
    {
        if (trapMaker != null && trap)
        {
            if(trapMaker.trapCol.activeSelf == true) 
            {
                transform.position = Vector2.MoveTowards(transform.position, trapMaker.transform.position, 3* Time.deltaTime);
                animation.SetBool("Walk", true);
                
                if(isOn == false)
                {
                    audioSource.PlayOneShot(clip);
                    isOn = true;
                }

            }
        }

        if (trap2Maker != null && hang) 
        {
            print("asdasd");
            if (trap2Maker.trapCol.activeSelf == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, trap2Maker.transform.position, 3 * Time.deltaTime);
                animation.SetBool("Walk", true);
                
                if (isOn == false)
                {
                    audioSource.PlayOneShot(clip);
                    isOn = true;
                }


            }
        }

        if (trap3Maker != null && fall)
        {
            print("asdasd");
            if (trap3Maker.trapCol.activeSelf == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, trap3Maker.transform.position, 3 * Time.deltaTime);
                animation.SetBool("Walk", true);

                if (isOn == false)
                {
                    audioSource.PlayOneShot(clip);
                    isOn = true;
                }


            }
        }
    }
}
