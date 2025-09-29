using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform planetTransform;

    public float orbitalSpeed;
    public float radius;

    private float angle;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        angle += orbitalSpeed * Time.deltaTime;
        //transform.Rotate(new Vector3(0, 0, orbitalSpeed) * Time.deltaTime);
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;

       
        transform.position = planetTransform.position + new Vector3(x, 0, z);
        
    }
   // public void OrbitalMotion(float radius, int MoonPoints)
   // {
      //  float angleStep = 360f;
      //  float radians = angleStep * Mathf.Deg2Rad;
      //  List<Vector3> points = new List<Vector3>();

      //  for (int i = 0; i < MoonPoints; i++)
      //  {
       //     float adjustment = radians * i;
       //     Vector3 point = new Vector3(Mathf.Cos(radians + adjustment), Mathf.Sin(radians + adjustment)) * radius;

      //      points.Add(point);

      //  }
      //  Vector3 center = transform.position;
   // }
}
