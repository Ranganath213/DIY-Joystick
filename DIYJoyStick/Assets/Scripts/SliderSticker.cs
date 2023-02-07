using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderSticker : MonoBehaviour
{
    public GameObject sticker;

    public void OnSliderChange(float value) {
        PaintIn3D.P3dPaintDecal paintdecal = sticker.GetComponent<PaintIn3D.P3dPaintDecal>();
        paintdecal.Radius = value;
    }
}
