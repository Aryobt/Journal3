using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Radar : MonoBehaviour
{
    public Transform enemy;
    public float rotateSpeed = 60f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 directionToTarget = (enemy.position - transform.position).normalized;

      
    }
}
