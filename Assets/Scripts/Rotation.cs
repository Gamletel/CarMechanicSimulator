using UnityEngine;

public class Rotation : MonoBehaviour
{
    private bool isRotate = false;
    
    private void Update()
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
        RaycastHit hit = new RaycastHit(); // хранит данные объекта с котором пересекся вектор камеры и параметры пересечения
        if (Physics.Raycast(ray, out hit)) // выполняется если хоть один объект встретился
        {
            Vector3 rot = transform.eulerAngles; // запись предыдущего угла Эйлера
            transform.LookAt(hit.point); // перевод в угол поворота из полученных координат при пересечении с объектом
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0); // установка нового угла
        }
    }
}