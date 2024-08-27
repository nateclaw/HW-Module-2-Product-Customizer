using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Mathematics;

public class WeaponCustomizer : MonoBehaviour
{
    private int currentWeapon;                                 //current weapon index

    [SerializeField]
    private GameObject[] weapons;                              //private list of GameObjects called weapons

    public TMP_Dropdown dropDown;               //the dropdown UI menu

    [SerializeField]
    private Sprite[] icons;                     //array of the weapon icon sprites

    
    // Start is called before the first frame update
    void Start()
    {


        weapons = GameObject.FindGameObjectsWithTag("Weapon"); //Finds all GameObjects tagged "Weapon" and adds them to "weapons" list
        
        foreach (var weapon in weapons)
        {
            print(weapon.name + "Deactivated");
            weapon.SetActive(false);    //makes all weapons inactive in the current scene
        }
        weapons[0].SetActive(true);
        print(weapons[0].name + " Activated");
        var dropdown = gameObject.GetComponent<TMP_Dropdown>();
        dropdown.options.Clear();
        
        ArrayList guns = new ArrayList();   //Array of Names for the Guns to use on the Dropdown menu
        guns.Add("MA5D - \"Assault Rifle\"");
        guns.Add("BR85N - \"Magnum\"");
        guns.Add("BR85N - \"Battle Rifle\"");
        guns.Add("M395 - \"DMR\"");
        guns.Add("M20 - \"SMG\"");
        guns.Add("M9  - \"fragmentation grenade\"");
        
        List<TMP_Dropdown.OptionData> iconItems = new List<TMP_Dropdown.OptionData>();
        foreach (var icon in icons)
        {
            var iconOption = new TMP_Dropdown.OptionData(icon.name, icon);
            iconItems.Add(iconOption);
        }

        for (int i = 0;i<guns.Count;i++)
        {
            
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = (string)guns[i], image = (Sprite)icons[i] }) ;
            
            

            dropdown.onValueChanged.AddListener(delegate { DropdownWeaponsSelected(dropdown); });
            

        }

        
        
    }
    void DropdownWeaponsSelected(TMP_Dropdown dropdown)
    {

        if (weapons[currentWeapon] != null)
        {
            
            weapons[currentWeapon].GetComponentInChildren<MaterialChange>().matReset();
            weapons[currentWeapon].GetComponentInChildren<Renderer>().enabled = false;
            weapons[currentWeapon].SetActive(false);

        }
        else
        {
            Debug.LogWarning("Unexpected null weapon in WeaponCustomizer A");
        }
        currentWeapon = dropdown.value;

        if (weapons[currentWeapon] != null)
        {
            weapons[currentWeapon].SetActive(true);
            weapons[currentWeapon].GetComponentInChildren<Renderer>().enabled = true;
        }
        else
        {
            Debug.LogWarning("Unexpected null weapon in WeaponCustomizer B");
        }
    }
    public void Reset()
    {
        foreach (var weapon in weapons)
        {
            print(weapon.name + "Deactivated");
            weapon.SetActive(false);    //makes all weapons inactive in the current scene
        }
        weapons[0].SetActive(true);
        dropDown.value = 0;
    }
    public GameObject getWeapon()
    {
        return weapons[currentWeapon];
    }
    
}
