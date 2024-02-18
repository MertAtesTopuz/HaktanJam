using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public int maxStackedItem = 10;
    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;

    public bool leafChekcT1;
    public bool trapCheckT1;
    public bool leafT1Del;
    public bool trapT1Del;

    public bool leafChekcT2;
    public bool stoneCheckT2;
    public bool ropeCheckT2;
    public bool leafT2Del;
    public bool stoneT2Del;
    public bool ropeT2Del;

    public bool leafChekcT3;
    public bool holeCheckT3;
    public bool stakeCheckT3;
    public bool leafT3Del;
    public bool holeT3Del;
    public bool stakeT3Del;

    public bool flower0Check;
    public bool flower1Check;
    public bool flower2Check;
    public bool flower3Check;
    public bool flower4Check;
    public bool flower0Del;
    public bool flower1Del;
    public bool flower2Del;
    public bool flower3Del;
    public bool flower4Del;


    int selectedSlot = -1;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ChangeSelectedSlot(0);
    }

    public void ChangeSelectedSlot(int newValue)
    {
        if (selectedSlot >=0)
        {
            inventorySlots[selectedSlot].Deselect();
        }

        inventorySlots[newValue].Select();
        selectedSlot = newValue;
        print(selectedSlot);

    }

    public bool AddItem(Item item)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot != null && itemInSlot.item == item && itemInSlot.count < maxStackedItem && itemInSlot.item.stackable == true)
            {
                itemInSlot.count++;
                itemInSlot.RefreshCount();
                return true;
            }
        }

        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return true;
            }
        }

        return false;
    }

    void SpawnNewItem(Item item, InventorySlot slot)
    {
        GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
    }

    public Item GetSelectedItem(bool use)
    {
        InventorySlot slot = inventorySlots[selectedSlot];
        InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
        if (itemInSlot != null)
        {
            Item item = itemInSlot.item;
            if (use == true)
            {
                itemInSlot.count--;
                if (itemInSlot.count <= 0)
                {
                    Destroy(itemInSlot.gameObject);
                }
                else
                {
                    itemInSlot.RefreshCount();
                }
            }
            return item;
        }

        return null;
    }
}
