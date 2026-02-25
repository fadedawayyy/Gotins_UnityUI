using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ArmorSlot : MonoBehaviour, IDropHandler
{
    public string slotType;
    public Image armorDisplayImage;

    public void OnDrop(PointerEventData eventData)
    {
        DraggableItem item = eventData.pointerDrag.GetComponent<DraggableItem>();
        if (item != null && item.name.ToLower().Contains(slotType.ToLower()))
        {
            item.transform.SetParent(transform);
            item.transform.localPosition = Vector3.zero;

            ShowArmor(item.name);
        }
    }

    private void ShowArmor(string itemName)
    {
        string armorSpriteName = itemName.Replace("Icon", "");
        Sprite armorSprite = Resources.Load<Sprite>(armorSpriteName);
        if (armorSprite != null)
        {
            armorDisplayImage.sprite = armorSprite;
            armorDisplayImage.enabled = true;
        }
    }

    public void RemoveArmor()
    {
        armorDisplayImage.sprite = null;
        armorDisplayImage.enabled = false;
    }
}
