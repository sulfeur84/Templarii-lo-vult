using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public static int Vie = 100;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ennemy"))
        {
            slider.value = Vie;
        }
    }

    public void Update()
    {
        if (Vie <= 0) Destroy(gameObject);
    }
}
