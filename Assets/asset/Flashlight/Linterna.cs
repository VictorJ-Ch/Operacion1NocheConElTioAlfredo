using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light Luz;

    private void Start()
    {
        Luz.enabled = false;
    }

    private void Update()
    {
        Prende_Apaga();
    }

    void Prende_Apaga()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Luz.enabled == false)
            {
                Luz.enabled = true;
            }

            else if (Luz.enabled == true)
            {
                Luz.enabled = false;
            }
        }
    }
}
