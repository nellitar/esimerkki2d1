using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopetuskoodi : MonoBehaviour
{
    // Esc-näppäimellä suljetaan ohjelma
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
