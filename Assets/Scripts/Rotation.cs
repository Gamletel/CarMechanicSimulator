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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // поле зрение камеры
        RaycastHit hit = new RaycastHit(); // хранит данные объекта с котором пересекс€ вектор камеры и параметры пересечени€
        if (Physics.Raycast(ray, out hit)) // выполн€етс€ если хоть один объект встретилс€
        {
            Vector3 rot = transform.eulerAngles; // запись предыдущего угла Ёйлера "Rotation"
            transform.LookAt(hit.point); // перевод в угол поворота из полученных координат при пересечении с объектом
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0); // установка нового угла
        }
    }
}