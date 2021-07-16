using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    public GameObject obstaculoPrefab;
    public float timeToSpawn;


    void Start()
    {
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timeToSpawn);
        Vector3 pos = new Vector3(11, Random.Range(1.5f, -4f), 0);

        Instantiate(obstaculoPrefab, pos, Quaternion.identity);
        StartCoroutine("Spawn");
    }
}
