using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public List<Transform> starTransforms;
    public float drawingTime = 1f;
    float StartTime = 0f;

    float elapedTime;

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

        elapedTime += Time.deltaTime;
        if (elapedTime > drawingTime)
        {
            elapedTime = 0;
        }
        else
        {
            float stepValue = elapedTime / drawingTime;

            Vector3 stepPosition = Vector3.Lerp(Star1Pos, Star2Pos, stepValue);

            StartTime = (StartTime + 1) % (drawingTime + 1);
            print(StartTime);

            Debug.DrawLine(Star1Pos, Star2Pos, Color.white);
            Debug.DrawLine(Star2Pos, Star3Pos, Color.white);
            Debug.DrawLine(Star3Pos, Star4Pos, Color.white);

        }


        //float HowLong = StartTime / drawingTime;

    

        
    }
}
