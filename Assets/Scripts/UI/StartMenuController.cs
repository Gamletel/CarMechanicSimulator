using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    [SerializeField] private GameObject loadBtn;
    [SerializeField] private GameObject loadSlider;
    [SerializeField] private Slider slider;
    
    public void LoadNextScene(int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex));
    }
    
    private IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadBtn.SetActive(false);
        loadSlider.SetActive(false);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }
}
