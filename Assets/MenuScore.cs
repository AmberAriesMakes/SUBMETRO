using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScore : MonoBehaviour
{

    public Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        highscore.text = ""+ ((int) PlayerPrefs.GetFloat("HighScore")).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
