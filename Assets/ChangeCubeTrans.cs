using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class ChangeCubeTrans : MonoBehaviour
{
    public GameObject Slider;
    public GameObject String;
    public TextMesh StringTxt;
    // Start is called before the first frame update
    void Start() {
    }

    public void SetCubeTrans() {
        float StringValue = Slider.GetComponent<PinchSlider>().SliderValue;
        Vector3 StringScale = String.transform.localScale;
        StringScale.x = StringValue;
        StringScale.z = StringValue;
        String.transform.localScale = StringScale;
        StringTxt.text = StringScale.x.ToString();
    }
}
