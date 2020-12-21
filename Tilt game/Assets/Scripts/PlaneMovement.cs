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

    [Header("Initial LERP")]
    [SerializeField] Vector3[] myPositions;
    [SerializeField] [Range(0f, 1f)] float lerpTime;
    int posIndex = 0;
    int length;
    float t = 0f;
    bool isLerping = true;


    // Start is called before the first frame update
    void Start()
    {
        length = myPositions.Length;
        StartCoroutine(waitSeconds(4.5f));
    }

    // Update is called once per frame
    void Update()
    {
        if (isLerping)
        {
            transform.position = Vector3.Lerp(transform.position, myPositions[posIndex], lerpTime * Time.deltaTime);
            t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
            if (t > .9f)
            {
                t = 0f;
                posIndex++;
                posIndex = (posIndex >= length) ? 0 : posIndex;
            }
        }
        else
        {
            Vector3 eulerRotation = transform.rotation.eulerAngles;
            transform.rotation = Quaternion.Euler(eulerRotation.x, 0, eulerRotation.z);

            if (Input.GetKey(rotateUp) && !(transform.rotation.eulerAngles.x > maxRotation && transform.rotation.eulerAngles.x < (360 - (maxRotation+2))))
            {
                transform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime));
            }
            if (Input.GetKey(rotateDown) && !(transform.rotation.eulerAngles.x > (maxRotation+2) && transform.rotation.eulerAngles.x < (360-maxRotation)))
            {
                transform.Rotate(Vector3.left * (rotationSpeed * Time.deltaTime));
            }
            if (Input.GetKey(rotateRight) && !(transform.rotation.eulerAngles.z > (maxRotation+2) && transform.rotation.eulerAngles.z < (360-maxRotation)))
            {
                transform.Rotate(Vector3.back * (rotationSpeed * Time.deltaTime));
            }
            if (Input.GetKey(rotateLeft) && !(transform.rotation.eulerAngles.z > maxRotation && transform.rotation.eulerAngles.z < (360 - (maxRotation + 2))))
            {
                transform.Rotate(Vector3.forward * (rotationSpeed * Time.deltaTime));
            }
        }
    }

    IEnumerator waitSeconds(float sec)
    {
        yield return new WaitForSeconds(sec);
        isLerping = false;
    }
}
