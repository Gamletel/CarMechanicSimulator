using UnityEngine;

public class Rotation : MonoBehaviour
{
    private bool isRotate = false;
    void Update()
    {
        if (isRotate)
            Rotate();
    }
    private void OnMouseDown()
    {
        isRotate = true;
    }
    private void OnMouseUp()
    {
        isRotate = false;
    }
    private void Rotate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // ���� ������ ������
        RaycastHit hit = new RaycastHit(); // ������ ������ ������� � ������� ��������� ������ ������ � ��������� �����������
        if (Physics.Raycast(ray, out hit)) // ����������� ���� ���� ���� ������ ����������
        {
            Vector3 rot = transform.eulerAngles; // ������ ����������� ���� ������ "Rotation"
            transform.LookAt(hit.point); // ������� � ���� �������� �� ���������� ��������� ��� ����������� � ��������
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0); // ��������� ������ ����
        }
    }
}