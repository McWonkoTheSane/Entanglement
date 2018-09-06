using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Object class for both particles
public class Particle : MonoBehaviour
{
    //Starting positions for both particles to snap back to on reset
    Vector3 basePositionLeft = new Vector3(-5f, 0, 0);
    Vector3 basePositionRight = new Vector3(5f, 0, 0);

    //movement lock out boolean
    bool dead = false;
	
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    /**
     * Resets the position of both particles after a short delay
     **/
    public IEnumerator ResetPosition()
    {
        if(this.gameObject.name.Contains("_left"))
        {
            this.transform.position = basePositionLeft;
            yield return new WaitForSeconds(0.5f);
            this.SetDead(false);
        }
        else
        {
            this.transform.position = basePositionRight;
            yield return new WaitForSeconds(0.5f);
            this.SetDead(false);
        }
    }

    //Returns if the particle is "dead"
    public bool Dead()
    {
        return dead;
    }

    //Sets the particles dead state
    public void SetDead(bool newDead)
    {
        dead = newDead;
    }
}
