using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacales : MonoBehaviour
{
    public float minSize = 0.1f;
    public float maxSize = 0.5f;
    public float minSpeed = 50f;
    public float maxSpeed = 150f;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);
        

        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        Vector2 randomDirection = Random.insideUnitCircle;

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(randomDirection * randomSpeed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
