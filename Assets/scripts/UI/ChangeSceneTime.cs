using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTime : MonoBehaviour
{
    public float time = 3.0f;
    public string scene;

    void Start()
    {
        Invoke("ChangeScene", time);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
