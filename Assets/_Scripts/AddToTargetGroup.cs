using UnityEngine;
using Cinemachine;

public class AddToTargetGroup : MonoBehaviour
{
    public Transform transformHase; //slot f�r Transform von Hase
    public float weight; //gewichtung von neuem Objekt in TargetGroup
    public float radius; //Radius von neuem Objekt in TargetGroup

    public void FindBunny() //wird von TargetgroupReference aufgerufen, sobald aktiv
    {
        transformHase = GameObject.FindGameObjectWithTag("Hase").transform; //finde Hase transform
        CinemachineTargetGroup targetGroup = GetComponent<CinemachineTargetGroup>(); //finde Komponent f�r Targetgroupobjekte
        targetGroup.AddMember(transformHase, weight, radius); //neues Objekt in Liste
    }
    public void DestroyTarget() //wird von TargetgroupReference aufgerufen, sobald destroyed
    {
        transformHase = GameObject.FindGameObjectWithTag("Hase").transform; //finde Hase transform
        CinemachineTargetGroup targetGroup = GetComponent<CinemachineTargetGroup>(); //finde Komponent f�r Targetgroupobjekte
        targetGroup.RemoveMember(transformHase); //l�sche Objekt in Liste
    }

}
