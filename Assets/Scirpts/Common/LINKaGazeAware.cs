using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LINKaGazeAware : MonoBehaviour
{
    internal Action GazeEnter = new Action(() => { });
    internal Action GazeStay = new Action(() => { });
    internal Action GazeExit  = new Action(() => { });
}
