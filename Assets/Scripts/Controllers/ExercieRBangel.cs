using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float redAngleDegrees = 0;
    public float blueAngleDegrees = 0;

    public float radius = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 redVector = VectorFromDegAngle(redAngleDegrees);
        Vector2 blueVector = VectorFromDegAngle(blueAngleDegrees);

        Debug.DrawLine(Vector3.zero, redVector * radius,Color.red);
        Debug.DrawLine(Vector3.zero, blueVector * radius, Color.blue);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"<Color=yellow><size=16>{DotProduct(redVector, blueVector)}</size></Color>");
        }
    }

    public Vector2 VectorFromDegAngle(float angle)
    {
        float angleInRad = angle * Mathf.Rad2Deg;
        return new Vector2(Mathf.Cos(angleInRad), Mathf.Sin(angleInRad));
    }

    public float DotProduct(Vector2 a, Vector2 b)
    {
        return a.x * b.x + a.y * b.y;
    }
}
