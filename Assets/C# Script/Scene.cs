using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scene : MonoBehaviour
{
    public void RestartLrvel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // рестарт жкйствуюзкй сцены
    }
}
