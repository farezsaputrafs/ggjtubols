using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public float time = 59f;
    public TextMeshPro text;
    public GameObject p1GameObject;
    public GameObject p2GameObject;
    public ParticleSystem p1ParticleSystem;
    public ParticleSystem p2ParticleSystem;
    public BombSystem bombSystem;
    // Start is called before the first frame update
    void Start() {
        StartCoroutine("timer");
    }

    // Update is called once per frame
    void Update() {
        if (!oneshot && time <= 0){
            oneshot = true;
            if (bombSystem.whoHasTheBomb == WhoHasTheBomb.P1HasTheBomb){
                p1ParticleSystem.transform.SetParent(null);
                p1ParticleSystem.Play();
                Destroy(p1GameObject);
            }
            else {
                p2ParticleSystem.transform.SetParent(null);
                p2ParticleSystem.Play();
                Destroy(p2GameObject);
            }
        }
    }
    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    bool oneshot = false;
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
