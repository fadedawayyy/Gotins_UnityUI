using UnityEngine;
using UnityEngine.EventSystems;

public class ChestplateSlotScript : MonoBehaviour, IDropHandler
{
    public GameObject LeatherChest;
    public GameObject IronChest;
    public GameObject GoldChest;
    public GameObject DiamondChest;

    public void OnDrop(PointerEventData eventData)
    {
        DraggableItem item = eventData.pointerDrag.GetComponent<DraggableItem>();
        if (item == null) return;

        string name = item.gameObject.name;

        if (name != "LeatherChestplateIcon" && name != "IronChestplateIcon" &&
    name != "GoldChestplateIcon" && name != "DiamondChestplateIcon")
{
    item.transform.SetParent(item.originalParent);
    item.transform.localPosition = Vector3.zero;
    return;
}

        item.transform.SetParent(transform);
        item.transform.localPosition = Vector3.zero;

        UpdateChest();
    }

    void Update()
    {
        if (transform.childCount == 0)
        {
            DisableAll();
        }
    }

    void UpdateChest()
    {
        DisableAll();

        string name = transform.GetChild(0).name;

        if (name == "LeatherChestplateIcon") LeatherChest.SetActive(true);
        else if (name == "IronChestplateIcon") IronChest.SetActive(true);
        else if (name == "GoldChestplateIcon") GoldChest.SetActive(true);
        else if (name == "DiamondChestplateIcon") DiamondChest.SetActive(true);
    }

    void DisableAll()
    {
        LeatherChest.SetActive(false);
        IronChest.SetActive(false);
        GoldChest.SetActive(false);
        DiamondChest.SetActive(false);
    }
}
