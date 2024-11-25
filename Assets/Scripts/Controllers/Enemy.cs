using UnityEngine;
using System.Collections.Generic;
using System.Collections;




public class Enemy : MonoBehaviour
{
    public Transform playerTransform;


    public void Update()
    {

        Vector3 enemySpeed = new Vector3(2f, 2f, 0f);
        Vector3 enemyTransform = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        //Enemy moving towards player
        Vector3 distanceFromPlayer = new Vector3(playerTransform.position.x - transform.position.x, playerTransform.position.y - transform.position.y, playerTransform.position.z - transform.position.z);

        enemyTransform.x = (distanceFromPlayer.x * enemySpeed.x);
        enemyTransform.y = (distanceFromPlayer.y * enemySpeed.y);
        transform.position = enemyTransform * Time.deltaTime;

    }
    


}
