using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSelector : MonoBehaviour
{
    [SerializeField] private GameObject toShow;
    [SerializeField] private GameObject allSelectors;

    public void whenPressed() {
        Transform selectors = allSelectors.transform;
        for (int i = 0; i < selectors.childCount; i++) {
            if (selectors.GetChild(i).gameObject == toShow) {
                selectors.GetChild(i).gameObject.SetActive(true);
            } else {
                selectors.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
