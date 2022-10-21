using UnityEngine;

public class CorrectDetail : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<TestController>().NextTask();
        FindObjectOfType<TestController>().score++;
        Destroy(this);
    }
}
