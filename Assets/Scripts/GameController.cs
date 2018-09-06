using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Overall controller for all game states and actions
public class GameController : MonoBehaviour
{
    //Refernces to the two playable objects
    public GameObject particle_left;
    public GameObject particle_right;

    private float obstaceResetTimer = 2.0f;

    private bool resetMode = false;

    private float timeSurvived = 0.0f;

    //[SerializeField] private List<GameObject> spawners;

    public GameObject obstacleSpawner;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if(resetMode)
        {
            Debug.Log(timeSurvived);
            if (obstaceResetTimer <= 0)
            {
                resetMode = false;
                obstacleSpawner.gameObject.SetActive(true);
                obstaceResetTimer = 2.0f;
            }
            else
            {
                obstaceResetTimer -= Time.deltaTime;
            }
        }
        else
        {
            timeSurvived += Time.deltaTime;
        }
	}

    //Loss state, change to display restart button and time survived
    public void Death()
    {
        ResetPlayField();
        ResetGameSystems();
        resetMode = true;
    }

    //Implement with button on fail state
    private void Restart()
    {

    }

    private void ResetGameSystems()
    {

        obstacleSpawner.gameObject.SetActive(false);
    }


    private void ResetPlayField()
    {
        particle_left.GetComponent<Particle>().SetDead(true);
        particle_right.GetComponent<Particle>().SetDead(true);

        StartCoroutine(particle_left.GetComponent<Particle>().ResetPosition());
        StartCoroutine(particle_right.GetComponent<Particle>().ResetPosition());
    }
}
