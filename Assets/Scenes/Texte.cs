using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texte: MonoBehaviour
{
    [SerializeField] Movement pmovement;
   [SerializeField] Text HealthValue;
    [SerializeField] Text Score;
    public static float score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        HealthValue.text = pmovement.lives.ToString();
        Score.text = pmovement.playerscore.ToString();

       


    }
    

    public float getscore()
    {
        return score;
    }

  
    

}
