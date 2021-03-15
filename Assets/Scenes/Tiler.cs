using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiler : MonoBehaviour
{

    GroundScript tiles;
    // Start is called before the first frame update
    void Start()
    {
        tiles = GameObject.FindObjectOfType<GroundScript>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        tiles.instantiateTile();
        Destroy(gameObject, 2);

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Obstacle;

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(4, 7);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(Obstacle, spawnPoint.position, Quaternion.identity, transform);
    }
}
