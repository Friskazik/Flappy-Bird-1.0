using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float Speed;



   
    void Update()
    {
        transform.Translate(-Speed * Time.deltaTime, 0, 0);  // �������� ����������� 
    }
}
