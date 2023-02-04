using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwipeProfileManager : MonoBehaviour
{
    public SwipeProfileScriptableObject[] Profiles;
    
    void Start()
    {
        Profiles = Resources.LoadAll<SwipeProfileScriptableObject>("Profiles");

        Debug.Log($"Found {Profiles.Length} Profiles");
    }
    
    void Update()
    {
        
    }
}
