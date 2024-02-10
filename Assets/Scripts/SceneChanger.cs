using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Shirt()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Pant()
    {
        SceneManager.LoadSceneAsync(3);
    }
}