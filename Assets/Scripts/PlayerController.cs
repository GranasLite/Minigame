using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 15.0f;
    public float xRange = 20.0f;
    public GameObject projectilePrefab;
    public Animator death;
    public bool gameOver;
    public AudioSource rave;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
       
        if (!gameOver)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Launch a projectile from the player
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
        }


    }
    public void Die()
    {
        death.SetTrigger("Death_b");
        gameOver = true;
        rave.Stop();
    }
}
