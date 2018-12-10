using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        //add to inventory
        if (Inventory.instance.Add(item) )
            Destroy(gameObject);
    }
}
