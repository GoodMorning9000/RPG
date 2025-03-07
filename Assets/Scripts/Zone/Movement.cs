using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    public Vector2 direction; 
    public int moveSpeed;
    private Rigidbody2D playerRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerRigidBody.AddForce(direction * moveSpeed, ForceMode2D.Force);
    }

    public void MoveEvent(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Vector2 input = ctx.ReadValue<Vector2>();
            direction.x = input.x;
            direction.y = input.y;
        }
        else
        {
            direction = Vector2.zero;
        }
    }
}
