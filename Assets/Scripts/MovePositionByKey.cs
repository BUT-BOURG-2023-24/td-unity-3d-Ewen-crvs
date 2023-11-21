using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePositionByKey : MonoBehaviour
{
    public float speed = 10.0f;
    public InputActionReference moveInputRef = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 inputMovement = moveInputRef.action.ReadValue<Vector2>();


        transform.position += new Vector3(inputMovement.x * speed * Time.deltaTime, 0.0f, inputMovement.y * speed * Time.deltaTime);









        //Vector3 inputMovement = Vector3.zero;
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    inputMovement.z = 1f;
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    inputMovement.z = -1f;
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    inputMovement.x = 1f;
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    inputMovement.x = -1f;
        //}

        //transform.position = transform.position + (inputMovement * speed * Time.deltaTime);

    }
}
