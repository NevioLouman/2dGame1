using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float HorizontalInput; //variable für input auf x-Achse
    private bool FacingRight = true;
    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal"); //variable = input auf x-Achse
        FlipAxis(); //fkt. ausführen
    }
    
    private void FlipAxis() //fkt. von oben
    {
        if (HorizontalInput < 0 && FacingRight || HorizontalInput > 0 && !FacingRight) //falls Character sich nach links bewegt aber nach rechts schaut und andersrum
        {
            FacingRight = !FacingRight; //True zu False, False zu True
            Vector3 playerScale = transform.localScale; //neuer Vektor gleich Scale von Objekt
            playerScale.x *= -1; //Vektor auf x-Achse umdrehen
            transform.localScale = playerScale; //alte Scale ändern zu neuer Scale
        }
    }
}
