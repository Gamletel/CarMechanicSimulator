using UnityEngine;
using DG.Tweening;

public class OpenPanelSettings : MonoBehaviour
{
    private bool isComplete = false;
    private DOTweenAnimation dot;
    
    private void Start()
    {
        dot = GetComponent<DOTweenAnimation>();
    }
    
    public void Play()
    {
        if (!isComplete)
        {
            dot.DOPlayForward();
            isComplete = !isComplete;
        }
        else
        {
            dot.DOPlayBackwards();
            isComplete = !isComplete;
        }
    }
}
