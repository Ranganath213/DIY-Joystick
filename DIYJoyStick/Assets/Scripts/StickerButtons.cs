using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerButtons : MonoBehaviour
{
    [SerializeField] private PaintIn3D.P3dPaintDecal paintDecal;
    [SerializeField] private Texture newSticker;

    public void changeSticker() {
        paintDecal.Texture = newSticker;
    }
}
