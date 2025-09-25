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
    public float decelerationTime = 0f;

    private Vector3 velocity = Vector3.zero;

    [Header("Radar Properties")]//
    public float radarRadius = 1f;//
    public int numberOfPoints = 6;//

    void Start()
    {

    }

    void Update()
    {
        PlayerMovement();
        RadarScan(radarRadius,numberOfPoints);//
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

        float deceleration = maxSpeed * decelerationTime;

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            velocity = decelerationTime * Time.deltaTime * Vector3.left;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            velocity = decelerationTime * Time.deltaTime * Vector3.right;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            velocity = decelerationTime * Time.deltaTime * Vector3.up;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            velocity = decelerationTime * Time.deltaTime * Vector3.down;
        }
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        transform.position += velocity * Time.deltaTime;
    }

    private void RadarScan(float radius, int numberOfPoints)//
    {
        float angleStep = 360f / numberOfPoints;//
        float radians = angleStep * Mathf.Deg2Rad;//

        List<Vector3> points = new List<Vector3>();//

        for (int i = 0; i < numberOfPoints; i++)//
        {
            float adjustment = radians * i;//
            Vector3 point = new Vector3(Mathf.Cos(radians + adjustment), Mathf.Sin(radians + adjustment)) * radius;//

            points.Add(point);//

        }
        Vector3 center = transform.position;//
        for (int i = 0; i < points.Count - 1; i++)//
        {
            Debug.DrawLine(center + points[i], center + points[i + 1],Color.green);//
        }
        Debug.DrawLine(center + points[points.Count -1], center + points[0],Color.green);//
    }
}