using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierOneMove : MonoBehaviour
{
    private int i;
    private void FixedUpdate()
    {
        i++;
        if(i > 50 && i <= 62)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        else if(i > 100 && i <=112)
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        else if(i > 150)
        {
            i = 0;
        }
    }
}
