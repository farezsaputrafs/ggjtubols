using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Rigidbody2D[] rigidbody2Ds;
    public float speedMultiplier;
    public P1orP2 p1OrP2 = P1orP2.P1;

    [SerializeField]
    private bool inputEnabled = true;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        DetectInputAndAddForcev1();

    }
    private void DetectInputAndAddForcev2(){
        if (p1OrP2 == P1orP2.P1){
            if (inputEnabled){
                foreach (Rigidbody2D item in rigidbody2Ds){
                if (Input.GetKey(KeyCode.A))
                    item.AddForce(Vector2.left * speedMultiplier);
                if (Input.GetKey(KeyCode.D))
                    item.AddForce(Vector2.right * speedMultiplier);
                if (Input.GetKey(KeyCode.W))
                    item.AddForce(Vector2.up * speedMultiplier);
                if (Input.GetKey(KeyCode.S))
                    item.AddForce(Vector2.down * speedMultiplier);
                }
            }
        }
        else{
            if (inputEnabled){
                
            }
        }
    }
    private void DetectInputAndAddForcev1(){
        if (p1OrP2 == P1orP2.P1){
            if (inputEnabled){
                if (Input.GetKey(KeyCode.A))
                    rb2d.AddForce(Vector2.left * speedMultiplier);
                if (Input.GetKey(KeyCode.D))
                    rb2d.AddForce(Vector2.right * speedMultiplier);
                if (Input.GetKey(KeyCode.W))
                    rb2d.AddForce(Vector2.up * speedMultiplier);
                if (Input.GetKey(KeyCode.S))
                    rb2d.AddForce(Vector2.down * speedMultiplier);
            }
        }
        else {
            if (inputEnabled){
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

    private void OnTriggerEnter2D(Collider2D other){
        if (p1OrP2 == P1orP2.P1){
            Debug.Log($"p1 got p2");
            if (other.CompareTag("Player 2")){
                inputEnabled = false;
                rb2d.velocity = -rb2d.velocity * 3f;
            }
        }
        if (p1OrP2 == P1orP2.P2){
            Debug.Log($"p2 got p1");
            if (other.CompareTag("Player")){
                inputEnabled = false;
                rb2d.velocity = -rb2d.velocity * 3f;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other){
        if (p1OrP2 == P1orP2.P1)
            if (other.CompareTag("Player 2")){
                inputEnabled = true;
                Debug.Log($"p1 exiting p2");
            }
        if (p1OrP2 == P1orP2.P2)
            if (other.CompareTag("Player")){
                inputEnabled = true;
                Debug.Log($"p2 exiting p1");
            }
    }
}

public enum P1orP2{
    P1, P2
}
