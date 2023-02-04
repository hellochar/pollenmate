using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwipeProfileManager : MonoBehaviour
{
    public SwipeProfileScriptableObject ProfileValues;
    public TMP_Text NameText;

    void Start()
    {
        NameText.text = ProfileValues.Name;
    }
    
    void Update()
    {
        
    }
}
