using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGroupReference : MonoBehaviour
{
    public GameObject TargetGroup; //slot für TargetGroup-Objekt
    private void OnEnable()
    {
        TargetGroup = GameObject.FindGameObjectWithTag("TargetGroup"); //sobald gespawnt, finde Targetgroup
        TargetGroup.GetComponent<AddToTargetGroup>().FindBunny(); //rufe in Targetgroup FindBunny auf
    }

    private void OnDisable()
    {
        TargetGroup.GetComponent<AddToTargetGroup>().DestroyTarget(); //sobald destroyed, rufe in Targetgroup DestroyTarget auf
    }
}
