using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;

    private readonly float MAX_SPEED_X = 120f;
    private readonly float MAX_SPEED_Y = 120f;

    // Start is called before the first frame update
    IEnumerator Start() {
        yield return new WaitForSeconds(2f);
        GoBall();
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Player") {

            float yRandomizer = Random.Range(-8.0f, 8.0f);
            float xRandomizer = Random.Range(-.5f, 3.0f);

            rb.velocity = new Vector2(xRandomizer + rb.velocity.x, yRandomizer + rb.velocity.y / 2 + collision.collider.GetComponent<Rigidbody2D>().velocity.y / 3);
            if (rb.velocity.x > MAX_SPEED_X) {
                rb.velocity = new Vector2(MAX_SPEED_X, rb.velocity.y);
            }
            if (rb.velocity.y > MAX_SPEED_Y) {
                rb.velocity = new Vector2(rb.velocity.x, MAX_SPEED_Y);
            }
        }
    }

    IEnumerator ResetBall() {
        rb.position = new Vector2(0f, 0f);
        rb.velocity = new Vector2(0f, 0f);

        yield return new WaitForSeconds(1f);

        GoBall();
    }

    void GoBall() {
        speed = 70f;
        if (Random.Range(0.0f, 1.0f) < 0.5f) {
            rb.AddForce(new Vector2(speed, 10.0f));
        } else {
            rb.AddForce(new Vector2(-speed, -10.0f));
        }
    }
}
