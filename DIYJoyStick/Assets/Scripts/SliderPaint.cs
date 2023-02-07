using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderPaint : MonoBehaviour
{
    /*public GameObject paintBrush;
    public void OnSliderChange(float value) {
        PaintIn3D.P3dPaintSphere paintSphere = paintBrush.GetComponent<PaintIn3D.P3dPaintSphere>();
        paintSphere.Radius = value;
    }*/

    public GameObject paintBrush;
    PaintIn3D.P3dPaintSphere paintSphere;

    private void Start() {
        paintSphere = paintBrush.GetComponent<PaintIn3D.P3dPaintSphere>();
    }
    public void OnSliderChange(float value) {
        paintSphere.Radius = value;
    }
}
