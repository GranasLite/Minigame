using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int points;
    public TextMeshProUGUI pointsText;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int pointsToAdd)
    {
        points += pointsToAdd;
        pointsText.text = "Score: " + points;
        Debug.Log(points);
    }
}
