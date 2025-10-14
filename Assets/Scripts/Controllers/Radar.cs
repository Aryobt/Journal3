using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Radar : MonoBehaviour
{
    public Transform enemy;
    public float rotateSpeed = 60f;
    public GameObject Player;//
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 directionToEnemy = (enemy.position - transform.position).normalized;

        float TopAngle = CaculateAngleFromVector(transform.up);
        float directionRadar = CaculateAngleFromVector(directionToEnemy);

        float deltaAngle = Mathf.DeltaAngle(TopAngle, directionRadar);
        float sign = Mathf.Sign(deltaAngle);

        float angleStep = rotateSpeed * sign * Time.deltaTime;

        transform.Rotate(0, 0, angleStep);

        float Alighn = Vector3.Dot(transform.up, directionToEnemy);
    }

    private float CaculateAngleFromVector(Vector2 vec)
    {
        return Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
    }
}
