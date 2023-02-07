using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StyleButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] arrows;

    [SerializeField] private GameObject[] buttonsContainer;

    [SerializeField] private MeshRenderer[] logoMeshMats;
    [SerializeField] private MeshRenderer[] menuMeshMats;
    [SerializeField] private MeshRenderer[] XYABMeshMats;

    public List<ButtonStyleMats> buttonMatItems;

    public ButtonStyleMats defaultMatItem;

    void OnEnable()
    {
        SelectButtonStyle(0);
    }

    public void SelectButtonStyle(int index = 0)
    {
        for (int i = 0; i < arrows.Length; i++)
        {
            arrows[i].SetActive(index == i);
        }

        ButtonStyleMats style = buttonMatItems.Find(x => x.id == index);
        AssignMatirealsToMeshes(style);
        EnableButtonMeshes();
    }

    void EnableButtonMeshes()
    {
        for (int i = 0; i < buttonsContainer.Length; i++)
        {
            buttonsContainer[i].SetActive(true);
        }
    }

    public void DisableButtonMeshes()
    {
        for (int i = 0; i < buttonsContainer.Length; i++)
        {
            buttonsContainer[i].SetActive(false);
        }
    }

    void AssignMatirealsToMeshes(ButtonStyleMats _mats)
    {
        for (int i = 0; i < logoMeshMats.Length; i++)
        {
            logoMeshMats[i].material = _mats.logoMat;
        }
        for (int i = 0; i < menuMeshMats.Length; i++)
        {
            menuMeshMats[i].material = _mats.menuMat;
        }
        for (int i = 0; i < XYABMeshMats.Length; i++)
        {
            XYABMeshMats[i].material = _mats.XYABMat;
        }
    }


}
[Serializable]
public struct ButtonStyleMats
{
    public int id;
    public Material logoMat;
    public Material menuMat;
    public Material XYABMat;
}
