using UnityEngine;
using UnityEngine.EventSystems;

public class LegginsSlotScript : MonoBehaviour, IDropHandler
{
    public GameObject LeatherLeggins;
    public GameObject IronLeggins;
    public GameObject GoldLeggins;
    public GameObject DiamondLeggins;

    public void OnDrop(PointerEventData eventData)
    {
        DraggableItem item = eventData.pointerDrag.GetComponent<DraggableItem>();
        if (item == null) return;

        string name = item.gameObject.name;

        if (name != "LeatherLegginsIcon" && name != "IronLegginsIcon" &&
            name != "GoldLegginsIcon" && name != "DiamondLegginsIcon")
        {
            item.transform.SetParent(item.originalParent);
            item.transform.localPosition = Vector3.zero;
            return;
        }

        item.transform.SetParent(transform);
        item.transform.localPosition = Vector3.zero;

        UpdateLeggins();
    }

    void Update()
    {
        if (transform.childCount == 0)
        {
            DisableAll();
        }
    }

    void UpdateLeggins()
    {
        DisableAll();

        string name = transform.GetChild(0).name;

        if (name == "LeatherLegginsIcon") LeatherLeggins.SetActive(true);
        else if (name == "IronLegginsIcon") IronLeggins.SetActive(true);
        else if (name == "GoldLegginsIcon") GoldLeggins.SetActive(true);
        else if (name == "DiamondLegginsIcon") DiamondLeggins.SetActive(true);
    }

    void DisableAll()
    {
        LeatherLeggins.SetActive(false);
        IronLeggins.SetActive(false);
        GoldLeggins.SetActive(false);
        DiamondLeggins.SetActive(false);
    }
}
