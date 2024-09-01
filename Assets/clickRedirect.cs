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
        weaponCurrent = wC.getWeapon();
        

    }
    public void onReset()
    {
        weaponCurrent.GetComponentInChildren<MaterialChange>().matReset();
        wC.Reset();
        
    }
    public void onNext()
    {
        weaponCurrent.GetComponentInChildren<MaterialChange>().changeMatNext();

    }
    public void onPrev()
    {
        weaponCurrent.GetComponentInChildren<MaterialChange>().changeMatPrev();
    }
}
