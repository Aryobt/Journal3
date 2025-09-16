using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;
    [Header("Motion Properties")]
    public float moveSpeed = 1.0f;
    private Vector3 velocity = new Vector3(1, 0, 0);
    private Vector3 velocity1 = new Vector3(0, 1, 0);
    void Update()
    {
        PlayerMovement();
       
    }
    private void PlayerMovement()
        {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * moveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * moveSpeed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * moveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * moveSpeed;
        }
    }

}