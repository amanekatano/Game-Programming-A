using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10.0f;
    bool isSpeedUped = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce((Vector2.right + Vector2.down) * speed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpeedUped == false && Time.time > 5.0f)
        {
            rb.velocity = rb.velocity * 2.0f;
            isSpeedUped = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Borderline"))
        {
            Destroy(gameObject);
        }
    }
}
