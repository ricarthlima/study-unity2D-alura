using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject imageGameObject;
    public GameObject aviao;

    public void EndGame()
    {
        Time.timeScale = 0;
        imageGameObject.SetActive(true);
    }

    public void ResetGame()
    {
        aviao.GetComponent<Aviao>().Reiniciar();
        imageGameObject.SetActive(false);
        this.DestroyObstacles();
        Time.timeScale = 1;
    }

    public void DestroyObstacles()
    {
        Obstaculo[] listObs = GameObject.FindObjectsOfType<Obstaculo>();
        foreach (Obstaculo obs in listObs)
        {
            Destroy(obs.gameObject);
        }
    }
}
