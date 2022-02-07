using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;

public class LINKaGazeCamera : MonoBehaviour
{
    internal bool HasGazeFocus = false;

    GameObject last;

    // Start is called before the first frame update
    void Start()
    {
        //        dObj = GameObject.CreatePrimitive(PrimitiveType.Cube);

    }

    // Update is called once per frame
    void Update()
    {
        var point = TobiiAPI.GetGazePoint();

        if (point.IsValid)
        {
            RaycastHit hit;

            var ray = Camera.main.ScreenPointToRay(point.Screen);
            var raycast = Physics.Raycast(ray, out hit);
            if (raycast)
            {
		Debug.Log(hit.collider);
               var aware = hit.collider.gameObject.GetComponent<LINKaGazeAware>();
                if (aware)
                {
                    if (aware.gameObject != last)
                        aware.GazeEnter();
                    else if (aware. gameObject==last)
                        aware.GazeStay();
                    last = aware.gameObject;
                }
                HasGazeFocus = true;
            }
            else
            {
                HasGazeFocus = false;
                if (last)
                    last.GetComponent<LINKaGazeAware>().GazeExit();

                last = null;
            }
        }
    }
}