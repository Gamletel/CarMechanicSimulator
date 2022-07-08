using UnityEngine;

public class lockPosition : MonoBehaviour
{
    [Header("Коллайдер главной модели")]
    [SerializeField] private BoxCollider col;
    [Header("Коллайдер деталей")]
    [SerializeField] private BoxCollider[] detailCol;
    [SerializeField] private bool isLocked;
    public void Interact()
    {
        if (isLocked)
            UnlockPos();
        else
            LockPos();
    }
    private void UnlockPos()
    {
        col.enabled = true;
        foreach (BoxCollider item in detailCol)
            if (item.enabled != false)
                item.enabled = false;
        isLocked = !isLocked;
    }
    private void LockPos()
    {
        col.enabled = false;
        foreach (BoxCollider item in detailCol)
            if (item.enabled != true)
                item.enabled = true;
        isLocked = !isLocked;
    }
}
