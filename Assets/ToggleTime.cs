using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using Unity.VisualScripting;

public class ToggleTime : MonoBehaviour
{
    [SerializeField]
    private GameObject barrel1;
    [SerializeField] private GameObject barrel2;
    [SerializeField] private GameObject barrel3;
    [SerializeField] private GameObject barrel4;
    [SerializeField] private GameObject barrel5;
    [SerializeField] private GameObject barrel6;

    [SerializeField] private GameObject scope1;
    [SerializeField] private GameObject scope2;
    [SerializeField] private GameObject scope3;
    [SerializeField] private GameObject scope4;
    [SerializeField] private GameObject scope5;

    [SerializeField] private GameObject underBarrel1;
    [SerializeField] private GameObject underBarrel2;
    [SerializeField] private GameObject underBarrel3;
    [SerializeField] private GameObject underBarrel4;
    [SerializeField] private GameObject underBarrel5;

    public UnityEngine.UI.Toggle Scope;
    public UnityEngine.UI.Toggle underBarrel;
    public UnityEngine.UI.Toggle Barrel;


    private bool isToggled = false; // Bool variable to store the state
    // Start is called before the first frame update
    void Start()
    {
        barrel1.SetActive(false); barrel2.SetActive(false);
        barrel3.SetActive(false); barrel4.SetActive(false);
        barrel5.SetActive(false); barrel6.SetActive(false);

        underBarrel1.SetActive(false); underBarrel2.SetActive(false);
        underBarrel3.SetActive(false); underBarrel4.SetActive(false);
        //underBarrel5.SetActive(false);

        scope1.SetActive(false); scope2.SetActive(false);
        scope3.SetActive(false); scope4.SetActive(false);
        scope5.SetActive(false);

        

        Scope.onValueChanged.AddListener(OnToggleValueChanged);
    }

    private void OnToggleValueChanged(bool newValue)
    {
    
    }
        // Update is called once per frame
        void Update()
    {
        if (underBarrel)
        {
            underBarrel1.SetActive(true); underBarrel2.SetActive(true);
            underBarrel3.SetActive(true); underBarrel4.SetActive(true);
        }
        else
        {
            underBarrel1.SetActive(false); underBarrel2.SetActive(false);
            underBarrel3.SetActive(false); underBarrel4.SetActive(false);
        }

        if(Barrel)
        {
            barrel1.SetActive(true); barrel2.SetActive(true);
            barrel3.SetActive(true); barrel4.SetActive(true);
            barrel5.SetActive(true); barrel6.SetActive(true);
        }
        else
        {
            barrel1.SetActive(false); barrel2.SetActive(false);
            barrel3.SetActive(false); barrel4.SetActive(false);
            barrel5.SetActive(false); barrel6.SetActive(false);
        }

        if (Scope)
        {
            scope1.SetActive(true); scope2.SetActive(true);
            scope3.SetActive(true); scope4.SetActive(true);
            scope5.SetActive(true);
        }
        else
        {
            scope1.SetActive(false); scope2.SetActive(false);
            scope3.SetActive(false); scope4.SetActive(false);
            scope5.SetActive(false);
        }
    }

    public void activateBarrels()
    {
        
    }

    public void deactivateBarrels()
    {
        
    }

    public void activateUnderBarrels()
    {
        
        //underBarrel5.SetActive(true);
    }
    public void deactivateUnderBarrels()
    {
        
        //underBarrel5.SetActive(false);
    }
    public void activateScopes()
    {
        
    }
    public void deactivateScopes()
    {
        
    }
}
