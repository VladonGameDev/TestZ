using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearRotate : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * 100 * Time.deltaTime);
    }
}
