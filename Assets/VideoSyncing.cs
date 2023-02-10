using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.Video;

public class VideoSyncing : MonoBehaviour
{
    
    public VideoPlayer video;
    public List<VideoAction> actions;
    public GameObject door;
    public Transform doorloc;

    private void Update()
    {
        
        double currentTime = video.time;

        foreach (var action in actions)
        {
            if (!(action.timestamp < currentTime && !action.invoked))
                continue;
            
            var method = this.GetType().GetMethod(action.action);
            method.Invoke(this, new object[] { });

            action.invoked = true;

        }
        
    }

    public void Action1()
    {
        Instantiate(door, doorloc);
    }
}
