
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableSymbol : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 location;
    private Vector2 offset;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin drag");
        offset = new Vector2(transform.position.x - eventData.position.x, transform.position.y - eventData.position.y);
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = new Vector2(offset.x + eventData.position.x, offset.y + eventData.position.y );
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = location;
        Debug.Log("End drag");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        location=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
