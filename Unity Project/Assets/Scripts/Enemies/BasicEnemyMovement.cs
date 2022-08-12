using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour
{
    private Vector3 destinationPoint;
    private Rigidbody2D rb;
    public float movementSpeed = 0.5f;
    public float maxVelocity = 3f;
    // Start is called before the first frame update
    void Start()
    {
        RandomDestination();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveToDestination();

        Vector3.ClampMagnitude(rb.velocity, maxVelocity);

        if (rb.velocity.magnitude < 1)
            RandomDestination();
    }

    void MoveToDestination()
    {
        Vector3 moveDirection = destinationPoint - this.transform.position;
        Vector3.Normalize(moveDirection);
        rb.velocity = moveDirection* movementSpeed;
    }

    void RandomDestination()
    {
        destinationPoint.x = Random.Range(-12, 12);
        destinationPoint.y = Random.Range(-5, 5);
    }
}
