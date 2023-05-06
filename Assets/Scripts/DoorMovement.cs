using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    public Animator doorAnimator;
    public GameObject hero;
    bool open;
    bool onetime;
    void Start()
    {
        doorAnimator = GameObject.Find("wooden").transform.GetChild(5).GetComponent<Animator>();
        doorAnimator.SetBool("open", false);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(hero.transform.position, transform.position);
        if(distance < 6)
        {
            open = true;
        }
        else
        {
            open = false;
        }
        doorAnimator.SetBool("open", open);

    }
}
