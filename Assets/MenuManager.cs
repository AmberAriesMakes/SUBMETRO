using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   
  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void GAME()
    {
        SceneManager.LoadScene("GAME");
       
    }
    public void QUIT()
    {
        Application.Quit();
    }
    public void GAMEQUIT()
    {
        SceneManager.LoadScene("MENU");
    }
    
}
