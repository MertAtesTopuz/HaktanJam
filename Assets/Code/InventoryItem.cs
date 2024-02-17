using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    
    [Header("UI")]
    public Image image;
    public Text countText;

    private BoxCollider2D col;

    public Vector2 screenPos;
    public Vector2 worldPos;

    [HideInInspector] public Item item;
    [HideInInspector] public int count = 12;
    [HideInInspector] public Transform parentAfterDrag;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        screenPos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(screenPos);
    }

    public void InitialiseItem(Item newItem)
    {
        item = newItem;
        image.sprite = newItem.image;
        RefreshCount();
    }

    public void RefreshCount()
    {
        countText.text = count.ToString();
        bool textActive = count > 1;
        countText.gameObject.SetActive(textActive);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        col.enabled = true;
        transform.SetAsLastSibling();

        if (image.sprite.name == "e7m7DP_3")
        {
            InventoryManager.instance.piece1Control = true;
        }

        if (image.sprite.name == "e7m7DP_7")
        {
            InventoryManager.instance.piece2Control = true;
        }

        if (image.sprite.name == "e7m7DP_2")
        {
            InventoryManager.instance.piece3Control = true;
        }
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = worldPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.raycastTarget = true;
        transform.SetParent(parentAfterDrag);
        col.enabled = false;

        if (image.sprite.name == "e7m7DP_3")
        {
            InventoryManager.instance.piece1Control = false;
        }

        if (image.sprite.name == "e7m7DP_7")
        {
            InventoryManager.instance.piece2Control = false;
        }

        if (image.sprite.name == "e7m7DP_2")
        {
            InventoryManager.instance.piece3Control = false;
        }

        if(InventoryManager.instance.piece1Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.piece1Del = false;
        }

        if(InventoryManager.instance.piece2Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.piece2Del = false;
        }

        if(InventoryManager.instance.piece3Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.piece3Del = false;
        }
    }
}
