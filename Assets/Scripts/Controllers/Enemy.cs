using System.Collections;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed = 0.5f;
    public float maxX = 10f;
    public float minX = -10f;

    private Vector3 enemyPosition;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, enemyPosition, Speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, enemyPosition) < 0.1f)
        {
            enemyMovement();
        }
    }

    public void enemyMovement()
    {
        {
            float randomX = Random.Range(minX, maxX);
            enemyPosition = new Vector3(randomX, transform.position.y);
        }
    }
}
