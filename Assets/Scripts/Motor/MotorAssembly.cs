using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorAssembly : MonoBehaviour
{
    [SerializeField] private GameObject[] details;
    public void AssemblyEngine()
    {
        foreach (GameObject item in details)
        {
            bool isAssembled = item.GetComponent<InteractionForEngine>().isAssembled;
            if (isAssembled && item.GetComponent<Animator>())
            {
                item.GetComponent<InteractionForEngine>().isAssembled = false;
                item.GetComponent<Animator>().SetTrigger("interact");
            }
        }
    }
    public void DestructEngine()
    {
        foreach (GameObject item in details)
        {
            bool isAssembled = item.GetComponent<InteractionForEngine>().isAssembled;
            if (!isAssembled && item.GetComponent<Animator>())
            {
                item.GetComponent<InteractionForEngine>().isAssembled = true;
                item.GetComponent<Animator>().SetTrigger("interact");
            }
        }
    }
}
