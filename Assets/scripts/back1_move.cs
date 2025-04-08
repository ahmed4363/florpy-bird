using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back1_move : MonoBehaviour
{
    public float movespeed = 1;
    public bool check;
    void Update()
    {
        transform.position += Vector3.left * movespeed * Time.deltaTime;
        if (transform.position.x <= -10.27)
        {
            transform.position = new Vector3(0, 0, 0);
        }
        if (BirdDeadCheck())
        {
            movespeed = 0;
        }
    }
    bool BirdDeadCheck()
    {
        if (BirdScript.instance != null)
        {
            if (!BirdScript.instance.alive && !check)
            {
                check = true;
                return true;
            }
            else return false;
        }
        return false;
    }
}
