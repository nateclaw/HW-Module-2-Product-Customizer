using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using Unity.Mathematics;
public class MaterialChange : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> attachments; // Reference to the child object
    [SerializeField]
    private int i = 0;
    [SerializeField]
    private Material[] newMaterials; // Reference to the new material

   
    Transform[] childLeash;
    private void Start()
    {
        
        // Get the child object from the parent object
        childLeash = GetComponentsInChildren<Transform>(true);
        

        attachments = new List<GameObject>();

        foreach (Transform child in childLeash)
        {
            if (child.CompareTag("Default"))
            {
                attachments.Add(child.gameObject);
            }
        }

        // Change the material of the child object's renderer component to the new material
        
    }
    public void changeMatNext()
    {
        if (newMaterials.Length > 1)
        {
            i++;
            if (i >= newMaterials.Length)
            { i = 0; }
            foreach (var part in attachments)
            {
                part.GetComponent<Renderer>().material = newMaterials[i];
            }
            gameObject.GetComponent<Renderer>().material = newMaterials[i];

        }
    }
    public void changeMatPrev()
    {
        if (newMaterials.Length > 1)
        {
            i--;
            if (i < 0)
            { i = newMaterials.Length - 1; }
            foreach (var part in attachments)
            {
                part.GetComponent<Renderer>().material = newMaterials[i];
            }
            gameObject.GetComponent<Renderer>().material = newMaterials[i];
        }
    }
    public void matReset()
    {
        if (newMaterials.Length > 1)
        {
            i = 0;
            foreach (var part in attachments)
            {
                part.GetComponent<Renderer>().material = newMaterials[i];
            }
            gameObject.GetComponent<Renderer>().material = newMaterials[i];
        }
    }
}
