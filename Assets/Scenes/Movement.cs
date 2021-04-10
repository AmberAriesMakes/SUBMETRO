using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    float horizontalInput;
    public int lives;
    bool lost;
    public float speed = 5;
    public float accelerate;
    public float speedup;
    public GameObject Train;
    Texte score;
    public int playerscore;
    public AudioSource audiosource;
    public AudioClip CoinPickup;
    public AudioClip PowerUp1;
    public AudioClip powerUp2;
    public float volume = 0.5f;
    // Start is called before the first frame update
   
    void Start()
    {
        lives = 5;
        lost = false;
       // score = GameObject.FindObjectOfType<Texte>();
        
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
        

       
        

    }
    
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (lives <= 0)
        {
            lostgame();
            
        }
       
        if (speed >= 80)
        {
            speed = 80;
        }
        if (transform.position.x >= 4.33)
        {
            transform.position = new Vector3(4.33f, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -4.33)
        {
            transform.position = new Vector3(-4.33f, transform.position.y, transform.position.z);
        }

       if (speed <= 10)
        {
            lostgame();
        }    
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void lostgame()
    {
        lost = true;
        SceneManager.LoadScene("MENU");
        print(playerscore);

       
        if (playerscore > PlayerPrefs.GetFloat("HighScore", playerscore))
        {
            PlayerPrefs.SetFloat("HighScore", playerscore);
        }
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
      
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            speed += 10.0f;
            audiosource.PlayOneShot(PowerUp1, volume);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            playerscore += 200;
            audiosource.PlayOneShot(CoinPickup, volume);
            Destroy(collision.gameObject);
            
        }
        if (collision.gameObject.CompareTag("Life PowerUp"))
        {
            Texte.score += 200f;
            audiosource.PlayOneShot(powerUp2, volume);
            lives += 1;
            Destroy(collision.gameObject);
        }

    }

}
