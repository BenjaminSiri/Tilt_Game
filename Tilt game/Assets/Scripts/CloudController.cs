using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    [Header("Cloud Movement")]
    [SerializeField] float cloudSpeed;
    [SerializeField] float speedVariation;
    [SerializeField] float maxY, minY, startX;
    [SerializeField] float spawnRate;
    float timer = 2f;

    [SerializeField] GameObject cloudPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Debug.Log("Spawn cloud");
            GameObject newCloud = Instantiate(cloudPrefab, randomPosition(), Quaternion.identity);
            newCloud.AddComponent<Rigidbody>();
            newCloud.GetComponent<Rigidbody>().useGravity = false;
            newCloud.GetComponent<Rigidbody>().velocity = new Vector3(-(cloudSpeed+Random.Range(-speedVariation, speedVariation)), 0.0f, 0.0f);
            timer = spawnRate;
        }
    }

    Vector3 randomPosition()
    {
        return new Vector3(startX, Random.Range(minY, maxY), 0);
    }
}
