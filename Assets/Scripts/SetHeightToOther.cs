using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHeightToOther : MonoBehaviour {
    public RectTransform other;
    private RectTransform rt;

    void Start() {
        rt = GetComponent<RectTransform>();
        Update();
    }

    void Update() {
        var newSizeDelta = rt.sizeDelta;
        newSizeDelta.y = other.sizeDelta.y;
        rt.sizeDelta = newSizeDelta;
    }
}
