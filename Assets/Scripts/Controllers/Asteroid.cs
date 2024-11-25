using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float moveSpeed;
    public float arrivalDistance;
    public float maxFloatDistance;
    public Transform playerTransform;


    public void Update()
    {

        //AsteroidSpeed Vector
        Vector3 asteroidSpeed = new Vector3(0.1f, 0.1f, 0f);

        //Getting Asteroid Transform
        Vector3 asteroidTransform = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        //Calculating Distance From Player To Asteroid
        Vector3 distanceFromPlayer = new Vector3(playerTransform.position.x - transform.position.x, playerTransform.position.y - transform.position.y, playerTransform.position.z - transform.position.z);

        //Updating the x and y postion of the Asteroid transform based off the distance between player and Asteroid, and how much speed Asteroid has
        asteroidTransform.x = ((distanceFromPlayer.x * asteroidSpeed.x) * Time.deltaTime);
        asteroidTransform.y = ((distanceFromPlayer.y * asteroidSpeed.y) * Time.deltaTime);
        

        //Updating the transform
        transform.position = asteroidTransform;

    }

}
