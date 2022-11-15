using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birb : MonoBehaviour
{
    public float Force;
    Rigidbody2D BirdRigid;

    public GameObject RestartButton; // ��� ������ 





    void Start()
    {
        Time.timeScale = 1;
        BirdRigid = GetComponent<Rigidbody2D>();                   // �������� ��������� Rigidbody2D

    }

  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))                          // ������� �� ����� ����� ������� 
        {
            BirdRigid.velocity = Vector2.up * Force;                // velocity   ����   , ���� � vector2.up
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) // �������� ��� ������������ 
    {
        if (collision.collider.tag == "Enemy")             // ����������� �� ����
        {
            Destroy(gameObject);
            Time.timeScale = 0; // ���� ������ ������ �� �����, ����� ���������������
            RestartButton.SetActive(true); // ��� ������������ ����� ���������
        }
    }
}
