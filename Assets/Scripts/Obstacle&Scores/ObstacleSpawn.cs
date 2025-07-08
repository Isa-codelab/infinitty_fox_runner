using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public List<Transform> obstaclePosition;

    void Start()
    {
        SpawnObstacles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        foreach (Transform position in obstaclePosition)
        {
            if (position != null)
            {
                Instantiate(obstaclePrefab, position.position, position.rotation, transform);
                
            }
        }

    }

}
