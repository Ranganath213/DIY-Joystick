using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressChange : MonoBehaviour
{
    [SerializeField] private Button pressed;
    [SerializeField] private GameObject unpressed;

    public void changeColour() {
        ColorBlock wantedColors = pressed.colors;
        wantedColors.normalColor = Color.white;
        pressed.colors = wantedColors;
    }
}
