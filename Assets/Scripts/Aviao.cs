using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{

    public float impulseForce;
    Rigidbody2D fisica;
    GameController gameController;
    Vector3 initialPos;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        gameController = GameObject.FindObjectOfType<GameController>();
        initialPos = transform.position;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Impulsionar();
        }

    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * impulseForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.fisica.simulated = false;
        this.gameController.EndGame();
    }

    public void Reiniciar()
    {
        transform.position = initialPos;
        this.fisica.simulated = true;
    }
}
