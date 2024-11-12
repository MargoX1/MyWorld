using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreackerMode : MonoBehaviour
{
    public static bool breackerModeOn;
    public static int breackerCount;
    public static int destroyingLetters;

    public GameObject diagManag;
    public GameObject m;
    public GameObject o;
    public GameObject r;

    float timer;

    void Start()
    {
        breackerModeOn = false;
        breackerCount = 0;
        destroyingLetters  = 0;
    }

    void Update()
    {
        if (breackerCount == 3)
        {
            timer += Time.deltaTime;
            if (timer > 20f)
            {
                m.GetComponent<Rigidbody2D>().isKinematic = false;
                o.GetComponent<Rigidbody2D>().isKinematic = false;
                r.GetComponent<Rigidbody2D>().isKinematic = false;
                breackerCount++;
                DialogueScript[] ds = diagManag.GetComponents<DialogueScript>();
                ds[3].DialogueOff();
                ds[4].DialogueOn();
            }

        }

        if (breackerCount == 4)
        {
            timer += Time.deltaTime;
            if (timer > 32f)
            {
                breackerModeOn = true;
            }
        }

        if (destroyingLetters == 6)
        {
            destroyingLetters++;
            breackerModeOn = false;
            DialogueScript[] ds = diagManag.GetComponents<DialogueScript>();
            ds[4].DialogueOff();
            ds[5].DialogueOn();

        }
    }

}
