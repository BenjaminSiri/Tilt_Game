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
    [SerializeField] float maxRotation = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 eulerRotation = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(eulerRotation.x, 0, eulerRotation.z);

        if (Input.GetKey(rotateUp) && !(transform.rotation.eulerAngles.x > 20 && transform.rotation.eulerAngles.x < 338))
        {
            transform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime));
        }
        if (Input.GetKey(rotateDown) && !(transform.rotation.eulerAngles.x > 22 && transform.rotation.eulerAngles.x < 340))
        {
            transform.Rotate(Vector3.left * (rotationSpeed * Time.deltaTime));
        }
        if (Input.GetKey(rotateRight) && !(transform.rotation.eulerAngles.z > 22 && transform.rotation.eulerAngles.z < 340))
        {
            Debug.Log(transform.rotation.eulerAngles.z);
            transform.Rotate(Vector3.back * (rotationSpeed * Time.deltaTime));
        }
        if (Input.GetKey(rotateLeft) && !(transform.rotation.eulerAngles.z > 20 && transform.rotation.eulerAngles.z < 338))
        {
            Debug.Log(transform.rotation.eulerAngles.z);
            transform.Rotate(Vector3.forward * (rotationSpeed * Time.deltaTime));
        }

    }
}
