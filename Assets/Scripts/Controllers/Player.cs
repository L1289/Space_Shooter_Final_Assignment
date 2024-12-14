using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

    public float accelerationTime = 1f;
    public float decelerationTime = 1f;
    public float maxSpeed = 7.5f;
    public float turnSpeed = 180f;

    private float acceleration;
    private float deceleration;
    private Vector3 currentVelocity;
    private float maxSpeedSqr;

    private void Start()
    {
        acceleration = maxSpeed / accelerationTime;
        deceleration = maxSpeed / decelerationTime;
        maxSpeedSqr = maxSpeed * maxSpeed;

    }

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            moveDirection += Vector3.up;
        if (Input.GetKey(KeyCode.S))
            moveDirection += Vector3.down;
        
        if (Input.GetKey(KeyCode.D))
            moveDirection += Vector3.right;
        if (Input.GetKey(KeyCode.A))
            moveDirection += Vector3.left;

        if (moveDirection.sqrMagnitude > 0)
        {
            currentVelocity += Time.deltaTime * acceleration * moveDirection;
            if (currentVelocity.sqrMagnitude > maxSpeedSqr)
            {
                currentVelocity = currentVelocity.normalized * maxSpeed;
            }
        }
        else
        {
            Vector3 velocityDelta = Time.deltaTime * deceleration * currentVelocity.normalized;
            if (velocityDelta.sqrMagnitude > currentVelocity.sqrMagnitude)
            {
                currentVelocity = Vector3.zero;
            }
            else
            {
                currentVelocity -= velocityDelta;
            }
        }

        //Calculates the distance between player and enemy
        Vector3 playerVector = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 enemyVector = new Vector3(enemyTransform.position.x, enemyTransform.position.y, enemyTransform.position.z);
        float distanceFromEnemy = Vector3.Distance(enemyVector, playerVector);
        
        //if distance between player and enemy is 2 or less will increase speed
        if (distanceFromEnemy >= 2)
        {
            maxSpeed = 12f;
            accelerationTime = 2f;
            decelerationTime = 2f;
        }

        //If distance is greater then 2 then will return speed to normal
        else
        {
            maxSpeed = 7.5f;
            accelerationTime = 1f;
            decelerationTime = 1f;
        }

        transform.position += currentVelocity * Time.deltaTime;
    }

}
