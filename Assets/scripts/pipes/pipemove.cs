using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemove : MonoBehaviour
{
      public float movespeed = 10;
      public float deadZone = -20;
      public BirdScript BScript;
    public Logic logic;
    // Start is called before the first frame update
    void Start()
    {
        BScript = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.score > 3 & logic.score < 2000 & logic.PipeIncreaseSpeed)
        {
            movespeed += 0.001f;
        }
        if (BScript.alive == true)
        {
            transform.position = transform.position + Vector3.left * movespeed * Time.deltaTime;
        }
        
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
