using UnityEngine;

[RequireComponent(typeof(Outline))]
public class OutlineController : MonoBehaviour
{
    private Outline outline;
    
    private void Start()
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
        outline.OutlineColor = Color.yellow;
    }
    
    private void OnMouseEnter()
    {
        outline.enabled = true;
    }
    
    private void OnMouseExit()
    {
        outline.enabled = false;
    }
    
    private void OnMouseDown()
    {
        outline.OutlineColor = Color.green;
    }
    
    private void OnMouseUp()
    {
        outline.OutlineColor = Color.yellow;
    }
}
