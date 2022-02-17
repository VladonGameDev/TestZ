using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int runnersCount;
    public int curentRunnersCount;
    public GameObject runner;
    public Draw draw;
    public List<GameObject> Runners;

    private void Start()
    {
        curentRunnersCount = runnersCount;
        float j = -0.4f;
        for(int i = 0; i<runnersCount; i++)
        {
            GameObject Runner;
            Runner = Instantiate(runner, new Vector3(j, 0.1f, -9.5f), Quaternion.identity, this.transform);
            Runners.Add(Runner);
            j = j + 0.1f;
        }
    }
    private void FixedUpdate()
    {
        if (draw.Line.positionCount > 0 && draw.Line.positionCount > runnersCount)
        {
            float index = draw.Line.positionCount / runnersCount;
            int intIndex = (int)index;
            int nextIndex = intIndex;
            for (int i = 0; i<Runners.Count; i++)
            {
                Runners[i].transform.position = Vector3.MoveTowards(Runners[i].transform.position, new Vector3(draw.Line.GetPosition(nextIndex).x, 0.1f, draw.Line.GetPosition(nextIndex).z + 0.6f), Time.deltaTime * 0.5f);
                nextIndex += intIndex;
            }
        }
        if (curentRunnersCount < runnersCount)
        {
            for (int i = 0; i < runnersCount - curentRunnersCount; i++)
            {
                GameObject Runner;
                Runner = Instantiate(runner, new Vector3(0, 0.1f, -9.5f), Quaternion.identity, this.transform);
                Runners.Add(Runner);
            }
            curentRunnersCount = runnersCount;
        }
    }
}
