using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudspawn : MonoBehaviour
{
    public GameObject cloud;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightoffset = 5;
    bool check;

    private void Start()
    {
        spawnrate += Random.Range(0.1f, 5f);
    }


    // Update is called once per frame
    void Update()
    {
        
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        if (BirdDeadCheck())
        {
            spawnrate *= 3;
        }
    }
    void spawnPipe()
    {
            float lowestpoint = transform.position.y - heightoffset;
            float highestpoint = transform.position.y + heightoffset;
            Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 1), transform.rotation);
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