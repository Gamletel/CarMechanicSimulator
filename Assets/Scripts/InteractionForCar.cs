using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InteractionForCar : MonoBehaviour
{
    [Header("Аниматор второй детали")]
    [SerializeField] private Animator secondAnimator;
    private Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animator.SetTrigger("Interact");
        secondAnimator.SetTrigger("Interact");
    }
    
}
