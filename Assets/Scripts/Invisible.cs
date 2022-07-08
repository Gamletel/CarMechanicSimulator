using UnityEngine;
public class Invisible : MonoBehaviour
{
    [SerializeField] private BoxCollider[] normal_obj;
    [SerializeField] private BoxCollider[] invisible_obj;
    [SerializeField] private MeshRenderer[] normal_obj_renderer;
    [SerializeField] private MeshRenderer[] invisible_obj_renderer;
    private bool notInvisible;
    public void SetInvisible()
    {
        if (!notInvisible)
            SetInvis();
        else
            SetVisibility();
    }
    private void SetInvis()
    {
        foreach (MeshRenderer item in invisible_obj_renderer)
            item.enabled = true;
        foreach (BoxCollider item in invisible_obj)
            item.enabled = true;
        foreach (MeshRenderer item in normal_obj_renderer)
            item.enabled = false;
        foreach (BoxCollider item in normal_obj)
            item.enabled = false;
        notInvisible = !notInvisible;
    }
    private void SetVisibility()
    {
        foreach (MeshRenderer item in invisible_obj_renderer)
            item.enabled = false;
        foreach (BoxCollider item in invisible_obj)
            item.enabled = false;
        foreach (MeshRenderer item in normal_obj_renderer)
            item.enabled = true;
        foreach (BoxCollider item in normal_obj)
            item.enabled = true;
        notInvisible = !notInvisible;
    }
}
