using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public float time = 59f;
    public TextMeshPro text;
    // Start is called before the first frame update
    void Start() {
        StartCoroutine("timer");
    }

    // Update is called once per frame
    void Update() {
        
    }
    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    private void OnDisable() {
        StopCoroutine("timer");
    }
    IEnumerator timer(){
        while(time > 0){
            time--;
            text.text = time.ToString();
            yield return new WaitForSecondsRealtime(1);
        }
    }
}
