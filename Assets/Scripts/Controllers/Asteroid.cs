using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float moveSpeed;
    public float arrivalDistance;
    public float maxFloatDistance;
    public Transform playerTransform;

    /*
    // Start is called before the first frame update
    void Start()
    {
        vector3 asteroidTransform = new vector3(transform.postion.x, transform.postion.y, transform.postion.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distanceToPlayer = new Vector3(playerTransform.position.x - asteroidTransform.position.x, playerTransform.position.y - asteroidTransform.position.y, playerTransform.position.y - asteroidTransform.position.z);
    }
    */
}
