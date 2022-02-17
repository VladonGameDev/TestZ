using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotate : MonoBehaviour
{
    private float RotateSpeed = 10f;
    private int i;
    private void Start()
    {
        i = 50;
    }
    private void FixedUpdate()
    {
        if(i >= 0 && i < 100)
            transform.Rotate(Vector3.right * Time.deltaTime * RotateSpeed, Space.Self);
        if(i >= 100)
            transform.Rotate(Vector3.right * Time.deltaTime * -RotateSpeed, Space.Self);
        i++;
        if (i >= 200)
            i = 0;
    }
}
