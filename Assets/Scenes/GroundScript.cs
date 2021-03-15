using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 NextGroundTile;
    // Start is called before the first frame update
   
    public void instantiateTile()
    {
        GameObject block = Instantiate(groundTile, NextGroundTile, Quaternion.identity);
        NextGroundTile = block.transform.GetChild(1).transform.position;
    }
    private void Start()
    {
        for (int i = 0; i < 25; i++)
        {
            instantiateTile();
         
        }

    }

}
