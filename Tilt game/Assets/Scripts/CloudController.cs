using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    [Header("Cloud Movement")]
    [SerializeField] float cloudSpeed;
    [SerializeField] float speedVariation;
    [SerializeField] float maxY, minY, startX;

    [SerializeField] GameObject cloudPrefab;

    private float timer = 0f;
    private float spawnRate = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer == spawnRate)
        {
            GameObject newCloud = Instantiate(cloudPrefab, randomPosition(), Quaternion.identity);
            newCloud.AddComponent<Rigidbody>();
            newCloud.transform.position = new Vector3(0.0f, -2.0f, 0.0f);
            newCloud.rigidbody.velocity = new Vector3(0.0f, 10.0f, 0.0f);
        }
    }

    Vector3 randomPosition()
    {
        return new Vector3(startX, Random.Range(minY, maxY), 0);
    }
}
