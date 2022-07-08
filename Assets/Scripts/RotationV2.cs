using UnityEngine;

public class RotationV2 : MonoBehaviour
{
    [Header("Скорость поворота камеры")]
    [SerializeField] private float sensitivity = 150.0f;
    private Vector3 lastPos;

    void OnMouseDown()
    {
        lastPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }

    void OnMouseDrag()
    {
        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        transform.Rotate(0, -(pos.x - lastPos.x) * sensitivity, 0);

        lastPos = pos;
    }
}