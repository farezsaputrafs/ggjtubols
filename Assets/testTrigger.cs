using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class testTrigger : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public P1orP2 p1OrP2 = P1orP2.P1; 
    public UnityEvent<Collider2D> TriggerEnter2DForwarded;
    public UnityEvent<Collider2D> TriggerExit2DForwarded;

    [SerializeField]
    private bool inputEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other){
        TriggerEnter2DForwarded?.Invoke(other);
        // if (p1OrP2 == P1orP2.P1){
        //     Debug.Log($"p1 got p2");
        //     if (other.CompareTag("Player 2")){
        //         inputEnabled = false;
        //         rb2d.velocity = -rb2d.velocity * 3f;
        //     }
        // }
        // if (p1OrP2 == P1orP2.P2){
        //     Debug.Log($"p2 got p1");
        //     if (other.CompareTag("Player")){
        //         inputEnabled = false;
        //         rb2d.velocity = -rb2d.velocity * 3f;
        //     }
        // }
    }

    public void OnTriggerExit2D(Collider2D other){
        TriggerExit2DForwarded?.Invoke(other);
        // if (p1OrP2 == P1orP2.P1)
        //     if (other.CompareTag("Player 2"))
        //         inputEnabled = true;
        // if (p1OrP2 == P1orP2.P2)
        //     if (other.CompareTag("Player"))
        //         inputEnabled = true;
    }

}
