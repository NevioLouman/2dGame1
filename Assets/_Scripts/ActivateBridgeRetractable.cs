using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBridgeRetractable : MonoBehaviour
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
    private void OnTriggerExit2D(Collider2D collision)
    {
        bridgeTiles.SetActive(false);
        buttonUp.SetActive(true);
        buttonDown.SetActive(false);

    }
}

