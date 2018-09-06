using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Custom controller for the left movable particle
 **/
public class CustomCharacterController : MonoBehaviour
{ 
    //Object reference to opposite particle
    public GameObject oppositeParticle;

    //movement variable
    float distance = 10;

    //Lets you click and drag particle
    private void OnMouseDrag()
    {
        if(!this.GetComponent<Particle>().Dead())
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            this.transform.position = objPosition;
            oppositeParticle.transform.position = -objPosition;
        }
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
