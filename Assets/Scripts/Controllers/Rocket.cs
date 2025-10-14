using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float RocketSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position += mousePosition * RocketSpeed * Time.deltaTime;
    }
}
