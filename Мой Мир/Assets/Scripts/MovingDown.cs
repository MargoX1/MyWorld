using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDown : MonoBehaviour
{
    public GameObject gameobj;
    public GameObject bug;
    Vector2 pos;
    float timer;
    bool isMovingDown;

    void Update()
    {
        if (isMovingDown)
        {
            timer += Time.deltaTime;
            if (timer > 20f)
            {
                ReturnLetter();
            }
        }

    }

    public void OnMovingDown()
    {
        pos = gameobj.transform.position;
        gameobj.transform.position = pos + new Vector2(-3f, -2f);
        isMovingDown = true;

    }

    public void ReturnLetter()
    {
        gameobj.transform.position = pos;
        bug.SetActive(true);
        isMovingDown = false;
    }
}
