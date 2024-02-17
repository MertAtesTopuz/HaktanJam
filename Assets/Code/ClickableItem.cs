using UnityEngine;

public class ClickableItem : MonoBehaviour
{
    public IM inventoyM;
    private void OnMouseDown()
    {
        // This method is called when the object is clicked
        print("asd");
        // You can communicate with the InventoryManager here
        IM inventoryManager = FindObjectOfType<IM>();
        if (inventoryManager != null)
        {
            print("asdasdasda");
            inventoyM.AddToInventory(gameObject);
        }
    }
}
