using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour
{
    public GameObject gameController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidingObject = collision.gameObject;

        if (collidingObject.tag.Equals("Particle"))
        {
            gameController.GetComponent<GameController>().Death();
        }
        
        if(collidingObject.tag.Equals("Obstacle"))
        {
            Destroy(collidingObject);
        }
    }
}
