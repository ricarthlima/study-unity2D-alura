using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{

    public float impulseForce;
    Rigidbody2D fisica;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();

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
        this.fisica.AddForce(Vector2.up * impulseForce, ForceMode2D.Impulse);
    }
}
