using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObjects : MonoBehaviour
{
    [SerializeField] private GameObject toEnable;
    [SerializeField] private GameObject objectGroup;

    public void whenPressed() {
        Transform group = objectGroup.transform;
        for (int i = 0; i < group.childCount; i++) {
            if (group.GetChild(i).gameObject == toEnable) {
                group.GetChild(i).gameObject.SetActive(true);
            } else {
                group.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
