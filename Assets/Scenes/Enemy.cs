using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Movement pmovement;
    // Start is called before the first frame update
    void Start()
    {
        pmovement = GameObject.FindObjectOfType<Movement>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            pmovement.lives -= 1;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
