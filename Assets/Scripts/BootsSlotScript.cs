using UnityEngine;
using UnityEngine.EventSystems;

public class BootsSlotScript : MonoBehaviour, IDropHandler
{
    public GameObject LeatherBoots;
    public GameObject IronBoots;
    public GameObject GoldBoots;
    public GameObject DiamondBoots;

    public void OnDrop(PointerEventData eventData)
    {
        DraggableItem item = eventData.pointerDrag.GetComponent<DraggableItem>();
        if (item == null) return;

        string name = item.gameObject.name;


        if (name != "LeatherBootsIcon" && name != "IronBootsIcon" &&
            name != "GoldBootsIcon" && name != "DiamondBootsIcon")
        {
            item.transform.SetParent(item.originalParent);
            item.transform.localPosition = Vector3.zero;
            return;
        }

        item.transform.SetParent(transform);
        item.transform.localPosition = Vector3.zero;

        UpdateBoots();
    }

    void Update()
    {
        if (transform.childCount == 0)
        {
            DisableAll();
        }
    }

    void UpdateBoots()
    {
        DisableAll();

        string name = transform.GetChild(0).name;

        if (name == "LeatherBootsIcon") LeatherBoots.SetActive(true);
        else if (name == "IronBootsIcon") IronBoots.SetActive(true);
        else if (name == "GoldBootsIcon") GoldBoots.SetActive(true);
        else if (name == "DiamondBootsIcon") DiamondBoots.SetActive(true);
    }

    void DisableAll()
    {
        LeatherBoots.SetActive(false);
        IronBoots.SetActive(false);
        GoldBoots.SetActive(false);
        DiamondBoots.SetActive(false);
    }
}
