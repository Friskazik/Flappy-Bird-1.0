using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // ���������� ��� ������ � �����������
using UnityEngine;

public class Score : MonoBehaviour
{

    public int score;
    public Text scoreText;

    void Start()
    {

        score = 0; // � ������ ���������������� ����� 0
    }

    
    void Update()
    {
        scoreText.text = score.ToString(); // ����� ����� ������� � ������
    }
    private void OnTriggerEnter2D(Collider2D collision) // ������� 
    {
        if (collision.tag == "Score") // ���� �������� ����� ��� , �� +1
        {
            score++;
               
        }
    }
}
