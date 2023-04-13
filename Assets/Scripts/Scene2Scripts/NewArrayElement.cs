using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class NewArrayElement : MonoBehaviour, IPointerDownHandler
{
    public GameObject prefab;
    public GameObject dialogPanel;
    private BoxCollider boxCollider;


    

    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject dialog = Instantiate(dialogPanel,new Vector3(0,1,0), Quaternion.identity);

        InputField inputField = dialog.GetComponentInChildren<InputField>();

        inputField.onEndEdit.AddListener(delegate { OnInputEntered(inputField, dialog); });
    }

    private void OnInputEntered(InputField input, GameObject dialog)
    {
        GameObject newObject = Instantiate(prefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity, transform.parent);
        newObject.name = input.text;

        Destroy(dialog);
    }
}
