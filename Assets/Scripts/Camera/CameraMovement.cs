using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Аниматор активного объекта (можно оставить пустым)")]
    [SerializeField] private Animator objAnimator;
    [Header("Название триггера для анимации камеры")]
    [SerializeField] private string triggerName;
    private Camera cam;
    private Animator camAnimator;
    void Start()
    {
        cam = Camera.main;
        camAnimator = cam.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        camAnimator.SetTrigger($"{triggerName}");
        if (objAnimator == null)
            return;
        else
            objAnimator.SetTrigger("interact");
    }
}
