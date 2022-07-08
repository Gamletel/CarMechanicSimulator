using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("�������� ��������� ������� (����� �������� ������)")]
    [SerializeField] private Animator objAnimator;
    [Header("�������� �������� ��� �������� ������")]
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
