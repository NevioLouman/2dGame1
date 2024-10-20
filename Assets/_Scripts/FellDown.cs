using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//braucht Packet für Szenenwechsel

public class FellDown : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) //wenn etwas in Trigger kommt
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex)); //lade jetzige Szene neu
    }
}
