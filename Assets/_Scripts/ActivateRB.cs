using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRB : MonoBehaviour
{
    public GameObject stone;
    //Reference zu Stein

    private void OnTriggerEnter2D() //wenn Collision
    {
        stone.GetComponent<Rigidbody2D>().isKinematic = false; //"Schwerkraft von Stein einschalten"
    }
}
