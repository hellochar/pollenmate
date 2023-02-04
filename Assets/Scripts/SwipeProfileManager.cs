using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwipeProfileManager : MonoBehaviour
{
    public SwipeProfileScriptableObject[] Profiles;
    public SwipeProfile DisplayedProfile;
    
    void Start()
    {
        Profiles = Resources.LoadAll<SwipeProfileScriptableObject>("Profiles");

        Debug.Log($"Found {Profiles.Length} Profiles");

        int randomProfileIndex = Random.Range(0, Profiles.Length - 1);

        DisplayedProfile.FromSwipeProfile(Profiles[randomProfileIndex]);
    }
    
    void Update()
    {
        
    }
}
