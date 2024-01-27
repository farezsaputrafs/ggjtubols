using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSystem : MonoBehaviour
{
    public GameManager gameManager;
    public WhoHasTheBomb whoHasTheBomb;
    public GameObject player1ColTrigger;
    public GameObject player2ColTrigger;
    public Vector2 bombPositionOffset;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        Debug.Log($"WHOHASTHE BOMB: " + whoHasTheBomb);
        if (whoHasTheBomb == WhoHasTheBomb.P1HasTheBomb){
            Debug.Log($"throwing bomb to p1");
            transform.SetParent(player1ColTrigger.transform);
            transform.localPosition = new Vector2(0,0) + bombPositionOffset;
        }
        else if (whoHasTheBomb == WhoHasTheBomb.P2HasTheBomb){
            Debug.Log($"throwing bomb to p2");
            transform.SetParent(player2ColTrigger.transform);
            transform.localPosition = new Vector2(0,0) + bombPositionOffset;
        }
        
    }
}
public enum WhoHasTheBomb{
    P1HasTheBomb, P2HasTheBomb
}
