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
      //  Vector3 = new Vector3 Star1Pos(12, 5, 0);
        DrawConstellation();
    }
   public void DrawConstellation()
    {
       
       // Debug.DrawLine(StarPos , new Vector3 (16,1,0), Color.white);
    }
}
