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

    // Start is called before the first frame update
    void Start()
    {
        lives = 5;
        lost = false;
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
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void lostgame()
    {
        lost = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   
}
