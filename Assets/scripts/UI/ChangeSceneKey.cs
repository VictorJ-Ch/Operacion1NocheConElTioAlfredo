using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneKey : MonoBehaviour
{
    public string scene;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
