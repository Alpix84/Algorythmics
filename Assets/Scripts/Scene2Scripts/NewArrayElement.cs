using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class NewArrayElement : MonoBehaviour, IPointerDownHandler
{
    public GameObject prefab;

    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject newObject = Instantiate(prefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity, transform.parent);

    }
}
