using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light Luz;

    public float Pila;
    public float PilaRestante;
    float PilaMax;
    public float PotenciaMin;

    private void Start()
    {
        Luz.enabled = false;
        PilaRestante = Pila;
        PilaMax = Pila;
    }

    private void Update()
    {
        Prende_Apaga();

        if (PilaRestante <= 0)
        {
            Luz.enabled = false;
        }

        if (Luz.enabled == true && PilaRestante >= 0)
        {
            PilaRestante -= Time.deltaTime;
        }
        else if(Luz.enabled == false && PilaRestante <= PilaMax)
        {
            PilaRestante += Time.deltaTime;
        }
    }

    void Prende_Apaga()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Luz.enabled == false && PilaRestante >= PotenciaMin)
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