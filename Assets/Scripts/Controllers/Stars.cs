using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public List<Transform> starTransforms;
    public float drawingTime;
    


    // Update is called once per frame
    void Update()
    {
     
        DrawConstellation();

        Vector3 Star1Pos = new Vector3(12, 5, 0);
        Vector3 Star2Pos = new Vector3(16, 1, 0);
        Vector3 Star3Pos = new Vector3(12,-1,0);
        Vector3 Star4Pos = new Vector3(16,-4,0);

        Debug.DrawLine(Star1Pos, Star2Pos, Color.white);
        Debug.DrawLine(Star2Pos, Star3Pos, Color.white);
        Debug.DrawLine(Star3Pos, Star4Pos, Color.white);

    }
   public void DrawConstellation()
    {
       
    }
}
