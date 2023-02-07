using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskButtons : MonoBehaviour
{
    [SerializeField] private GameObject toEnable;
    [SerializeField] private GameObject group;

    public void whenPressed() {
        Transform gTran = group.transform;
        for (int i = 0; i < gTran.childCount; i++) {
            if (gTran.GetChild(i).gameObject == toEnable) {
                gTran.GetChild(i).gameObject.SetActive(true);
            } else {
                gTran.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
