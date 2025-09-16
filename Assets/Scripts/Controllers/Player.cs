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
    //private Vector3 velocity = new Vector3(1, 0, 0);
    //private Vector3 velocity1 = new Vector3(0, 1, 0);
    public float accelerationTime = 1f;
    public float maxSpeed = 1.0f;

    private Vector3 velocity = Vector3.zero;
    
    void Update()
    {
        PlayerMovement();
       
    }
    private void PlayerMovement()
        {
        float accelaration = maxSpeed / accelerationTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity += accelerationTime * Time.deltaTime * Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity += accelerationTime * Time.deltaTime * Vector3.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity += accelerationTime * Time.deltaTime * Vector3.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity += accelerationTime * Time.deltaTime * Vector3.down;
        }
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        transform.position += velocity * Time.deltaTime;
    }

}