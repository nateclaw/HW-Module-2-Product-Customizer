using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class RotateSlider : MonoBehaviour
{
    public Slider rotationSlider;

    float angleSliderNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        angleSliderNum = rotationSlider.value * 270f;   // gets the value that the slider UI is at, multiplies by a constant int
        this.transform.rotation = Quaternion.Euler(angleSliderNum, 0.0f, 0.0f); // updates the rotation based on the slider's position
    }

    public void Reset() // resets everything to default values upon the Reset Button being pressed
    {
        rotationSlider.value = 0;
        angleSliderNum = 0;
        transform.rotation = Quaternion.Euler(-90, 0, 0);
        
    }

}
