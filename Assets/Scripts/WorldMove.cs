using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMove : MonoBehaviour
{
    public float speed;
    public List<Transform> Tiles;

    private void Start()
    {
        Tiles.AddRange(GetComponentsInChildren<Transform>());
        for (int i = 0; i < Tiles.Count; i++)
        {
            if (Tiles[i].tag == "Untagged" || Tiles[i].tag == "Barrier")
            {
                Tiles.RemoveAt(i);
                i--;
            }
        }
    }

    private void FixedUpdate()
    {
        for(int i = 0; i < Tiles.Count; i++)
            Tiles[i].Translate(Vector3.back * speed * Time.deltaTime);
    }
}
