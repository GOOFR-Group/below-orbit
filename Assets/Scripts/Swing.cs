using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField]
    private float force = 1; // Speed of the swinging motion.

    private Rigidbody2D rigidBody2D;

    private bool actionLeft;
    private bool actionRight;
    private bool actionStop;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 direction = Vector2.zero;

        if (actionLeft)
        {
            direction = Vector2.left;
        }
        if (actionRight)
        {
            direction = Vector2.right;
        }

        rigidBody2D.AddForce(direction * force);

        if (actionStop)
        {
            rigidBody2D.linearVelocity = Vector2.zero;
        }
    }

    private void Update()
    {
        actionLeft = Input.GetKey(KeyCode.LeftArrow);
        actionRight = Input.GetKey(KeyCode.RightArrow);
        actionStop = Input.GetKey(KeyCode.Space);
    }
}
