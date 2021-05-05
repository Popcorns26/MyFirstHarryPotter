using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingNote : MonoBehaviour
{
    public float speed = 100f;
    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
    }
}
