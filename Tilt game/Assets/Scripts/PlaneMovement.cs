using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] KeyCode rotateLeft;
    [SerializeField] KeyCode rotateRight;
    [SerializeField] KeyCode rotateUp;
    [SerializeField] KeyCode rotateDown;
    [SerializeField] float rotationSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(rotateUp))
        {
            transform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime));
        }
        if (Input.GetKey(rotateDown))
        {
            transform.Rotate(Vector3.left * (rotationSpeed * Time.deltaTime));
        }
        if (Input.GetKey(rotateRight))
        {
            transform.Rotate(Vector3.back * (rotationSpeed * Time.deltaTime));
        }
        if (Input.GetKey(rotateLeft))
        {
            transform.Rotate(Vector3.forward * (rotationSpeed * Time.deltaTime));
        }

    }
}
