using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    bool isShacking = false;
    float shake = 0.2f;
    Vector2 pos;

    [SerializeField]
    int health = 5;

    [SerializeField]
    Object destructable;

    void Update()
    {
        if (isShacking == true)
        {
            transform.position = pos + UnityEngine.Random.insideUnitCircle * shake;
        }

    }

    private void OnMouseDown()
    {
        pos = transform.position;
        if (BreackerMode.breackerModeOn)
        {
            isShacking = true;
            health--;

            if(health <=0 )
            {
                ExplodeTheObject();
            }
            Invoke("StopShacking", 0.5f);
        }
    }

    void StopShacking ()
    {
        isShacking = false;
        transform.position = pos;
    }

    void ExplodeTheObject()
    {
        GameObject destruct = (GameObject)Instantiate(destructable);
        destruct.transform.position = transform.position;
        Destroy(gameObject);
        BreackerMode.destroyingLetters++;
    }
}
