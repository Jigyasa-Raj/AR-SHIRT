using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public Canvas canvas;
    public void SceneLoader (int SceneIndex)
    {
        canvas.gameObject.SetActive(false);
        SceneManager.LoadScene (SceneIndex);
    }
}
