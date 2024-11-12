using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParts : MonoBehaviour
{
    [SerializeField]
    Vector2 forcedir;

    [SerializeField]
    int spin;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(forcedir);
        rb.AddTorque(spin);
    }

}
