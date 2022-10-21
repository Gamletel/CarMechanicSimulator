using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backForCamera : MonoBehaviour
{
    private Camera cam;
    private Animator animator;
    
    private void Start()
    {
        cam = Camera.main;
        animator = cam.GetComponent<Animator>();
    }
    
    public void Back()
    {
        animator.SetTrigger("back");
    }
}
