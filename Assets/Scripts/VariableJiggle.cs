using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableJiggle : MonoBehaviour
{
    public PlayerScriptableObjectsVariable playerScriptableObjectsVariable;
    public Rigidbody2D rb2d;
    public SpringJoint2D[] springJoints;
    public Vector2 peakSpeedVelocity;
    public float peakSpeedVelocityFloat = 9;
    // Start is called before the first frame update
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        springJoints = GetComponents<SpringJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(rb2d.velocity, peakSpeedVelocity) > peakSpeedVelocityFloat){
            // Debug.Log($"2fast");
            // springJoint1.dampingRatio = playerScriptableObjectsVariable.peakSpeedDampingRatio;
            // springJoint1.frequency = playerScriptableObjectsVariable.peakSpeedFrequency;
            // springJoint2.dampingRatio = playerScriptableObjectsVariable.peakSpeedDampingRatio;
            // springJoint2.frequency = playerScriptableObjectsVariable.peakSpeedFrequency;

            foreach (SpringJoint2D item in springJoints) {
                item.dampingRatio = playerScriptableObjectsVariable.peakSpeedDampingRatio;
                item.frequency = playerScriptableObjectsVariable.peakSpeedFrequency;
            }
        } 
        else {
            // Debug.Log($"2slow");
            // springJoint1.dampingRatio = playerScriptableObjectsVariable.dampingRatio;
            // springJoint1.frequency = playerScriptableObjectsVariable.frequency;
            // springJoint2.dampingRatio = playerScriptableObjectsVariable.dampingRatio;
            // springJoint2.frequency = playerScriptableObjectsVariable.frequency;
            foreach (SpringJoint2D item in springJoints) {
                item.dampingRatio = playerScriptableObjectsVariable.dampingRatio;
                item.frequency = playerScriptableObjectsVariable.frequency;
            }
        }
    }
}
