using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{

    [SerializeField] private RectTransform array;

    public void OnDrop(PointerEventData eventData) 
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = array.anchoredPosition + GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
