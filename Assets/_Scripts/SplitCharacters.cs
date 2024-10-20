using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplitCharacters : MonoBehaviour
{
    public GameObject Bunny; //Hase
    public Animator animator; //Animator Pilz

    private bool canSplit = true; 
    public Collider2D Collider;
    private bool Split = false;
    private bool ShiftDown = false;
    void Update()
    {   
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            CheckForSplit();
        }
        ChangeLayer();
    }


    void CheckForSplit()
    {
        if (Input.GetButtonDown("SplitCharacters") && canSplit == true) //wenn noch zusammen und Taste gedrückt, Split
        {   
            canSplit = false;
            Split = true;
            SpawnBunny();
        }
        else if (Input.GetButtonDown("SplitCharacters") && canSplit == false) //wenn Split und Taste gedrückt, 1 sek merken
        {
            ShiftDown = true;
            StartCoroutine(saveSplit());
        }
    }

    void ChangeLayer() //wechselt Aussehen Pilz
    {
        if (Split == true) 
        {
            animator.SetLayerWeight(0, 1f);
            animator.SetLayerWeight(1, 0f);
        }
        else if (Split == false)
        {
            animator.SetLayerWeight(0, 0f);
            animator.SetLayerWeight(1, 1f);
        }
    }

    void OnTriggerStay2D(Collider2D other) //falls Hase und Pilz nahe und Shift gedrückt wird oder gerade wurde: destroy Hase
    {
        if (ShiftDown == true)
        {
            Destroy(other.gameObject);
            Split = false;
            StartCoroutine(waiter()); //lässt neuen split 1 sek lang nicht zu
            

        }

    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(1);
        canSplit = true;
    }
    IEnumerator saveSplit()
    {
        yield return new WaitForSeconds(1);
        ShiftDown = false;
    }
    
    void SpawnBunny() //Hase spawnen
    {
        Instantiate(Bunny, transform.position, transform.rotation);
    }


}