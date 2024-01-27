using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public BombSystem bombSystem;
    public Rigidbody2D rb2d;
    public Rigidbody2D[] rigidbody2Ds;
    public float speedMultiplier;
    public float bouncebackMultiplier = 10f;
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

    public void Z_ForwardedOnTriggerEnter2D(Collider2D other){
        if (p1OrP2 == P1orP2.P1){
            if (other.CompareTag("Player 2 Col")){
                // Debug.Log($"p1 got p2");
                inputEnabled = false;
                rb2d.velocity = -rb2d.velocity * bouncebackMultiplier;
                // other.GetComponentInParent<BasicMovement>().rb2d.velocity = rb2d.velocity;
                // other.attachedRigidbody.velocity = rb2d.velocity;

                if (bombSystem.whoHasTheBomb == WhoHasTheBomb.P1HasTheBomb){
                    bombSystem.whoHasTheBomb = WhoHasTheBomb.P2HasTheBomb;
                }
                else {
                    Debug.Log($"asdfg");
                    bombSystem.whoHasTheBomb = WhoHasTheBomb.P1HasTheBomb;
                }
                // other.GetComponent<BasicMovement>().rb2d.velocity = rb2d.velocity;
            }
        }
        if (p1OrP2 == P1orP2.P2){
            if (other.CompareTag("Player Col")){
                // Debug.Log($"p2 got p1");
                inputEnabled = false;
                rb2d.velocity = -rb2d.velocity * bouncebackMultiplier;
                // other.GetComponentInParent<BasicMovement>().rb2d.velocity = rb2d.velocity;
                // other.transform.GetComponent<Rigidbody2D>().velocity = rb2d.velocity;

                // if (bombSystem.whoHasTheBomb == WhoHasTheBomb.P2HasTheBomb){
                //     Debug.Log($"asdfg");
                //     bombSystem.whoHasTheBomb = WhoHasTheBomb.P1HasTheBomb;
                // }
                // other.GetComponent<BasicMovement>().rb2d.velocity = rb2d.velocity;
            }
        }

        // if (p1OrP2 == P1orP2.P1){
        //     if (other.CompareTag("Player 2 Col")){
                
        //     }
        // }
        // else {
        //     if (other.CompareTag("Player Col")){
                
        //     }
        // }
    }
    public void Z_ForwardedOnTriggerExit2D(Collider2D other){
        if (p1OrP2 == P1orP2.P1)
            if (other.CompareTag("Player 2 Col")){
                // Debug.Log($"p1 left p2");
                inputEnabled = true;
            }
        if (p1OrP2 == P1orP2.P2)
            if (other.CompareTag("Player Col")){
                // Debug.Log($"p2 left p1");
                inputEnabled = true;
            }

    }
    // private void OnTriggerEnter2D(Collider2D other){
    //     if (p1OrP2 == P1orP2.P1){
    //         Debug.Log($"p1 got p2");
    //         if (other.CompareTag("Player 2 Col") && canDetectTrigger){
    //             inputEnabled = false;
    //             rb2d.velocity = -rb2d.velocity * 3f;
    //             canDetectTrigger = false;
    //         }
    //     }
    //     if (p1OrP2 == P1orP2.P2){
    //         Debug.Log($"p2 got p1");
    //         if (other.CompareTag("Player Col") && canDetectTrigger){
    //             inputEnabled = false;
    //             rb2d.velocity = -rb2d.velocity * 3f;
    //             canDetectTrigger = false;
    //         }
    //     }
    // }

    // private void OnTriggerExit2D(Collider2D other){
    //     if (p1OrP2 == P1orP2.P1)
    //         if (other.CompareTag("Player 2 Col") && !canDetectTrigger){
    //             inputEnabled = true;
    //             Debug.Log($"p1 exiting p2");
    //             canDetectTrigger = true;
    //         }
    //     if (p1OrP2 == P1orP2.P2)
    //         if (other.CompareTag("Player Col") && !canDetectTrigger){
    //             inputEnabled = true;
    //             Debug.Log($"p2 exiting p1");
    //             canDetectTrigger = true;
    //         }
    // }
}

public enum P1orP2{
    P1, P2
}
