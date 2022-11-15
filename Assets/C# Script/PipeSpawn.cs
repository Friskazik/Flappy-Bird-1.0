using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject Pipes;


    void Start()
    {
        StartCoroutine(Spawner());
    }

   IEnumerator Spawner()
    {
        while (true)  // бесконечный цмкл while
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-1f, -5f);
            GameObject newPipe  = Instantiate(Pipes, new Vector3(2, rand, 0), Quaternion.identity);
            Destroy(newPipe, 10);
        }
    }
    
}
