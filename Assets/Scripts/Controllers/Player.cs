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
    private Vector3 velocity = new Vector3(1, 0, 0);
    private Vector3 velocity1 = new Vector3(0, 1, 0);
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.position -= velocity;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.position += velocity;
        }
        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.position += velocity1;
        }
        if( Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform .position -= velocity1;
        }
    }

}