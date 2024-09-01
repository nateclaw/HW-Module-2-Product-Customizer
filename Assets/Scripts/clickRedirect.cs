using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class clickRedirect : MonoBehaviour
{
    
    WeaponCustomizer wC;
    GameObject weaponCurrent;
    // Start is called before the first frame update
    void Start()
    {
        wC = GameObject.FindGameObjectWithTag("WeaponCustomizer").GetComponent<WeaponCustomizer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
    public void onReset()   // when the Reset button is pressed
    {
        weaponCurrent = wC.getWeapon();
        weaponCurrent.GetComponentInChildren<MaterialChange>().matReset();
        wC.Reset();
        
    }
    public void onNext()   // when the Next button is pressed
    {
        weaponCurrent = wC.getWeapon();
        weaponCurrent.GetComponentInChildren<MaterialChange>().changeMatNext();

    }
    public void onPrev() // when the Last button is pressed
    {
        weaponCurrent = wC.getWeapon();
        weaponCurrent.GetComponentInChildren<MaterialChange>().changeMatPrev();
    }
}
