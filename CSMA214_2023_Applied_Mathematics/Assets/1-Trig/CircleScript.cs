using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    public float freq = 1;
    public float radius = 1;

    // Update is called once per frame
    void Update()
    {
        float x_position = radius * Mathf.Cos(Time.time * freq);
        float y_position = radius * Mathf.Sin(Time.time * freq);

        Vector3 new_position = new Vector3(x_position, y_position, 0);

        transform.position = new_position; 
    }
}
