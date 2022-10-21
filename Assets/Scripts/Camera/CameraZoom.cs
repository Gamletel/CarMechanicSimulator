using UnityEngine;
public class CameraZoom : MonoBehaviour
{
    private float distance=1f;
    private Vector3 startPos;
    [SerializeField] private Transform endPos;
    
    private void Awake()
    {
        startPos = transform.position;
    }
    
    private void Update()
    {
        float mw = Input.GetAxis("Mouse ScrollWheel");
        if (mw != 0.0f)
        {
            if(mw > 0.01f)
                transform.position = Vector3.MoveTowards(transform.position, endPos.position, distance);
            if (mw < 0.01f)
                transform.position = Vector3.MoveTowards(transform.position, startPos, distance);
        }
    }
}
