using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float speedMultiplier;
    public P1orP2 p1RrP2 = P1orP2.P1;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (p1RrP2 == P1orP2.P1){
            if (Input.GetKey(KeyCode.A))
                rb2d.AddForce(Vector2.left * speedMultiplier);
            if (Input.GetKey(KeyCode.D))
                rb2d.AddForce(Vector2.right * speedMultiplier);
            if (Input.GetKey(KeyCode.W))
                rb2d.AddForce(Vector2.up * speedMultiplier);
            if (Input.GetKey(KeyCode.S))
                rb2d.AddForce(Vector2.down * speedMultiplier);
        }
        else {
            if (Input.GetKey(KeyCode.J))
                rb2d.AddForce(Vector2.left * speedMultiplier);
            if (Input.GetKey(KeyCode.L))
                rb2d.AddForce(Vector2.right * speedMultiplier);
            if (Input.GetKey(KeyCode.I))
                rb2d.AddForce(Vector2.up * speedMultiplier);
            if (Input.GetKey(KeyCode.K))
                rb2d.AddForce(Vector2.down * speedMultiplier);
        }
    }
}
public enum P1orP2{
    P1, P2
}
