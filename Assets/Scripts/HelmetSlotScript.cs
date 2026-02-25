using UnityEngine;
using UnityEngine.EventSystems;

public class HelmetSlotScript : MonoBehaviour, IDropHandler
{
    public GameObject LeatherHelmet;
    public GameObject IronHelmet;
    public GameObject GoldHelmet;
    public GameObject DiamondHelmet;

    public void OnDrop(PointerEventData eventData)
    {
        DraggableItem item = eventData.pointerDrag.GetComponent<DraggableItem>();
        if (item == null) return;

        string name = item.gameObject.name;

        if (name != "LeatherHelmetIcon" && name != "IronHelmetIcon" &&
            name != "GoldHelmetIcon" && name != "DiamondHelmetIcon")
        {

            item.transform.SetParent(item.originalParent);
            item.transform.localPosition = Vector3.zero;
            return;
        }

        item.transform.SetParent(transform);
        item.transform.localPosition = Vector3.zero;

        UpdateHelmet();
    }

    void Update()
    {
        if (transform.childCount == 0)
        {
            DisableAll();
        }
    }

    void UpdateHelmet()
    {
        DisableAll();

        string name = transform.GetChild(0).name;

        if (name == "LeatherHelmetIcon") LeatherHelmet.SetActive(true);
        else if (name == "IronHelmetIcon") IronHelmet.SetActive(true);
        else if (name == "GoldHelmetIcon") GoldHelmet.SetActive(true);
        else if (name == "DiamondHelmetIcon") DiamondHelmet.SetActive(true);
    }

    void DisableAll()
    {
        LeatherHelmet.SetActive(false);
        IronHelmet.SetActive(false);
        GoldHelmet.SetActive(false);
        DiamondHelmet.SetActive(false);
    }
}
