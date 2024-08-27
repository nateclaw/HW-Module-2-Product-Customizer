using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Mathematics;

public class IconVender : MonoBehaviour
{
    public TMP_Dropdown dropDown;

    public Sprite[] icons;
    // Start is called before the first frame update
    void Start()
    {
        List<TMP_Dropdown.OptionData> iconItems = new List<TMP_Dropdown.OptionData> ();
        foreach (var icon in icons)
        {
            var iconOption = new TMP_Dropdown.OptionData (icon.name,icon);
            iconItems.Add (iconOption);
        }
        dropDown.AddOptions(iconItems);
    }

}
