using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriger : MonoBehaviour
{
    public WorldMove runnersMove;
    public PlayerController playerController;
    public GameObject PS;
    private void Start()
    {
        runnersMove = GameObject.Find("RunnersSpline").GetComponent<WorldMove>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        PS.SetActive(false);
    }
    private void OnTriggerEnter(Collider collider)
    {
        playerController.curentRunnersCount = playerController.runnersCount;
        if (collider.tag == "Barrier")
        {
            Destroy(gameObject, 0.5f);
            PS.SetActive(true);
            playerController.runnersCount--;
            playerController.curentRunnersCount--;
        }
        else if (collider.tag == "NewRunner")
        {
            runnersMove.Tiles.Remove(collider.transform);
            Destroy(collider.gameObject);
            playerController.runnersCount++;
        }
    }
}
