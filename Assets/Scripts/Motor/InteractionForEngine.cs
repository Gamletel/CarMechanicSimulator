using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionForEngine : MonoBehaviour
{
    public bool isAssembled;
    [SerializeField] private string infoString;
    [SerializeField] private Text infoText;
    private Animator animator;
    private void Start() => animator = GetComponent<Animator>();

    private void OnMouseDown()
    {
        SetInfoText();
        isAssembled = !isAssembled;
        animator.SetTrigger("interact");
    }
    private void SetInfoText()
    {
        infoText.text = infoString;
    }
}
