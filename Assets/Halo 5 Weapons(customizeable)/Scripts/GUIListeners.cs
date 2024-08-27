using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
/*using namespace std;*/
public class GUIListeners : MonoBehaviour
{
    /*  // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {

      }*/
    private int currentWeapon;

    [SerializeField]
    private GameObject sliderObject;

    //[SerializeField]
    //private GameObject[] weapons;


    void Start()
    {
        /*weapons = GameObject.FindGameObjectsWithTag("Weapon");


        foreach (var weapon in weapons)
        {
            weapon.SetActive(false);
        }

        if (weapons[currentWeapon] != null) { weapons[currentWeapon].SetActive(true); }
        else
        {
            Debug.LogWarning("Unexpected null weapon in GUIListeners");
        }
    }
    public void OnClickMeClicked()
    {
        Debug.Log("Click ME! Clicked");
        //1) Make the current weapon invisible
        weapons[currentWeapon].SetActive(false);

        //2) Advance to the next weapon
        currentWeapon = (currentWeapon + 1) % weapons.Length;

        //2.5) Synchronize GUI state w/ game state
        sliderObject.GetComponent<Slider>().value = weapons[currentWeapon].transform.localScale.x;
        //scaleSlider 

        //3) Make the current weapon visible
        weapons[currentWeapon].SetActive(true);
    }


    public void OnScaleSliderValueChanged (float newScale)
    {
        weapons[currentWeapon].transform.localScale = new Vector3(newScale, newScale, newScale);
    }*/
    }
}
