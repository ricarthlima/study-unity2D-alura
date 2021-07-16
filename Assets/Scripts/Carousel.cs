using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carousel : MonoBehaviour
{
    public float speed;

    Vector3 initialPos;
    float size;

    private void Awake()
    {
        this.initialPos = this.transform.position;
        this.size = this.GetComponent<SpriteRenderer>().size.x * this.transform.localScale.x;
    }

    private void Update()
    {
        float moved = Mathf.Repeat(this.speed * Time.time, this.size); // Tempo desde o começo do jogo
        this.transform.position = this.initialPos + (Vector3.left * moved);
    }
}
