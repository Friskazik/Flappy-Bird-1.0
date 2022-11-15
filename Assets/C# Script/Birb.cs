using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birb : MonoBehaviour
{
    public float Force;
    Rigidbody2D BirdRigid;

    public GameObject RestartButton; // для кнопки 





    void Start()
    {
        Time.timeScale = 1;
        BirdRigid = GetComponent<Rigidbody2D>();                   // получает компанент Rigidbody2D

    }

  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))                          // нажимая на мышку будет прыгать 
        {
            BirdRigid.velocity = Vector2.up * Force;                // velocity   сила   , сила в vector2.up
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) // удаление при столкновении 
    {
        if (collision.collider.tag == "Enemy")             // определение по тегу
        {
            Destroy(gameObject);
            Time.timeScale = 0; // ксли птичка бьётся об трубу, время останавоивается
            RestartButton.SetActive(true); // при столкновении будет появлятся
        }
    }
}
