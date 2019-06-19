using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;

    float speed = 10f;

    Rigidbody2D rgb2d;

    // Start is called before the first frame update
    void Start() {
        rgb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(moveUp)) {
            rgb2d.velocity = new Vector2(0, speed);
        } else if (Input.GetKey(moveDown)) {
            rgb2d.velocity = new Vector2(0, -speed);
        } else {
            rgb2d.velocity = new Vector2(0, 0);
        }

    }
}
