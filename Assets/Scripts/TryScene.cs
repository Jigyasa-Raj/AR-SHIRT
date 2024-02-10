using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TryScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void PrevScene()
    {
        SceneManager.LoadSceneAsync(4);
    }
}
