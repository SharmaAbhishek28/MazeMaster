using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNodes : MonoBehaviour
{
    int numToSpawn = 27;

    public float currentSpawnOffset;
    public float spawnOffset = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Node")
        {
            currentSpawnOffset = spawnOffset;
            for (int i = 0; i < numToSpawn; i++)
            {
                //Clone a new Node
                GameObject clone = Instantiate(gameObject, new Vector3(transform.position.x + currentSpawnOffset, transform.position.y, 0),Quaternion.identity);
                currentSpawnOffset += spawnOffset;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
