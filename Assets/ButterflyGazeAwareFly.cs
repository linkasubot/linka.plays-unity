using System.Collections;
using System.Collections.Generic;

using Tobii.Gaming;
using UnityEngine;

public class ButterflyGazeAwareFly : MonoBehaviour
{
    GazeAware gaze;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        gaze = GetComponent<GazeAware>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("fly", gaze.HasGazeFocus);
    }

}
