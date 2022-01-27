using System;
using System.Collections;
using System.Collections.Generic;

using Tobii.Gaming;
using UnityEngine;

public class ButterflyGazeAwareFly : MonoBehaviour
{
    LINKaGazeAware gaze;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       gaze = GetComponentInChildren<LINKaGazeAware>();
        gaze.GazeEnter += GazeEnter;    
        gaze.GazeExit += GazeExit;
    }

    private void GazeExit()
    {
        animator.SetBool("Fly", false);

    }

    void GazeEnter()
    {
        Debug.Log("GazeEnter");
        animator.SetBool("Fly", true);

    }
    // Update is called once per frame
    void Update()
    {
 //       Debug.Log(TobiiAPI.GetGazePoint()+"> "+gaze.HasGazeFocus+". "+ TobiiAPI.GetFocusedObject());
    //    animator.SetBool("Fly", gaze.HasGazeFocus);
    }

}
