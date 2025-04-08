using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudmove : MonoBehaviour
{
    public float movespeed = 1f;
    public bool check;

    private void Start()
    {
        movespeed += Random.Range(-0.5f, 0.5f);
    }
    void Update()
    {
        transform.position += Vector3.left * movespeed * Time.deltaTime;
        if (transform.position.x < -11.5)
        {
            Destroy(gameObject);
        }
        if(BirdDeadCheck())
        {
            movespeed /= 3;
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
