using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreTrigger : MonoBehaviour
{
    public Logic logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.AddScore(1);
            logic.hScoreAdd();
            logic.setScore();
        }
        
    }
}
