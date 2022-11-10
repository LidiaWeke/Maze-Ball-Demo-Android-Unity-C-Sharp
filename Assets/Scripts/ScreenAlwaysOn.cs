using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenAlwaysOn : MonoBehaviour
{
    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
