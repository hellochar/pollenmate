using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SwipeProfileScriptableObject", order = 1)]
public class SwipeProfileScriptableObject : ScriptableObject
{
    public string Name;
    public string Species;
    public int Age;
    public int Height;
    public string AboutMe;
    public string Interests;

    // TEMP:
    string IdealDate;
    string LookingFor;
}
