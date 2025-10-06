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
        Vector3 directionToTarget = (target.position - transform.forward).normalized;

        //float dot = Vector3.Dot(transform.up, directionToTarget);

        float directionAngle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;

        float upAngle = Mathf.Atan2(transform.up.y, transform.up.x) * Mathf.Rad2Deg;

        float deltaAngle = Mathf.DeltaAngle(upAngle, directionAngle);

        float sign = Mathf.Sign(deltaAngle);

        if (Mathf.Abs(deltaAngle) < 0.1f) return;

        transform.Rotate(0, 0, angularSpeed * Time.deltaTime * sign);

        Debug.Log($"<color=yellow><size=16>{deltaAngle}</size></color>.");

        Debug.DrawLine(transform.position, transform.position + transform.up, Color.green);

        Debug.DrawLine(transform.position, transform.position + directionToTarget, Color.magenta);
    }
}
