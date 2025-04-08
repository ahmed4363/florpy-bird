using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
     public GameObject pipe;
     public float spawnrate = 3;
     private float timer = 0;
     public float heightoffset = 10;
    public BirdScript logic;
    public Logic logics;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
        logics = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (logics.score > 3 & logics.score < 2000 & logics.PipeIncreaseSpeed)
        {
            spawnrate -= 0.0001f;
        }
        if(timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
             timer = 0;
        }
    }
    void spawnPipe()
    {
        if (logic.alive == true)
        { 
            float lowestpoint = transform.position.y - heightoffset;
            float highestpoint = transform.position.y + heightoffset;
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
        }
    }
}
