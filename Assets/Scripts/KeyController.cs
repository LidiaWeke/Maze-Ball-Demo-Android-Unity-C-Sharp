using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public int speed;

    void Update()
    {
        gameObject.transform.RotateAround(transform.position, Vector3.back, speed * Time.deltaTime);
    }
}
