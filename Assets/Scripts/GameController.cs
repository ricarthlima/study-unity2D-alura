using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject imageGameObject;
    public GameObject aviao;
    public int points;

    public Text scoreText;

    private AudioSource audioScore;

    private void Awake()
    {
        this.audioScore = this.GetComponent<AudioSource>();
    }

    private void Update()
    {
        string text = "00000" + points.ToString();
        scoreText.text = text.Substring(text.Length - 5);
    }

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
        points = 0;
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

    public void GetPoint()
    {
        audioScore.Play();
        points++;
    }
}
