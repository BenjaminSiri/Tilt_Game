using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            this.transform.parent.GetComponentInParent<PlaneMovement>().LerpUp();
            GameManager.instance.WaitNextScene(2);
            Destroy(this);
        }
    }
}
