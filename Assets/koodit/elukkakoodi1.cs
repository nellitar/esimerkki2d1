using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehaviour periytetään meidän koodiolio elukkakoodi1
public class elukkakoodi1 : MonoBehaviour
{
    // Tällä säädetään nopeus
    private float nopeus = 4f;
    // Suunnan seuraaminen (1 = oikealle, 2 = vasemmalle)
    private int suunta = 1;
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

        // Pelaaja voi liikuttaa elukkaa vasemmalle tai oikealle nuolinäppäimillä
        if (Input.GetKeyDown(KeyCode.RightArrow) && (this.suunta != 1))
        {
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
            this.suunta = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (this.suunta != 2))
        {
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
            this.suunta = 2;
        }

        this.GetComponent<Transform>().Translate(this.nopeus * Time.deltaTime, 0f, 0f);
    }
}
