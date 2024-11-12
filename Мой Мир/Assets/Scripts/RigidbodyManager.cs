using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyManager : MonoBehaviour
{
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
    }

    public void OnCollisionEnter2D(Collider2D collision)
    {
        if (this.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.CompareTag("Letters"))
            {
                Rigidbodt2DOn();
                this.gameObject.tag = "Letters";
            }
        }

    }

    public void Rigidbodt2DOn()
    {
        this.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
        BreackerMode.breackerCount++;
    }
}
