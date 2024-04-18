using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragandDrop : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject SELECT_DRAG;
    [SerializeField] private int SelectID;

    public void OnBeginDrag(PointerEventData eventData)
    {
        SELECT_DRAG.GetComponent<RectTransform>().sizeDelta = eventData.pointerDrag.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta;
        SELECT_DRAG.GetComponent<Image>().sprite = eventData.pointerDrag.transform.GetChild(0).GetComponent<Image>().sprite;
        SELECT_DRAG.SetActive(true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 cursorPosition = Input.mousePosition;
        cursorPosition.z = 50;
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(cursorPosition);
        SELECT_DRAG.GetComponent<RectTransform>().position = worldPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (eventData.pointerEnter != null)
        {
            if (eventData.pointerEnter.CompareTag("Doll"))
            {
                SELECT_DRAG.SetActive(false);
                eventData.pointerEnter.GetComponent<ChooseWhatWear>().SelectClothes(SelectID);
                gameObject.SetActive(false);
            }
            else
            {
                SELECT_DRAG.SetActive(false);
            }
        }
        else
        {
            SELECT_DRAG.SetActive(false);
        }
    }
}
