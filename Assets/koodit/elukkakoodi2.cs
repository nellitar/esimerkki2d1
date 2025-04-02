using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elukkakoodi2 : MonoBehaviour
{
   // Tällä säädetään nopeus
    private float nopeus = 12f;
    // Start alustukset, suoritetaan kerran
    void Start()
    {
        
    }

    // Update on pelisilmukka, jota suoritetaan jatkuvasti, sisältää toiminnallisuuden
    void Update()
    {
        // Liikutetaan elukkaa positiivisen x-akselin suuntaan
        this.GetComponent<Transform>().Translate(this.nopeus * Time.deltaTime, 0f, 0f);
        // Käännetään elukkaa kummassakin reunassa y-akseln ympäri 180-astetta
        if ((this.GetComponent<Transform>().position.x > 15f) ||
        (this.GetComponent<Transform>().position.x < -15f))
        {
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }
    }
}
