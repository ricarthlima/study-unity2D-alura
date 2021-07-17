using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    void Start()
    {
        Hide();
    }

    public void Hide()
    {
        StartCoroutine("SelfHide");
    }

    IEnumerator SelfHide()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }
}
