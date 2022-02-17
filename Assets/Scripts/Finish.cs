using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public WorldMove worldMove, barriersMove;
    public GameObject Win, WinPanel;
    private void Start()
    {
        Win.SetActive(false);
        WinPanel.SetActive(false);
    }
    private void FixedUpdate()
    {
        if (gameObject.transform.position.z <= -9)
        {
            worldMove.speed = 0;
            barriersMove.speed = 0;
            Win.SetActive(true);
            WinPanel.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
