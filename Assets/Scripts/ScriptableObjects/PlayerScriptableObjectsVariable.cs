using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerScriptableObjectsVariable : ScriptableObject {
    public float dampingRatio = 0.1f;
    public float frequency = 1f;

    public float peakSpeedDampingRatio = 0.5f;
    public float peakSpeedFrequency = 5f;
}
