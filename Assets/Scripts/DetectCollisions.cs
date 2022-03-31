using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int value;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (gameObject.tag != "Bullet")
            {
                other.GetComponent<PlayerController>().Die();
            }

        }
        else
        {
            if (gameObject.tag == "Animal")
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().UpdateScore(value);
            }
            Destroy(gameObject);
            Destroy(other.gameObject);
            //GetComponent<GameManager>()
        }
        
    }
}
