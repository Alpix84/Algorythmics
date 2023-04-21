using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class NewVariable : MonoBehaviour,IPointerDownHandler
{
   [SerializeField] private GameObject intPrefab;
   [SerializeField] private GameObject doublePrefab;
   [SerializeField] private GameObject floatPrefab;
   [SerializeField] private GameObject stringPrefab;
   [SerializeField] private GameObject boolPrefab;
   [SerializeField] private UI_InputWindowVariable inputWindow;
   private BoxCollider boxCollider;
   [SerializeField] private int collectedNumber;
   private int clickCount = 0;
   public List<KeyValuePair<string,string>> usedVariableNames = new();

   public void OnPointerDown(PointerEventData eventData)
   {
      UI_Blocker.Show_Static();
      inputWindow.Show(
         "abcdefghijklmnopqrstuvwxyz",
         5,
         () =>
         {
            Debug.Log("Cancel");
            UI_Blocker.Hide_Static();
         },
         (string inputText,string variableType) =>
         {
            if (clickCount < collectedNumber)
            {
               Debug.Log("OK!" + variableType);
               CreateNewVariable(inputText,variableType);
               UI_Blocker.Hide_Static();
               clickCount++;
            }
            else
            {
               Debug.Log("MAX ITEMS REACHED!");
               UI_Blocker.Hide_Static();
            }
         }
      );
   }

   private void CreateNewVariable(string inputName,string variableType)
   {
      GameObject newObject = new GameObject();
      switch (variableType)
      {
         case "INT":
            if (isExistingVariableName(inputName))
            {
               Debug.Log("Incorrect variable name!");
            }
            else
            {
               newObject = Instantiate(intPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity, transform.parent);
               newObject.transform.Find("Name").GetComponent<TMP_Text>().text = inputName;
               usedVariableNames.Add(new KeyValuePair<string,string>(inputName,variableType));
            }
            break;
         case "DOUBLE":
            if (isExistingVariableName(inputName))
            {
               Debug.Log("Incorrect variable name!");
            }
            else
            {
               newObject = Instantiate(doublePrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity, transform.parent);
               newObject.transform.Find("Name").GetComponent<TMP_Text>().text = inputName;
               usedVariableNames.Add(new KeyValuePair<string,string>(inputName,variableType));
            }
            break;
         case "FLOAT":
            if (isExistingVariableName(inputName))
            {
               Debug.Log("Incorrect variable name!");
            }
            else
            {
               newObject = Instantiate(floatPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity, transform.parent);
               newObject.transform.Find("Name").GetComponent<TMP_Text>().text = inputName;
               usedVariableNames.Add(new KeyValuePair<string,string>(inputName,variableType));
            }
            break;
         case "STRING":
            if (isExistingVariableName(inputName))
            {
               Debug.Log("Incorrect variable name!");
            }
            else
            {
               newObject = Instantiate(stringPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity, transform.parent);
               newObject.transform.Find("Name").GetComponent<TMP_Text>().text = inputName;
               usedVariableNames.Add(new KeyValuePair<string,string>(inputName,variableType));
            }
            break;
         case "BOOLEAN":
            if (isExistingVariableName(inputName))
            {
               Debug.Log("Incorrect variable name!");
            }
            else
            {
               newObject = Instantiate(boolPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity, transform.parent);
               newObject.transform.Find("Name").GetComponent<TMP_Text>().text = inputName;
               usedVariableNames.Add(new KeyValuePair<string,string>(inputName,variableType));
            }
            break;
      }
   }

   public bool isExistingVariableName(string variableName)
   {
      foreach (KeyValuePair<string, string> pair in usedVariableNames)
      {
         if (variableName == pair.Key)
         {
            return true;
         }
      }
      return false;
   }
}
