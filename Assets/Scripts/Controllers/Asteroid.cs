using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;

public class Asteroid : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public float arrivalDistance = 1f;
    public float maxFloatDistance = 5f;

    private float asteroidPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AsteroidMovement();
    }
    public void AsteroidMovement()
    {
       // if (Input.GetKey(KeyCode.E))
       //{
       //     transform.position = Vector3.MoveTowards(transform.position, asteroidPos, moveSpeed * Time.deltaTime);
       // }
    }
}
