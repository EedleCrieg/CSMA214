using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobScript : MonoBehaviour
{
    public float freq = 1.0f;   // the frequency of the wave 
    public float amp = 1.0f;    // the amplitude of the wave

    private Vector3 initial_position; // the initial position of the object

    private void Start()
    {
        initial_position = this.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 new_position = new Vector3(0, initial_position.y + Mathf.Sin(Time.time * freq) * amp, 0);

        transform.position = new_position; 
    }

}
