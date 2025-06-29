using UnityEngine;

public class Tether : MonoBehaviour
{
    [SerializeField]
    private float mass;

    private void Start()
    {
        Rigidbody2D[] rigidBodies = GetComponentsInChildren<Rigidbody2D>();

        foreach (var rb in rigidBodies)
        {
            rb.mass = mass;
        }
    }
}
