using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBridge : MonoBehaviour
{
    public GameObject bridgeTiles;
    public GameObject buttonUp;
    public GameObject buttonDown;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bridgeTiles.SetActive(true);
        buttonUp.SetActive(false);
        buttonDown.SetActive(true);

    }
}
