using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Rigidbody2D rb;
    float moveSpeed = 12.5f;
    public Material blue;
    public Material greed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed,0);

        Vector2 force = new Vector2(0, 6500.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(force);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
        }
    }
}
