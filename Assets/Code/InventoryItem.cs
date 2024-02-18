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

        if (image.sprite.name == "TrapOpen")
        {
            InventoryManager.instance.trapCheckT1 = true;
        }

        if (image.sprite.name == "Leaf")
        {
            InventoryManager.instance.leafChekcT1 = true;
            InventoryManager.instance.leafChekcT2 = true;
            InventoryManager.instance.leafChekcT3 = true;
        }

        if (image.sprite.name == "Rocks")
        {
            InventoryManager.instance.stoneCheckT2 = true;
        }

        if (image.sprite.name == "RopePick")
        {
            InventoryManager.instance.ropeCheckT2= true;
        }

        if (image.sprite.name == "Shovel")
        {
            InventoryManager.instance.holeCheckT3 = true;
        }

        if (image.sprite.name == "Stake")
        {
            InventoryManager.instance.stakeCheckT3= true;
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

        if (image.sprite.name == "TrapOpen")
        {
            InventoryManager.instance.trapCheckT1 = false;
        }

        if (image.sprite.name == "Leaf")
        {
            InventoryManager.instance.leafChekcT1 = false;
            InventoryManager.instance.leafChekcT2 = false;
            InventoryManager.instance.leafChekcT3 = false;
        }

        if (image.sprite.name == "Rocks")
        {
            InventoryManager.instance.stoneCheckT2 = false;
        }

        if (image.sprite.name == "RopePick")
        {
            InventoryManager.instance.ropeCheckT2 = false;
        }

        if (image.sprite.name == "Shovel")
        {
            InventoryManager.instance.holeCheckT3 = false;
        }

        if (image.sprite.name == "Stake")
        {
            InventoryManager.instance.stakeCheckT3 = false;
        }

        if(InventoryManager.instance.trapT1Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.trapT1Del = false;
        }

        if(InventoryManager.instance.leafT1Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.leafT1Del = false;
        }

        if(InventoryManager.instance.stoneT2Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.stoneT2Del = false;
        }

        if(InventoryManager.instance.leafT2Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.leafT2Del = false;
        }

        if(InventoryManager.instance.ropeT2Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.ropeT2Del = false;
        }

        if(InventoryManager.instance.leafT3Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.leafT3Del = false;
        }

        if(InventoryManager.instance.holeT3Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.holeT3Del = false;
        }

        if(InventoryManager.instance.stakeT3Del == true)
        {
            InventoryManager.instance.GetSelectedItem(true);
            InventoryManager.instance.stakeT3Del = false;
        }
    }
}
