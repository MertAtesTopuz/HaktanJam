using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IM : MonoBehaviour, IPointerClickHandler, IDragHandler, IEndDragHandler
{
    private GameObject draggedItem;
    private RectTransform draggedItemRect;

    [SerializeField] private Slot[] Slot;
    private GameObject[] itemsInScene;

    void Start()
    {
        itemsInScene = GameObject.FindGameObjectsWithTag("Pickup"); // Assuming your objects have a "Pickup" tag
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject clickedObject = eventData.pointerCurrentRaycast.gameObject;

        if (clickedObject.CompareTag("Pickup"))
        {
            AddToInventory(clickedObject);
        }
    }

    public void AddToInventory(GameObject item)
    {
        for (int i = 0; i < Slot.Length; i++)
        {
            if (Slot[i].isFull == false)
            {
                item.transform.position = Slot[i].transform.position;
                item.transform.position = new Vector3(item.transform.position.x, item.transform.position.y, 0);
                Slot[i].isFull = true;
                //item.SetActive(false);
                return;
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            draggedItem = eventData.pointerDrag;
            draggedItemRect = draggedItem.GetComponent<RectTransform>();
            draggedItemRect.SetAsLastSibling();
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (draggedItem != null)
        {
            draggedItem = null;
        }
    }
}

