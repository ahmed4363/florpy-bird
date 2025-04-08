using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public static BirdScript instance;
    public Rigidbody2D myRigidbody;
    public float Force;
    public Logic logic;
    public bool alive = true;
    public AudioSource SFX;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive == true)
        {
          myRigidbody.velocity = Vector2.up * Force;
        }
        if (Input.touchCount == 1 && alive == true)
        {
            myRigidbody.velocity = Vector2.up * Force;
        }
        if (transform.position.y > 5 || transform.position.y < -5)
        {
            logic.gameOver();
            alive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        alive = false;
    }
}
