using System.Collections;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed = 0.5f;
    public float maxX = 5f;
    public float minX = -5f;

    private Vector3 enemyPosition;

    private void Update()
    {
        enemyMovement();
        transform.position = Vector3.MoveTowards(transform.position, enemyPosition, Speed * Time.deltaTime);
    }

    public void enemyMovement()
    {
        {

        }
    }
}
