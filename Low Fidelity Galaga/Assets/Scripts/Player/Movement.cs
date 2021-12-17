using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    public float speed = 5.0f;

    Vector2 movementVector;
    
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + movementVector * speed * Time.fixedDeltaTime);
    }
}
