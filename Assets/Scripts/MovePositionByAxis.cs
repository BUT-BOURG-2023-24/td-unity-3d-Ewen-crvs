using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositionByAxis : MonoBehaviour
{
    public float speed = 10.0f;
    public bool useRaxAxis = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Debug.Log("X Axis" + xAxis);

        transform.position += new Vector3(xAxis * speed * Time.deltaTime, 0.0f, zAxis * speed * Time.deltaTime);
    }
}
