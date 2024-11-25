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

        //EnemySpeed Vector
        Vector3 enemySpeed = new Vector3(0.1f, 0.1f, 0f);

        //Getting Enemy Transform
        Vector3 enemyTransform = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        //Calculating Distance From Player To Enemy
        Vector3 distanceFromPlayer = new Vector3(playerTransform.position.x - transform.position.x, playerTransform.position.y - transform.position.y, playerTransform.position.z - transform.position.z);
        distanceFromPlayer = distanceFromPlayer.normalized;

        //Updating the x and y postion of the enemy transform based off the distance between player and enemy and speed
        enemyTransform.x = ((distanceFromPlayer.x * enemySpeed.x) * Time.deltaTime);
        enemyTransform.y = ((distanceFromPlayer.y * enemySpeed.y) * Time.deltaTime);

        //Updating the transform
        transform.position = enemyTransform;

    }

}
