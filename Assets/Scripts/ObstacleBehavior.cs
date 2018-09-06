using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Wall/divider behavior
public class ObstacleBehavior : MonoBehaviour
{
    public GameObject gameController;

	// Use this for initialization
	void Start ()
    {
        gameController = GameObject.FindObjectOfType<GameController>().gameObject;
	}

    // Update is called once per frame
    void Update()
    {

    }

    //Collsion physics
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidingObject = collision.gameObject;

        if(collidingObject.tag.Equals("Particle"))
        {
            gameController.GetComponent<GameController>().Death();
        }
    }
}
