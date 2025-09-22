using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public List<Transform> starTransforms;
    public float drawingTime = 0.5f;
    float StartTime = 0f;
    


    // Update is called once per frame
    void Update()
    {
     
        DrawConstellation();

       

    }
   public void DrawConstellation()
    {
        
        Vector3 Star1Pos = new Vector3(12, 5, 0);
        Vector3 Star2Pos = new Vector3(16, 1, 0);
        Vector3 Star3Pos = new Vector3(12, -1, 0);
        Vector3 Star4Pos = new Vector3(16, -4, 0);

        float HowLong = StartTime / drawingTime;

        Vector3 Star1To2 = Vector3.Lerp(Star1Pos, Star2Pos, HowLong);

        StartTime = (StartTime + 1) % (drawingTime + 1);

        Debug.DrawLine(Star1Pos,Star2Pos,Color.white);
    }
}
