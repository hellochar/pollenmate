using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwipeProfile : MonoBehaviour
{
    public SwipeProfileScriptableObject Profile;
    public TMP_Text NameText;

    public void FromSwipeProfile(SwipeProfileScriptableObject profile)
    {
        Profile = profile;
        Debug.Log($"PROFILE NAME: {Profile.Name}");
        NameText.text = Profile.Name;
    }

    void Start()
    {

    }
    
    void Update()
    {
        
    }
}
