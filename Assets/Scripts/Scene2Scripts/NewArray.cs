using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class NewArray : MonoBehaviour, IPointerDownHandler
{
    public GameObject prefab5Length;
    [SerializeField] private UI_InputWindow inputWindow;
    private BoxCollider boxCollider;
    private double arrayLength;

    public void OnPointerDown(PointerEventData eventData)
    {
        UI_Blocker.Show_Static();
        inputWindow.Show(
            "0123456789",
            2,
            () => 
            { 
                Debug.Log("Cancel!");
                UI_Blocker.Hide_Static();
            },
            (string InputText) => 
            { 
                Debug.Log("OK! " + InputText);
                CreateNewArray(int.Parse(InputText));
                UI_Blocker.Hide_Static();
            }
        );
    }

    private void CreateNewArray(int value)
    {
        if(value == 5)
        {
            GameObject newObject = Instantiate(prefab5Length, transform.position + new Vector3(0, 1, 0), Quaternion.identity, transform.parent);
        }
    }
}