using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using UnityEngine;

public class PLAYERBONUSMALUS : MonoBehaviour
{
    Timer timer = new Timer();
    public float pointDeVie = 100;
    public bool isSpeed = false;
    public float vitesseDeDéplacement = 1;
    public float dommage = 10;
    public float secondesQuiPassent;
    private int temps = 1;
    public void OnTriggerEnter(Collider other)
    {

        if (other.name.StartsWith("BuBo")) 
        {
             //BURGER BONUS
             pointDeVie += pointDeVie*25/100;
             if (pointDeVie > 100)
             {
                 pointDeVie = 100;
             }
        }

        if (other.name.StartsWith("BuMa"))
        {
            //BURGER MALUS
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(BurgerMalus);
            timer.Interval = 1000;
            timer.Enabled = true;
        }

        if (other.name.StartsWith("TB"))
        {
            //TONGUE BONUS
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(tongueBonus);
            timer.Interval = 10000;
            timer.Enabled = true;
            vitesseDeDéplacement += 0.5f;
        }

        if (other.name.StartsWith("TM"))
        {
            //TONGUE MALUS
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(tongueMalus);
            timer.Interval = 10000;
            timer.Enabled = true;
            vitesseDeDéplacement -= 0.5f;
        }

        if (other.name.StartsWith("BB"))
        {
            //BINOUZE BONUS
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(BinouzeBonus);
            timer.Interval = 10000;
            timer.Enabled = true;
            dommage += 5;
        }

        if (other.name.StartsWith("BM"))
        {
            //BINOUZE MALUS
            pointDeVie -= 30;
        }
    } 

    private void Update()
    {
        secondesQuiPassent += Time.deltaTime;
    }

    private void tongueBonus(object source, ElapsedEventArgs e)
    {
        vitesseDeDéplacement -= 0.5f;
        timer.Enabled = false;
    }
    private void tongueMalus(object source, ElapsedEventArgs e)
    {
        vitesseDeDéplacement += 0.5f;
        timer.Enabled = false;
    }

    private void BinouzeBonus(object source, ElapsedEventArgs e)
    {
        dommage -= 5;
        timer.Enabled = false;
    }

    private void BurgerMalus(object source, ElapsedEventArgs e)
    {
        pointDeVie -= 5;
        temps += 1;
        if (temps == 10)
        {
            timer.Enabled = false;
            temps = 1;
        }

    }
}
