using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderTorbaRotation : MonoBehaviour
{
    public GameObject torba;
    Vector3 wantedAngles;

    public void OnSliderChange(float value) {

        wantedAngles = torba.transform.eulerAngles;
        wantedAngles.y = -value;    //negative because of the direction of the rotation
        
        torba.transform.eulerAngles = wantedAngles;
    }
}
