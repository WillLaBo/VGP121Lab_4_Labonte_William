using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Projectile : MonoBehaviour
{
    public float lifetime;

    [HideInInspector]
    public float xVel;
    [HideInInspector]
    public float yVel;

    private Rigidbody2D rb;

    void Start()
    {
        if (lifetime <= 0)
            lifetime = 2.0f;

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(xVel, yVel);
        Destroy(gameObject, lifetime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}