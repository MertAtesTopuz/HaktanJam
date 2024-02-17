using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropManager : MonoBehaviour
{
    public static DragAndDropManager instance;

    private RectTransform draggedItem;
    private CanvasGroup canvasGroup;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void SetDraggedItem(RectTransform item, CanvasGroup group)
    {
        draggedItem = item;
        canvasGroup = group;
        canvasGroup.blocksRaycasts = false;
    }

    public void MoveDraggedItem(Vector2 position)
    {
        if (draggedItem != null)
            draggedItem.position = position;
    }

    public void DropItem()
    {
        if (draggedItem != null)
        {
            draggedItem = null;
            canvasGroup.blocksRaycasts = true;
        }
    }
}
