using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Video Action", menuName = "ScriptableObjects/VideoAction", order = 1)]
public class VideoAction : ScriptableObject
{
    
    public double timestamp;
    public string action;
    public bool invoked;
    
}
