using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiler : MonoBehaviour
{
    private int RandomRoll;
    GroundScript tiles;
    // Start is called before the first frame update
    void Start()
    {
        tiles = GameObject.FindObjectOfType<GroundScript>();
        

        RandomRoll = Random.Range(0, 100);
        if (RandomRoll <= 10)
        {
            SpawnBuff();
        }
        else if (RandomRoll >= 80)
        {
            SpawnObstacle();
        }
        if (RandomRoll >= 95)
        {
            MeatLives();
        }
        else
        {
            SpawnCoin();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        tiles.instantiateTile();
        Destroy(gameObject, 2);

    }
    // Update is called once per frame
    void Update()
    {
        if ( PowerUp.transform.position == Obstacle.transform.position)
        {
            Destroy(this.PowerUp);
        }
    }

    public GameObject Obstacle;
    public GameObject PowerUp;
    public GameObject Coin;
    public GameObject MeatLivess;

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(4, 7);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(Obstacle, spawnPoint.position, Quaternion.identity, transform);
    }
    void SpawnBuff()
    {
        int BuffSpawnIndex = Random.Range(4, 7);
        Transform BuffSpawnPoint = transform.GetChild(BuffSpawnIndex).transform;
        Instantiate(PowerUp, BuffSpawnPoint.position, Quaternion.identity, transform);
        
    }
    void SpawnCoin()
    {

        int CoinSpawnIndex = Random.Range(4, 7);
        Transform CoinSpawnPoint = transform.GetChild(CoinSpawnIndex).transform;
        Instantiate(Coin, CoinSpawnPoint.position, Quaternion.identity, transform);
    }
    void MeatLives()
    {

        int MeatSpawnIndex = Random.Range(4, 7);
        Transform MeatSpawnPoint = transform.GetChild(MeatSpawnIndex).transform;
        Instantiate(MeatLivess, MeatSpawnPoint.position, Quaternion.identity, transform);
    }
}
