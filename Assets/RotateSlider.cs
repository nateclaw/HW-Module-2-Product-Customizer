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
        angleSliderNum = rotationSlider.value * 270f;
        this.transform.rotation = Quaternion.Euler(angleSliderNum, 0.0f, 0.0f);
    }

    public void Reset()
    {
        rotationSlider.value = 0;
        angleSliderNum = 0;
        transform.rotation = Quaternion.Euler(-90, 0, 0);
        
    }

}
