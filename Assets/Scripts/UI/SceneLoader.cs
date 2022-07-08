using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int sceneIndex;
    [SerializeField] private int prevSceneIndex;
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void LoadPrevScene()
    {
        SceneManager.LoadScene(prevSceneIndex);
    }
}
