using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BuffRotate : MonoBehaviour
{

    public float rotspeedy;
    public float RotY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         RotY += rotspeedy * Time.deltaTime;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, RotY, transform.eulerAngles.z);
        if (RotY > 360) RotY -= 360;

    }
   
}
