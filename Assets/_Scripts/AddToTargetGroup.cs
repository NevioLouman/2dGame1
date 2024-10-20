using UnityEngine;
using Cinemachine;

public class AddToTargetGroup : MonoBehaviour
{
    public Transform transformHase; //slot für Transform von Hase
    public float weight; //gewichtung von neuem Objekt in TargetGroup
    public float radius; //Radius von neuem Objekt in TargetGroup

    public void FindBunny() //wird von TargetgroupReference aufgerufen, sobald aktiv
    {
        transformHase = GameObject.FindGameObjectWithTag("Hase").transform; //finde Hase transform
        CinemachineTargetGroup targetGroup = GetComponent<CinemachineTargetGroup>(); //finde Komponent für Targetgroupobjekte
        targetGroup.AddMember(transformHase, weight, radius); //neues Objekt in Liste
    }
    public void DestroyTarget() //wird von TargetgroupReference aufgerufen, sobald destroyed
    {
        transformHase = GameObject.FindGameObjectWithTag("Hase").transform; //finde Hase transform
        CinemachineTargetGroup targetGroup = GetComponent<CinemachineTargetGroup>(); //finde Komponent für Targetgroupobjekte
        targetGroup.RemoveMember(transformHase); //lösche Objekt in Liste
    }

}
