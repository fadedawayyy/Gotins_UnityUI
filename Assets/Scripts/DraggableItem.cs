using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform originalParent;
    private CanvasGroup canvasGroup;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        transform.SetParent(transform.root);
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;

        // Если предмет не был положен ни в какой слот (остался в корне)
        if (transform.parent == transform.root)
        {
            // Возвращаем в исходный слот
            transform.SetParent(originalParent);
            transform.localPosition = Vector3.zero;
        }
        // Если был положен в новый слот
        else
        {
            // Проверяем: есть ли в новом слоте уже другие иконки?
            int childCount = transform.parent.childCount;

            // Если в слоте больше 1 элемента (сам этот + ещё что-то)
            if (childCount > 1)
            {
                // Возвращаем в исходный слот
                transform.SetParent(originalParent);
                transform.localPosition = Vector3.zero;
            }
            // Если в слоте только этот предмет - оставляем его там
        }
    }
}