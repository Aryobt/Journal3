using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;
    public float angularSpeed = 180f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 directionToTarget = (target.position - transform.position).normalized;

        float upAngle = CaculateDegAngleFromVector(transform.up);
        float directionAngle = CaculateDegAngleFromVector(directionToTarget);

        float deltaAngle = Mathf.DeltaAngle(upAngle, directionAngle);
        float sign = Mathf.Sign(deltaAngle);

        float angleStep = angularSpeed * sign * Time.deltaTime;

        transform.Rotate(0, 0, angleStep);

        if (Mathf.Abs(angleStep) < (deltaAngle))
        transform.Rotate(0, 0, angleStep);
        else
            transform.Rotate(0,0,deltaAngle);

            float dot = Vector3.Dot(transform.up, directionToTarget);

        Debug.Log($"<color=yellow><size=16>{deltaAngle}</size></color>.");

        Debug.DrawLine(transform.position, transform.position + transform.up, Color.green);

        Debug.DrawLine(transform.position, transform.position + (Vector3) directionToTarget, Color.magenta);
    }

    private float CaculateDegAngleFromVector(Vector2 vec)
    {
        return Mathf.Atan2(vec.y,vec.x) * Mathf.Rad2Deg;
    }
}
