using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // библиотека для каботы с интерфейсом
using UnityEngine;

public class Score : MonoBehaviour
{

    public int score;
    public Text scoreText;

    void Start()
    {

        score = 0; // в начале количестыоточков пвыно 0
    }

    
    void Update()
    {
        scoreText.text = score.ToString(); // связь между текстом и очками
    }
    private void OnTriggerEnter2D(Collider2D collision) // фуекция 
    {
        if (collision.tag == "Score") // если прохожит через тег , то +1
        {
            score++;
               
        }
    }
}
